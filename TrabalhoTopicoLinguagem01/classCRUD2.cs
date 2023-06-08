using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;

namespace TrabalhoTopicoLinguagem01
{
    public class UsuariosDAO : Conexao
    {
        public List<Usuario> Listar()
        {
            return conexao.Query<Usuario>(" select U.id as 'CODIGO',  U.NOME, U.NOME_LOGIN, U.SENHA, TU.DESCRICAO AS 'TIPO_USUARIO' FROM USUARIOS U " +
                                          " INNER JOIN TIPO_USUARIOS TU ON TU.ID = U.TIPO_USUARIOS ").ToList();
        }

        public void Atualizar(int id, string nome, string nome_login, string senha, int tipo_usuario)
        {
            conexao.Execute("UPDATE USUARIOS SET ID= @ID, NOME=@NOME, NOME_LOGIN=@NOME_LOGIN, SENHA=@SENHA, TIPO_USUARIOS=@TIPO_USUARIOS WHERE ID=@ID", new
            {
                @ID = id,
                @NOME = nome,
                @NOME_LOGIN = nome_login,
                @SENHA = senha,
                @TIPO_USUARIOS = tipo_usuario
            });
        }
        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM USUARIOS WHERE ID=@ID", new
            {
                @ID = id
            });
        }

        public void Adicionar(string nome, string nome_login, string senha, int tipo_usuario)
        {
            conexao.Execute("INSERT INTO  USUARIOS( NOME, NOME_LOGIN, SENHA, TIPO_USUARIOS) VALUES (@NOME, @NOME_LOGIN, @SENHA, @TIPO_USUARIOS)", new
            {
                @NOME = nome,
                @NOME_LOGIN = nome_login,
                @SENHA = senha,
                @TIPO_USUARIOS = tipo_usuario
            });
        }

        public bool Login(string login, string senha)
        {

            return conexao.Query("SELECT * FROM Usuarios WHERE NOME_LOGIN=@pLogin AND SENHA = @pSenha", new
            {
                @plogin = login,
                @pSenha = senha
            }).Any();
  
        }
    }
}
