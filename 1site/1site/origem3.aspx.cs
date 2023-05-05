using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1site
{
    public partial class origem3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            //segurança máxima 
            //criar variáveis de sessão - nome e morada
            Session["nome"] = tb_nome.Text;//conteúdo da text box que está o nome
            Session["morada"] = tb_morada.Text;//conteúdo da text box que está a morada
            Response.Redirect("destino3.aspx"); //redireciona para a página destino3.aspx
        }
    }
}