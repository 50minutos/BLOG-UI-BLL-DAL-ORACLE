﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site.ProxyPost;

namespace Site
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected String Listar(Object obj)
        {
            return ((Categoria[])obj).Aggregate(String.Empty, (current, item) => current + (item.Descricao + " "));
        }
    }
}