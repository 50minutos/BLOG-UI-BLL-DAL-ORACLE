using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICategoria" in both code and config file together.
    [ServiceContract]
    public interface ICategoria
    {
        [OperationContract]
        void Inserir(Model.Categoria obj);

        [OperationContract]
        void Alterar(Model.Categoria obj);

        [OperationContract]
        void Excluir(Model.Categoria obj);

        [OperationContract]
        List<Model.Categoria> Selecionar();
    }
}
