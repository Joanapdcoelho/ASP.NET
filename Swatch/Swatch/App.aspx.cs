using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Swatch
{
    public partial class App : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verifica se a variável de sessão utilizador existe ou não
            //Se não existir, não deixa entrar na aplicação, volta para o login
            if (Session["utilizador"] == null)
            {
                Response.Redirect("login.aspx");
            }

            lbl_boasvindas.Text = Session["utilizador"] + " Bem-vindo à página da Swatch!";

        }

        protected void btn_inscricao_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inscricao.aspx");
        }
    }
}