using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site.ProxyUsuario;

namespace Site.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var obj = new UsuarioClient();

            var retorno = obj.Logar(new Usuario { Nome = TextBox1.Text, Senha = TextBox2.Text });

            if (retorno == null) return;

            Session["USUARIO"] = retorno;
            MultiView1.ActiveViewIndex = 1;
        }
    }
}