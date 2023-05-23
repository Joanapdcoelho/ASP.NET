using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Swatch
{
    public partial class Inscricao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verifica se a variável de sessão utilizador existe ou não
            //Se não existir, não deixa entrar na aplicação, volta para o login
            if (Session["utilizador"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btn_submeter_Click(object sender, EventArgs e)
        {
            Session["nome"] = tb_nome.Text;
            Session["morada"] = tb_morada.Text;
            Session["regime"] = ddl_regime.Text;
            Session["curso"] = ddl_curso.Text;
            Session["genero"] = RadioButtonList1.Text;
            Session["hobbies"] = CheckBoxList1.Text;
            Session["email"] = tb_email.Text;
            Session["codigopostal"] = tb_codpostal.Text;
            Session["palavrapasse"] = tb_password.Text;

            Response.Redirect("Dados.aspx");
        }

        protected void ddl_regime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_curso.Items.Clear();

            if (ddl_regime.SelectedItem.ToString() == "Diurno")
            {
                ddl_curso.Items.Add("Relojoaria básica");
                ddl_curso.Items.Add("Design de relógios");
                ddl_curso.Items.Add("História de relojoaria");
                ddl_curso.Items.Add("Relógios clássicos");
            }
            else if (ddl_regime.SelectedItem.ToString() == "Noturno")
            {
                ddl_curso.Items.Add("Design de relógios");
                ddl_curso.Items.Add("Relojoaria iniciação");
                ddl_curso.Items.Add("Relojoaria avançada");
                ddl_curso.Items.Add("Relógios Suiços");
            }
        }

        //hobbies checkboxlist1
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numSelecionados = 0;
            
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    numSelecionados++;
                }
            }

            if (numSelecionados == 3)
            {
                foreach (ListItem item in CheckBoxList1.Items)
                {
                    if (!item.Selected)
                    {
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (ListItem item in CheckBoxList1.Items)
                {
                    item.Enabled = true;
                }
            }

            // Reverter a seleção de novos itens quando atingir o limite
            if (numSelecionados > 3)
            {
                CheckBoxList1.Items.FindByValue(Request.Form[CheckBoxList1.UniqueID]).Selected = false;
            }
                        
        }
    }
}