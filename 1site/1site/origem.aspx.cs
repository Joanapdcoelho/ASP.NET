using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1site
{
    public partial class origem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            //para passar parâmetros coloca-se o ? e depois a variável que se pretende (sem segurança pois aparece tudo no browser) quando se quer mais variáveis acrescenta-se o &

            Response.Redirect("destino.aspx?nome=" + tb_nome.Text + "&morada=" + tb_morada.Text);
        }
    }
}