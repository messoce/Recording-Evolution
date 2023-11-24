using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recording_Evolution
{
    class Funcionarios
    {
        public string Id { get; set; }
        public string Cpf { get; set; }
        public string DataTrabalho { get; set; }
        public string HorarioEntrada { get; set; }
        public string HorarioEntradaAlmoco { get; set; }
        public string HorarioSaidaAlmoco { get; set; }

        public string HorarioSaida{ get; set; }

        /*public List<string> ListaFuncionarios(DataTable tabela)
        {
            BancoDeDados banco = new BancoDeDados();
            List<string> listaFuncionarios = new List<string>();

            listaFuncionarios =  banco.GetLista("id", "funcionarios");
            foreach(string funcionario in listaFuncionarios)
            {
                MessageBox.Show(funcionario);
            }
            return listaFuncionarios;
        }*/
    }
}
