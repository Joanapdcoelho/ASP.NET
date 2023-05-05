using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1site
{
    public partial class destino3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //busca o valor das variáveis que estão em memória na sessão - nome e morada 
            lbl_mensagem.Text = Session["nome"] + "<br>" + Session["morada"];
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            // limpa as variáveis de sessão
            Session.Clear();
            // Abandona a sessão
            Session.Abandon();
        }
    }
}