using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Recording_Evolution
{
    
    class BancoDeDados
    {

        MySqlConnection Conexao;
        MySqlCommand comando;

        public BancoDeDados()
        {
            try
            {
                Conexao = new MySqlConnection($"datasource=localhost;username=root;password=;database=recordingevolution; convert zero datetime=True");

            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool ExisteNaTabela(string comandoPesquisa)
        {
            Conexao.Open();

            comando = new MySqlCommand(comandoPesquisa, Conexao);
            
            try
            {
                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                Conexao.Close();

                if (resultado == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception e)
            {
                Conexao.Close();
                return false;
            }
        }
        public string BuscaNaTabela(string oqBuscar, string tabela, string onde1 = "",  string valor1 = "", string onde2 = "", string valor2 = "")
        {
            Conexao.Open();

            string valorRetornado = "";
            string comandoPesquisa = comandoPesquisa = $" SELECT {oqBuscar} FROM {tabela} WHERE {onde1} = '{valor1}' AND {onde2} = '{valor2}' ; ";

            comando = new MySqlCommand(comandoPesquisa, Conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                valorRetornado = leitor[oqBuscar].ToString();
            }
            
            Conexao.Close();

            return valorRetornado;
        }

        public void PreencheGrid(string comando, DataTable dataTable)
        {
            Conexao.Open();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, Conexao);
            adaptador.Fill(dataTable);

            Conexao.Close();
        }
        public void InsereNaTabela(string tabela, string ondeInserir1, string ondeInserir2, string ondeInserir3, string oqInserir1, string oqInserir2, string oqInserir3)
        {
            Conexao.Open();
            string comandoInsere = $" INSERT INTO {tabela} ({ondeInserir1}, {ondeInserir2}, {ondeInserir3}) VALUES ('{oqInserir1}', '{oqInserir2}', '{oqInserir3}') ; ";

            comando = new MySqlCommand(comandoInsere, Conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            Conexao.Close();
        }

        public void AtualizaTabela(string tabela, string set, string valorSet, string where, string valorWhere, string and, string valorAnd)
        {
            Conexao.Open();
            string comandoAtualiza = $" UPDATE {tabela} SET {set} = '{valorSet}' WHERE {where} = '{valorWhere}' and {and} = '{valorAnd}'; ";

            comando = new MySqlCommand(comandoAtualiza, Conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            Conexao.Close();
        }

        
        
    }

    
}
