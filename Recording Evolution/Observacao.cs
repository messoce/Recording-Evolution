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
    public partial class Observacoes : Form
    {
        BancoDeDados banco = new BancoDeDados();
        string cpf;
        DateTime dataTrabalho;
        public Observacoes(string cpf, DateTime dataTrabalho)
        {
            InitializeComponent();
            this.cpf = cpf;
            this.dataTrabalho = dataTrabalho;
            textoObservacoes.Text = banco.BuscaNaTabela("observacoes", "horarios", "cpf", cpf, "dataTrabalho", dataTrabalho.ToString("yyyy-MM-dd"));
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            banco.AtualizaTabela("horarios", "observacoes", textoObservacoes.Text, "cpf", cpf, "dataTrabalho", dataTrabalho.ToString("yyyy-MM-dd"));
            this.Hide();
        }

        private void Observacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            
        }
    }
}
