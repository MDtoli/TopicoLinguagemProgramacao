using System.Data.SqlClient;

namespace TrabalhoTopicoLinguagem01
{
    public class Conexao
    {
        
        public SqlConnection conexao = null;
        public Conexao()
        {

            conexao = new SqlConnection("Server= LAPTOP-5TAA6JLR\\SQLEXPRESS; Database = sistemaGerencial; Trusted_Connection = True;");
        }


    }
}
