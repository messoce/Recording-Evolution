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
    public partial class Login : Form
    {
        
        BancoDeDados bancoDeDados = new BancoDeDados();
        RegistroJornada janelaRegistroJ;
        TelaAdmin admin = new TelaAdmin();

        public Login()
        {
            InitializeComponent();
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            
            if (bancoDeDados.ExisteNaTabela($" SELECT COUNT(*) FROM funcionarios WHERE cpf = '{txtBoxCPF.Text}' AND senha = '{txtBoxSenha.Text}' ; ") == true)
                
            {
                this.Hide();

                janelaRegistroJ = new RegistroJornada(bancoDeDados.BuscaNaTabela("nome", "funcionarios", "cpf", txtBoxCPF.Text, "senha", txtBoxSenha.Text), txtBoxCPF.Text, txtBoxSenha.Text);
                janelaRegistroJ.Show();
            }

            else if (txtBoxCPF.Text == "admin")
            {
                this.Hide();
                admin.Show();
            }

            else
            {
                MessageBox.Show("Login inválido");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = true;
        }
    }
}
