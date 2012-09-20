using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WS.Model
{
    [DataContract]
    public class Post
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public String Titulo { get; set; }

        [DataMember]
        public String Conteudo { get; set; }

        [DataMember]
        public DateTime DataInclusao { get; set; }

        [DataMember]
        public DateTime DataLiberacao { get; set; }

        [DataMember]
        public int CodigoUsuario { get; set; }

        [DataMember]
        public char Privado { get; set; }

        [DataMember]
        public List<Categoria> Categorias { get; set; }

        public Post(int codigo = 0, String titulo = null, String conteudo = null, DateTime dataInclusao = default(DateTime), DateTime dataLiberacao = default(DateTime), int codigoUsuario = 0, char privado = (char)0, List<Categoria> categorias = null)
        {
            Codigo = codigo;
            Titulo = titulo;
            Conteudo = conteudo;
            DataInclusao = dataInclusao;
            DataLiberacao = dataLiberacao;
            CodigoUsuario = codigoUsuario;
            Privado = privado;
            Categorias = categorias;
        }
    }
}