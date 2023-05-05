using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1site
{
    public partial class destino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //apanhar o que está na url (parâmetro nome)
            lbl_nome.Text = Request.QueryString["nome"] + "<br> " + Request.QueryString["morada"];
        }
    }
}