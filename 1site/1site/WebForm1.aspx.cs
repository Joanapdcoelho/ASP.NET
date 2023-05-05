using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1site
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_mostrar_Click(object sender, EventArgs e)
        {
            //lbl_nome.Text = "Olá Joana! Bom dia, boa tarde ou boa noite consoante for o caso!!";
            lbl_nome.Text = tb_nome.Text;
        }
    }
}