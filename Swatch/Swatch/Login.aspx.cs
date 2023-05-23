using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Swatch
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_entrar_Click(object sender, EventArgs e)
        {
            if(tb_utilizador.Text.ToLower() =="admin" && tb_password.Text == "123")
            {
                Session["utilizador"] = tb_utilizador.Text;
                Response.Redirect("app.aspx");
            }
            else
            {
                lbl_mensagem.Visible = true;
            }
        }
    }
}