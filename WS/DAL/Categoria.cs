using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;

namespace WS.DAL
{
    public class Categoria
    {
        public static void Inserir(Model.Categoria obj)
        {
            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const String cmd = "INSERT INTO BLOG.CATEGORIA (DESCRICAO_CATEGORIA) VALUES (:DESCRICAO_CATEGORIA)";

                using (var k = new OracleCommand(cmd, c))
                {
                    k.Parameters.Add(":DESCRICAO_CATEGORIA", obj.Descricao);
             
                    c.Open();

                    k.ExecuteNonQuery();

                    c.Close();
                }
            }
        }

        public static void Alterar(Model.Categoria obj)
        {
            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const String cmd = "UPDATE BLOG.CATEGORIA SET DESCRICAO_CATEGORIA = :DESCRICAO_CATEGORIA, DATA_EXCLUSAO_CATEGORIA = :DATA_EXCLUSAO_CATEGORIA WHERE CODIGO_CATEGORIA = :CODIGO_CATEGORIA";

                using (var k = new OracleCommand(cmd, c))
                {
                    k.Parameters.Add(":DESCRICAO_CATEGORIA", obj.Descricao);
                    k.Parameters.Add(":DATA_EXCLUSAO_CATEGORIA", obj.DataExclusao); 
                    k.Parameters.Add(":CODIGO_CATEGORIA", obj.Codigo);

                    c.Open();

                    k.ExecuteNonQuery();

                    c.Close();
                }
            }
        }

        public static void Excluir(Model.Categoria obj)
        {
            obj.DataExclusao = DateTime.Now;
            Alterar(obj);
        }

        public static IEnumerable<Model.Categoria> Selecionar()
        {
            using (var c = new OracleConnection(Helper.Oracle.CS))
            {
                const string cmd = "SELECT * FROM CATEGORIA";

                using (var k = new OracleCommand(cmd, c))
                {
                    c.Open();

                    var dr = k.ExecuteReader();

                    while (dr.Read())
                    {
                        yield return new Model.Categoria(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2] as DateTime?);
                    }

                    c.Close();
                }
            }
        }
    }
}