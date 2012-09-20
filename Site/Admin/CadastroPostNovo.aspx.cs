using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site.ProxyPost;
using Site.ProxyUsuario;

namespace Site.Admin
{
    public partial class CadastroPostNovo : Pagina
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var p = new PostClient();

            var c = (from ListItem item in CheckBoxList1.Items where item.Selected select new Categoria {Codigo= Int32.Parse(item.Value), Descricao = item.Text}).ToArray();

            var obj = new Post
                          {
                              Titulo = TextBox1.Text,
                              Conteudo = Editor1.Content,
                              CodigoUsuario = Convert.ToInt32(((Usuario)Session["USUARIO"]).Codigo),
                              DataLiberacao = Convert.ToDateTime(TextBox2.Text),
                              Categorias = c,
                              Privado = CheckBox1.Checked ? 'S' : 'N'
                          };

            p.Inserir(obj);

            Response.Redirect("~/Default.aspx");
        }
    }
}