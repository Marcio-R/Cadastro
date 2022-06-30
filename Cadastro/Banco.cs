using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    class Banco
    {
        private static SqlConnection conecta;

        public static SqlConnection Conexao()
        {
            conecta = new SqlConnection("Data Source=DESKTOP-KB48KMI\\SQLEXPRESS;Initial Catalog=Teste_cadastro;Integrated Security=True");
            conecta.Open();
            return conecta;
        }

        public static DataTable MostraTodos()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Pessoas", Conexao());
            DataTable dados = new DataTable();
            adapter.Fill(dados);
            Conexao().Close();
            return dados;
        }

        public static void NovaPessoa(Pessoa p)
        {
            try
            {
                var cmd = Conexao().CreateCommand();
                cmd.CommandText = "Insert Into Pessoas (Nome, Telefone) Values (@Nome,@Telefone)";
                cmd.Parameters.AddWithValue("@Nome", p.Nome);
                cmd.Parameters.AddWithValue("@Telefone", p.Telefone);
                cmd.ExecuteNonQuery();
                Conexao().Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar nova pessoa", ex.Message);
                Conexao().Close();
            }
        }

        public static void Atualizar(Pessoa p)
        {
            try
            {
                var cmd = Conexao().CreateCommand();
                cmd.CommandText = $"Update Pessoas Set Nome = @Nome, Telefone = @Telefone Where Id = {p.Id}";
                cmd.Parameters.AddWithValue("@Nome", p.Nome);
                cmd.Parameters.AddWithValue("@Telefone", p.Telefone);
                cmd.ExecuteNonQuery();
                Conexao().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Delete(Pessoa pe)
        {
            try
            {
                var cmd = Conexao().CreateCommand();
                cmd.CommandText = $"delete from Pessoas Where Id = {pe.Id}";
                cmd.ExecuteNonQuery();
                Conexao().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
