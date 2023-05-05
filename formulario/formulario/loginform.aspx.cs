using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection;

namespace formulario
{
    public partial class loginform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_excel_Click(object sender, EventArgs e)
        {
            Response.Clear(); //limpa tudo o que está na memória
            Response.AddHeader("Content-Disposition", "attachement; filename=ficheiro.xls");
            Response.ContentType = "application/vnd.ms-excel"; //tipo de ficheiro em excel
                                                                       // Obter um objeto Encoder para codificar o texto em UTF-8
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());//get preamble vai reconhecer os caracteres

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            htw.Write("<table>" + "<tr><td><strong>Nome</strong></td><td>" + tb_nome.Text + "</td></tr>" + "<tr><td><strong>Morada</strong></td><td>" + tb_morada.Text + "</td></tr>" + "<tr><td><strong>Email</strong></td><td>" + tb_email.Text + "</td></tr>");

            Response.Write(sw.ToString());
            Response.End();

        }

        protected void btn_word_Click(object sender, EventArgs e)
        {
            Response.Clear(); //limpa tudo o que está na memória
            Response.AddHeader("Content-Disposition", "attachement; filename=ficheiro.doc");
            Response.ContentType = "application/vnd.ms-word"; //tipo de ficheiro em word
                                                               // Obter um objeto Encoder para codificar o texto em UTF-8
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());//get preamble vai reconhecer os caracteres

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            htw.Write("<table>" + "<tr><td><strong>Nome</strong></td><td>" + tb_nome.Text + "</td></tr>" + "<tr><td><strong>Morada</strong></td><td>" + tb_morada.Text + "</td></tr>" + "<tr><td><strong>Email</strong></td><td>" + tb_email.Text + "</td></tr>");

            Response.Write(sw.ToString());
            Response.End();

        }

        protected void btn_xml_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=ficheiro.xml");
            Response.ContentType = "text/xml";

            //Instancia 
            StringWriter sw = new StringWriter();
            //vai traduzir para o html
            HtmlTextWriter htmlWrite = new HtmlTextWriter(sw);

            htmlWrite.Write("<dados>");//nome que se dá 
            htmlWrite.Write("<nome>" + tb_nome.Text + "</nome>");
            htmlWrite.Write("<morada>" + tb_morada.Text + "</morada>");
            htmlWrite.Write("<email>" + tb_email.Text + "</email>");
            htmlWrite.Write("<codpostal>" + tb_codpostal.Text + "</codpostal>");
            htmlWrite.Write("</dados>");

            Response.Write(sw.ToString());
            Response.End();

        }
    }
}