using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace WS.DAL
{

    public class Usuario
    {

        public static void Inserir(Model.Usuario obj)
        {
            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const String cmd = "INSERT INTO BLOG.USUARIO (NOME_USUARIO, SENHA_USUARIO, ATIVO_USUARIO) VALUES (:NOME_USUARIO, :SENHA_USUARIO, :ATIVO_USUARIO)";

                using (var k = new OracleCommand(cmd, c))
                {
                    k.Parameters.Add(":NOME_USUARIO", obj.Nome);
                    k.Parameters.Add(":SENHA_USUARIO", obj.Senha);
                    k.Parameters.Add(":ATIVO_USUARIO", obj.Ativo);

                    c.Open();

                    k.ExecuteNonQuery();

                    c.Close();
                }
            }
        }

        public static void Alterar(Model.Usuario obj)
        {
            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const String cmd = "UPDATE BLOG.USUARIO SET NOME_USUARIO = :NOME_USUARIO, SENHA_USUARIO = :SENHA_USUARIO, ATIVO_USUARIO = :ATIVO_USUARIO WHERE CODIGO_USUARIO = :CODIGO_USUARIO";

                using (var k = new OracleCommand(cmd, c))
                {
                    k.Parameters.Add(":NOME_USUARIO", obj.Nome);
                    k.Parameters.Add(":SENHA_USUARIO", obj.Senha);
                    k.Parameters.Add(":ATIVO_USUARIO", obj.Ativo);
                    k.Parameters.Add(":CODIGO_USUARIO", obj.Codigo);

                    c.Open();

                    k.ExecuteNonQuery();

                    c.Close();
                }
            }
        }

        public static void Excluir(Model.Usuario obj)
        {
            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const string cmd = "DELETE FROM BLOG.USUARIO WHERE CODIGO_USUARIO = :CODIGO_USUARIO";

                using (var k = new OracleCommand(cmd, c))
                {
                    k.Parameters.Add(":CODIGO_USUARIO", obj.Codigo);

                    c.Open();

                    k.ExecuteNonQuery();

                    c.Close();
                }
            }
        }

        public static Model.Usuario Logar(Model.Usuario obj)
        {
            Model.Usuario retorno = null;

            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const string cmd =
                    "SELECT * FROM BLOG.USUARIO WHERE NOME_USUARIO = :NOME_USUARIO AND SENHA_USUARIO = :SENHA_USUARIO";

                using (var k = new OracleCommand(cmd, c))
                {
                    k.Parameters.Add(":NOME_USUARIO", obj.Nome);
                    k.Parameters.Add(":SENHA_USUARIO", obj.Senha);

                    c.Open();

                    var dr = k.ExecuteReader();

                    if (dr.Read())
                    {
                        retorno = new Model.Usuario(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), Convert.ToChar(dr[3]));
                    }

                    c.Close();
                }
            }
            return retorno;
        }

        public static IEnumerable<Model.Usuario> Selecionar()
        {

            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const string cmd = "SELECT * FROM BLOG.USUARIO";

                using (var k = new OracleCommand(cmd, c))
                {
                    c.Open();

                    var dr = k.ExecuteReader();

                    while (dr.Read())
                    {
                        yield return new Model.Usuario(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), Convert.ToChar(dr[3]));
                    }

                    c.Close();

                }
            }
        }
    }
}