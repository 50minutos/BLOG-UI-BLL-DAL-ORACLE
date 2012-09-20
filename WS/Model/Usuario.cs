using System;
using System.Runtime.Serialization;

namespace WS.Model
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public String Nome { get; set; }

        [DataMember]
        public String Senha { get; set; }

        [DataMember]
        public char Ativo { get; set; }

        public Usuario(int codigo = 0, string nome = null, string senha = null, char ativo = (char)0)
        {
            Codigo = codigo;
            Nome = nome;
            Senha = senha;
            Ativo = ativo;
        }
    }
}