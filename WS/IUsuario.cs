using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsuario" in both code and config file together.
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        void Inserir(Model.Usuario obj);

        [OperationContract]
        void Alterar(Model.Usuario obj);

        [OperationContract]
        void Excluir(Model.Usuario obj);

        [OperationContract]
        Model.Usuario Logar(Model.Usuario obj);

        [OperationContract]
        List<Model.Usuario>Selecionar();
    }
}
