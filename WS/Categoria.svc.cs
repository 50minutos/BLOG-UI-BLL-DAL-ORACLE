using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Categoria" in code, svc and config file together.
    public class Categoria : ICategoria
    {
        public void Inserir(Model.Categoria obj)
        {
            DAL.Categoria.Inserir(obj);
        }

        public void Alterar(Model.Categoria obj)
        {
            DAL.Categoria.Alterar(obj);
        }

        public void Excluir(Model.Categoria obj)
        {
            DAL.Categoria.Excluir(obj);
        }

        public List<Model.Categoria> Selecionar()
        {
            return DAL.Categoria.Selecionar().ToList();
        }
    }
}
