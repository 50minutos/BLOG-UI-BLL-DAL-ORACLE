using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Admin
{
    public class Pagina : System.Web.UI.Page
    {
        protected void Page_PreInit(Object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("~/Admin/Login.aspx");
        }
    }
}