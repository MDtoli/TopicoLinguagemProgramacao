using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoTopicoLinguagem01
{
    public class ProdutosDAO : Conexao
    {
        public List<Produto> Listar2()
        {

            return conexao.Query<Produto>(" SELECT P.id as 'CODIGO', P.NOME, C.DESCRICAO AS 'CATEGORIA', P.QUANTIDADE FROM PRODUTOS P " +
                                          " INNER JOIN CATEGORIA C ON P.ID_CATEGORIA = C.ID order by P.NOME ").ToList();
        }

        public void Atualizar2(int id, string nome, string categoria, double quantidade)
        {
            conexao.Execute("UPDATE PRODUTOS SET ID= @ID, Nome=@NOME, CATEGORIA=@CATEGORIA, QUANTIDADE=@QUANTIDADE WHERE ID=@ID", new
            {
                @ID = id,
                @NOME = nome,
                @CATEGORIA = categoria,
                @QUANTIDADE = quantidade
            });
        }
        public void Excluir2(int id)
        {
            conexao.Execute("DELETE FROM PRODUTOS WHERE ID=@ID", new
            {
                @ID = id
            });
        }

        public void Adicionar2(string nome, int idcategoria, double quantidade)
        {
            conexao.Execute("INSERT INTO  PRODUTOS( NOME, ID_CATEGORIA, QUANTIDADE) VALUES (@NOME, @ID_CATEGORIA, @QUANTIDADE)", new
            {
                @NOME = nome,
                @ID_CATEGORIA = idcategoria,
                @QUANTIDADE = quantidade
            });
        }
    }

}

    