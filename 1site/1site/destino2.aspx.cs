using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1site
{
    public partial class destino2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_mensagem.Text = Request.Form["tb_nome"] + "<br>" + Request.Form["tb_morada"];
        }
    }
}