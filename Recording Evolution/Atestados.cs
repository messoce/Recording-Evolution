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
    public partial class Atestados : Form
    {
        string cpf;
        public Atestados(string cpf)
        {
            InitializeComponent();
            this.cpf = cpf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog telaDeArquivos = new OpenFileDialog();
            telaDeArquivos.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            DialogResult resultado = telaDeArquivos.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                pictureBox1.ImageLocation = telaDeArquivos.FileName;
            }
            else
            {
                MessageBox.Show("Arquivo inválido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dataTrabalho = dateTimePicker1.Value;
            Observacoes obs = new Observacoes(cpf, dataTrabalho);
            obs.Show();
        }
    }
}
