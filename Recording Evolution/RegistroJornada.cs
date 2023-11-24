using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recording_Evolution
{
    public partial class RegistroJornada : Form
    {
        BancoDeDados banco = new BancoDeDados();

        int i = 0;

        //Passa informções do login atual para as outras classes
        string cpf, senha;

        public RegistroJornada(string nome, string cpf , string senha)
        {
            InitializeComponent();
            lblNomeFuncionario.Text = nome;

            this.cpf = cpf;
            this.senha = senha;
        }
        private void MudaLabel(string ultimoRegistro)
        {
            switch (ultimoRegistro)
            {
                case "horarioEntrada":
                    lblProximoRegistro.Text = "--:--";

                    break;

                case "horarioEntradaAlmoco":

                    lblProximoRegistro.Text = banco.BuscaNaTabela(ultimoRegistro, "horarios", "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd"));
                    DateTime ajustaData = Convert.ToDateTime(lblProximoRegistro.Text);
                    lblProximoRegistro.Text = ajustaData.AddHours(1).ToString("HH:mm");

                    break;

                case "horarioSaidaAlmoco":

                    lblProximoRegistro.Text = "18:00";

                    break;

                default:

                    lblProximoRegistro.Text = "--:--";

                    break;
            }
        }
        private string retornaRegistros(out string ultimoRegistro)
        {
            ultimoRegistro = "--:--";

            string[] horarios = {"horarioEntrada", "horarioEntradaAlmoco", "horarioSaidaAlmoco", "horarioSaida"};

            foreach (string horario in horarios)
            {
                
                if (!banco.ExisteNaTabela($" SELECT COUNT(*) FROM horarios WHERE cpf = '{cpf}' AND dataTrabalho = '{DateTime.Now:yyyy-MM-dd}' " +
                        $"AND {horario} IS NOT NULL ;"))
                {
                
                    MudaLabel(ultimoRegistro);
                
                    return horario;
                    
                }

                ultimoRegistro = horario;
            }
            return "Todos os horários já foram registrados";
        }

        private void RegistroJornada_Load(object sender, EventArgs e)
        {
            painelMenu.Size = new Size(0, 0);
            retornaRegistros(out string ultimoRegistro);

            if (ultimoRegistro != "--:--")
            {
                lblUltimoRegistro.Text = banco.BuscaNaTabela(ultimoRegistro, "horarios", "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd"));
            }
            else
            {
                lblUltimoRegistro.Text = "--:--";
            }
        }

        //Botões principais
        private void botaoRegistro_Click(object sender, EventArgs e)
        {
            string ultimoRegistro;

            string comandoExisteNaTabela = $" SELECT COUNT(*) FROM horarios WHERE cpf = '{cpf}' AND dataTrabalho = '{DateTime.Now:yyyy-MM-dd}' AND {retornaRegistros(out ultimoRegistro)} IS NOT NULL ;";

            if (!banco.ExisteNaTabela(comandoExisteNaTabela) && retornaRegistros(out ultimoRegistro) == "horarioEntrada")
            {
                banco.InsereNaTabela("horarios", "cpf", "dataTrabalho", retornaRegistros(out ultimoRegistro), cpf, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH:mm:ss"));
                retornaRegistros(out ultimoRegistro);
                lblUltimoRegistro.Text = banco.BuscaNaTabela(ultimoRegistro, "horarios", "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd")); ;
            }

            else if(!banco.ExisteNaTabela(comandoExisteNaTabela) && retornaRegistros(out ultimoRegistro) != "Todos os horários já foram registrados")
            {
                banco.AtualizaTabela("horarios", retornaRegistros(out ultimoRegistro), DateTime.Now.ToString("HH:mm:ss"), "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd"));
                retornaRegistros(out ultimoRegistro);
                lblUltimoRegistro.Text = banco.BuscaNaTabela(ultimoRegistro, "horarios", "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd")); ;
            }

            else
            {
                MessageBox.Show(retornaRegistros(out ultimoRegistro));
            }

        }

        private void botaoObservacao_Click(object sender, EventArgs e)
        {

            Observacoes telaObs = new Observacoes(cpf, DateTime.Now);
            telaObs.Show();

        }

        //Sai do aplicativo
        private void RegistroJornada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void abreMenu(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                painelMenu.Size = new Size(240, 369);
            }
            else
            {
                painelMenu.Size = new Size(0, 0);
            }
            i++;
        }
        private void LogOff(object sender, EventArgs e)
        {
            Login telaEntrar = new Login();
            this.Hide();
            telaEntrar.Show();
        }

        private void abreHistorico(object sender, EventArgs e)
        {
            telaHistorico telaHistorico = new telaHistorico(cpf, senha);
            telaHistorico.Show();
        }

        private void botaoAtestados_Click(object sender, EventArgs e)
        {
            Atestados telaAtestados = new Atestados(cpf);
            telaAtestados.Show();
        }

        private void botaoNotificacoes_Click(object sender, EventArgs e)
        {
            Notificacoes telaNotificacoes = new Notificacoes();
            telaNotificacoes.Show();
        }

    }
}
