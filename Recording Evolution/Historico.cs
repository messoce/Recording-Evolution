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
    public partial class telaHistorico : Form
    {
        
        string cpf, senha;

        public telaHistorico(string cpf, string senha)
        {
            InitializeComponent();
            this.cpf = cpf;
            this.senha = senha;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Busca as informações de horário quando selecionar uma data
            BancoDeDados banco = new BancoDeDados();

            txtEntrada.Text = banco.BuscaNaTabela("horarioEntrada", "horarios", "cpf", cpf, "dataTrabalho", selecionaData.Value.ToString("yyyy-MM-dd"));
            txtEntradaAlmoco.Text = banco.BuscaNaTabela("horarioEntradaAlmoco", "horarios", "cpf", cpf, "dataTrabalho", selecionaData.Value.ToString("yyyy-MM-dd"));
            txtSaidaAlmoco.Text = banco.BuscaNaTabela("horarioSaidaAlmoco", "horarios", "cpf", cpf, "dataTrabalho", selecionaData.Value.ToString("yyyy-MM-dd"));
            txtSaida.Text = banco.BuscaNaTabela("horarioSaida", "horarios", "cpf", cpf, "dataTrabalho", selecionaData.Value.ToString("yyyy-MM-dd"));
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            //Busca as informações de horário assim que abrir a tela
            BancoDeDados banco = new BancoDeDados();

            txtEntrada.Text = banco.BuscaNaTabela("horarioEntrada", "horarios", "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd"));
            txtEntradaAlmoco.Text = banco.BuscaNaTabela("horarioEntradaAlmoco", "horarios", "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd"));
            txtSaidaAlmoco.Text = banco.BuscaNaTabela("horarioSaidaAlmoco", "horarios", "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd"));
            txtSaida.Text = banco.BuscaNaTabela("horarioSaida", "horarios", "cpf", cpf, "dataTrabalho", DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
