using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Post" in code, svc and config file together.
    public class Post : IPost
    {
        public void Inserir(Model.Post obj)
        {
            DAL.Post.Inserir(obj);
        }

        public void Alterar(Model.Post obj)
        {
            DAL.Post.Alterar(obj);
        }

        public void Excluir(Model.Post obj)
        {
            DAL.Post.Excluir(obj);
        }

        public List<Model.Post> Selecionar()
        {
            return DAL.Post.Selecionar().ToList();
        }
    }
}
