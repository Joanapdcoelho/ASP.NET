using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Swatch
{
    public partial class Dados : System.Web.UI.Page
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

        protected void btn_excel_Click(object sender, EventArgs e)
        {
            Response.Clear(); //limpa tudo o que está na memória
            Response.AddHeader("Content-Disposition", "attachement; filename=ficheiro.xls");//construir o ficheiro
            //ContentType - define o tipo de ficheiro
            Response.ContentType = "application/vnd.ms-excel"; //tipo de ficheiro em excel
            // Obter um objeto Encoder para codificar o texto em UTF-8 -texto europeu 
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());//get preamble vai reconhecer os caracteres

            StringWriter sw = new StringWriter();//manda escrever no ficheiro
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            htw.Write("<table>" + "<tr><td><strong>Nome: </strong></td><td>" + Session["nome"] + "</td></tr>" + "<tr><td><strong>Morada: </strong></td><td>" + Session["morada"] + "</td></tr>" + "<tr><td><strong>Regime: </strong></td><td>" + Session["regime"] + "</td></tr>" + "<tr><td><strong>Curso: </strong></td><td>" + Session["curso"] + "</td></tr>" + "<tr><td><strong>Género: </strong></td><td>" + Session["genero"] + "</td></tr>" + "<tr><td><strong>Hobbies: </strong></td><td>" + Session["hobbies"] + "</td></tr>" + "<tr><td><strong>Email: </strong></td><td>" + Session["email"] + "</td></tr>" +
              "<tr><td><strong>Código Postal: </strong></td><td>" + Session["codigopostal"] + "</td></tr>");

            Response.Write(sw.ToString());//colocar no ecrã
            Response.End();//despejar a memória - garantir que os dados não passam para ninguém
        }

        protected void btn_word_Click(object sender, EventArgs e)
        {
            Response.Clear(); //limpa tudo o que está na memória
            Response.AddHeader("Content-Disposition", "attachement; filename=ficheiro.doc");//construir o ficheiro
            Response.ContentType = "application/vnd.ms-word"; //tipo de ficheiro em word
            // Obter um objeto Encoder para codificar o texto em UTF-8 - texto europeu
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());//get preamble vai reconhecer os caracteres

            StringWriter sw = new StringWriter();//mandar escrever no ficheiro
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            htw.Write("<table>" + "<tr><td><strong>Nome: </strong></td><td>" + Session["nome"] + "</td></tr>" + "<tr><td><strong>Morada:</strong></td><td>" + Session["morada"] + "</td></tr>" + "<tr><td><strong>Regime:</strong></td><td>" + Session["regime"] + "</td></tr>" + "<tr><td><strong>Curso:</strong></td><td>" + Session["curso"] + "</td></tr>" + "<tr><td><strong>Género:</strong></td><td>" + Session["genero"] + "</td></tr>" + "<tr><td><strong>Hobbies:</strong></td><td>" + Session["hobbies"] + "</td></tr>" + "<tr><td><strong>Email:</strong></td><td>" + Session["email"] + "</td></tr>" +
              "<tr><td><strong>Código Postal:</strong></td><td>" + Session["codigopostal"]);            

            Response.Write(sw.ToString());//colocar no ecrã
            Response.End();//despejar a memória - garantir que os dados não passam para ninguém
        }
    }
}