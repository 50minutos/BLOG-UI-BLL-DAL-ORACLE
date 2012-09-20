using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPost" in both code and config file together.
    [ServiceContract]
    public interface IPost
    {
        [OperationContract]
        void Inserir(Model.Post obj);

        [OperationContract]
        void Alterar(Model.Post obj);

        [OperationContract]
        void Excluir(Model.Post obj);
        
        [OperationContract]
        List<Model.Post> Selecionar();
    }
}
