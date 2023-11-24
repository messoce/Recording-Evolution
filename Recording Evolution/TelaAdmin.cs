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
    public partial class TelaAdmin : Form
    {
        Funcionarios dadosFuncionarios = new Funcionarios();
        BancoDeDados banco = new BancoDeDados();
        

        public TelaAdmin()
        {
            InitializeComponent();

            DataTable datatable = new DataTable();

            banco.PreencheGrid("select id, nome, funcionarios.cpf, dataTrabalho, horarioEntrada, horarioEntradaAlmoco, horarioSaidaAlmoco, horarioSaida, observacoes " +
                "from funcionarios inner join horarios on funcionarios.cpf = horarios.cpf;", datatable);

            dgvFuncionarios.DataSource = datatable;

            dgvFuncionarios.Columns["id"].DefaultCellStyle.BackColor = Color.LightGray;
            dgvFuncionarios.Columns["cpf"].DefaultCellStyle.BackColor = Color.LightGray;
            dgvFuncionarios.Columns["nome"].DefaultCellStyle.BackColor = Color.LightGray;
            dgvFuncionarios.Columns["dataTrabalho"].DefaultCellStyle.BackColor = Color.LightGray;
            dgvFuncionarios.Columns["observacoes"].DefaultCellStyle.BackColor = Color.LightGray;

        }

        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            string comando;

            if (txtFuncionario.Text != "")
            {
                comando = " select id, nome, funcionarios.cpf, dataTrabalho, horarioEntrada, horarioEntradaAlmoco, horarioSaidaAlmoco, horarioSaida, observacoes " +
                " from funcionarios inner join horarios on funcionarios.cpf = horarios.cpf " +
                $" where funcionarios.id ='{txtFuncionario.Text}'and horarios.dataTrabalho = '{selecionaData.Value.ToString("yyyy-MM-dd")}'; ";

                banco.PreencheGrid(comando, datatable);
            }
            else
            {
                comando = " select id, nome, funcionarios.cpf, dataTrabalho, horarioEntrada, horarioEntradaAlmoco, horarioSaidaAlmoco, horarioSaida, observacoes " +
                " from funcionarios inner join horarios on funcionarios.cpf = horarios.cpf " +
                $" where horarios.dataTrabalho = '{selecionaData.Value.ToString("yyyy-MM-dd")}'; ";

                banco.PreencheGrid(comando, datatable);
            }
            
            dgvFuncionarios.DataSource = datatable;
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFuncionarios.CurrentCell.ColumnIndex == 0 || dgvFuncionarios.CurrentCell.ColumnIndex == 1 || dgvFuncionarios.CurrentCell.ColumnIndex == 2 || dgvFuncionarios.CurrentCell.ColumnIndex == 3)
            {
                dgvFuncionarios.ReadOnly = true;
                MessageBox.Show("Apenas as células de horários podem ser alteradas");
            }
            else if (dgvFuncionarios.CurrentCell.ColumnIndex == 8)
            {
                MessageBox.Show("Observação:\n" + banco.BuscaNaTabela("observacoes", "horarios", "cpf", retornaCpfeData(out string dataTrabalho), "dataTrabalho", dataTrabalho));
            }
            else
            {
                dgvFuncionarios.ReadOnly = false;
            }
        }

        private string retornaCpfeData(out string dataTrabalho)
        {
            int indexRow = dgvFuncionarios.CurrentCell.RowIndex;

            string valorCpfFuncionario = dgvFuncionarios.Rows[indexRow].Cells[2].Value.ToString();
            dataTrabalho = dgvFuncionarios.Rows[indexRow].Cells[3].Value.ToString();

            DateTime adaptaData = Convert.ToDateTime(dataTrabalho);
            dataTrabalho = adaptaData.ToString("yyyy-MM-dd");

            return valorCpfFuncionario;
        }

        private void dgvFuncionarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string nomeColuna = dgvFuncionarios.CurrentCell.OwningColumn.HeaderText;
            string valorAtualCelula = dgvFuncionarios.CurrentCell.Value.ToString();

            banco.AtualizaTabela("horarios", nomeColuna, valorAtualCelula, "cpf", retornaCpfeData(out string dataTrabalho), "dataTrabalho", dataTrabalho);
        }

        private void TelaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.Show();
        }
    }
}
