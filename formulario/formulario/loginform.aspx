<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginform.aspx.cs" Inherits="formulario.loginform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formulário de login</title>    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome:
            <asp:TextBox ID="tb_nome" runat="server" Width="571px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_nome" runat="server" ControlToValidate="tb_nome" ErrorMessage="Nome obrigatório" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Morada: <asp:TextBox ID="tb_morada" runat="server" TextMode="MultiLine" Width="548px"></asp:TextBox>
            <br />
            <br />
            Email:
            <asp:TextBox ID="tb_email" runat="server" TextMode="Email" Width="556px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_email" runat="server" ControlToValidate="tb_email" ErrorMessage="Email obrigatório" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator_email" runat="server" ControlToValidate="tb_email" ErrorMessage="Email inválido" Font-Bold="True" ForeColor="#00CC00" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            <br />
            <br />
            Código Postal:
            <asp:TextBox ID="tb_codpostal" runat="server" Width="321px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_codpostal" runat="server" ControlToValidate="tb_codpostal" ErrorMessage="Código postal obrigatório" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator_codpostal" runat="server" ControlToValidate="tb_codpostal" ErrorMessage="Código postal inválido" Font-Bold="True" ForeColor="#00CC00" ValidationExpression="^\d{4}(-\d{3})?$">*</asp:RegularExpressionValidator>
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" Height="100px" Width="680px" />
            <br />
            <asp:Button ID="btn_enviar" runat="server" Text="Enviar" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_excel" runat="server" OnClick="btn_excel_Click" Text="Excel" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_word" runat="server" OnClick="btn_word_Click" Text="Word" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_xml" runat="server" OnClick="btn_xml_Click" Text="XML" />
        </div>
    </form>
</body>
</html>
