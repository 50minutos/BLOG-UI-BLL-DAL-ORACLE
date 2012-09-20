using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace WS.DAL
{
    public class Post
    {
        public static void Inserir(Model.Post obj)
        {
            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const String cmd = "INSERT INTO BLOG.POST (TITULO_POST, CONTEUDO_POST, DATA_INCLUSAO_POST, DATA_LIBERACAO_POST, CODIGO_USUARIO, PRIVADO_POST) VALUES (:TITULO_POST, :CONTEUDO_POST, :DATA_INCLUSAO_POST, :DATA_LIBERACAO_POST, :CODIGO_USUARIO, :PRIVADO_POST)";

                using (var k = new OracleCommand(cmd, c))
                {
                    k.Parameters.Add(":TITULO_POST", obj.Titulo);
                    k.Parameters.Add(":CONTEUDO_POST", obj.Conteudo);
                    k.Parameters.Add(":DATA_INCLUSAO_POST", DateTime.Now);
                    k.Parameters.Add(":DATA_LIBERACAO_POST", obj.DataLiberacao);
                    k.Parameters.Add(":CODIGO_USUARIO", obj.CodigoUsuario);
                    k.Parameters.Add(":PRIVADO_POST", obj.Privado);

                    c.Open();

                    k.ExecuteNonQuery();

                    var codigo = ObterCodigoPost(c);

                    foreach (var item in obj.Categorias)
                    {
                        InserirPostCategoria(codigo, item.Codigo, c);
                    }

                    c.Close();
                }
            }
        }

        private static void InserirPostCategoria(int codigoPost, int codigoCategoria, OracleConnection c)
        {
            const String cmd = "INSERT INTO BLOG.POST_CATEGORIA VALUES (:CODIGO_POST, :CODIGO_CATEGORIA)";

            using (var k = new OracleCommand(cmd, c))
            {
                k.Parameters.Add(":CODIGO_POST", codigoPost);
                k.Parameters.Add(":CODIGO_CATEGORIA", codigoCategoria);

                k.ExecuteNonQuery();
            }
        }

        private static int ObterCodigoPost(OracleConnection c)
        {
            int retorno;

            const String cmd = "SELECT SEQ_POST.CURRVAL FROM DUAL";

            using (var k = new OracleCommand(cmd, c))
            {
                retorno = Convert.ToInt32(k.ExecuteScalar());
            }

            return retorno;
        }

        public static void Alterar(Model.Post obj)
        {
        }

        public static void Excluir(Model.Post obj)
        {
        }

        public static IEnumerable<Model.Post> Selecionar()
        {
            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const String cmd = "SELECT P.*, C.DESCRICAO_CATEGORIA FROM BLOG.POST P INNER JOIN BLOG.POST_CATEGORIA PC ON P.CODIGO_POST = PC.CODIGO_POST INNER JOIN BLOG.CATEGORIA C ON C.CODIGO_CATEGORIA = PC.CODIGO_CATEGORIA WHERE C.DATA_EXCLUSAO_CATEGORIA IS NULL AND P.DATA_LIBERACAO_POST <= SYSDATE";

                using (var k = new OracleCommand(cmd, c))
                {
                    c.Open();

                    var dr = k.ExecuteReader();

                    Model.Post post = null;

                    while (dr.Read())
                    {
                        if (post != null && post.Codigo != Convert.ToInt32(dr[0]))
                            yield return post;

                        if (post == null || post.Codigo != Convert.ToInt32(dr[0]))
                            post = new Model.Post(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), Convert.ToDateTime(dr[3]), Convert.ToDateTime(dr[4]), Convert.ToInt32(dr[5]), Convert.ToChar(dr[6]), new List<Model.Categoria>());

                        post.Categorias.Add(new Model.Categoria(descricao: dr[7].ToString()));
                    }

                    if (post != null)
                        yield return post;

                    c.Close();
                }
            }
        }
    }
}