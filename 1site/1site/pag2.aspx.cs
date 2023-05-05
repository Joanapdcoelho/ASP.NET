using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1site
{
    public partial class pag2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddl_distrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_concelho.Items.Clear(); //limpa os concelhos antes de carregar a lista
            if(ddl_distrito.SelectedItem.ToString() == "Lisboa")
            {
                ddl_concelho.Items.Add("Amadora");
                ddl_concelho.Items.Add("Odivelas");
                ddl_concelho.Items.Add("Sintra");
                ddl_concelho.Items.Add("Algés");
            }
            else if (ddl_distrito.SelectedItem.ToString() == "Setúbal")
            {
                ddl_concelho.Items.Add("Palmela");
                ddl_concelho.Items.Add("Grândola");
                ddl_concelho.Items.Add("Sines");
                ddl_concelho.Items.Add("Almada");
            }
            else if (ddl_distrito.SelectedItem.ToString() == "Porto")
            {
                ddl_concelho.Items.Add("Gondomar");
                ddl_concelho.Items.Add("Matosinhos");
                ddl_concelho.Items.Add("Vila Nova de Gaia");
            }
        }
    }
}