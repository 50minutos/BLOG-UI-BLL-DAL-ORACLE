using System;
using System.Collections.Generic;
using System.Linq;

namespace WS
{
    public class Usuario : IUsuario
    {

        public void Inserir(Model.Usuario obj)
        {
            DAL.Usuario.Inserir(obj);
        }

        public void Alterar(Model.Usuario obj)
        {
            DAL.Usuario.Alterar(obj);
        }

        public void Excluir(Model.Usuario obj)
        {
            DAL.Usuario.Excluir(obj);
        }

        public Model.Usuario Logar(Model.Usuario obj)
        {
            if (String.IsNullOrWhiteSpace(obj.Nome) || String.IsNullOrWhiteSpace(obj.Senha)) return null;
            return DAL.Usuario.Logar(obj);
        }

        public List<Model.Usuario> Selecionar()
        {
            return DAL.Usuario.Selecionar().ToList();
        }
    }
}
