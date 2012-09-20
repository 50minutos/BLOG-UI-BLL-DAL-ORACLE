using System;
using System.Runtime.Serialization;

namespace WS.Model
{
    [DataContract]
    public class Categoria
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public String Descricao { get; set; }

        [DataMember]
        public DateTime?  DataExclusao { get; set; }

        public Categoria(int codigo=0, String descricao=null, DateTime? dataExclusao = null)
        {
            Codigo = codigo;
            Descricao = descricao;
            DataExclusao = dataExclusao;
        }
    }
}