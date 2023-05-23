<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscricao.aspx.cs" Inherits="Swatch.Inscricao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome:&nbsp;
            <asp:TextBox ID="tb_nome" runat="server" Width="514px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator_nome" runat="server" ControlToValidate="tb_nome" ErrorMessage="Nome obrigatório" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Morada:&nbsp;
            <asp:TextBox ID="tb_morada" runat="server" TextMode="MultiLine" Width="514px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator_morada" runat="server" ControlToValidate="tb_morada" ErrorMessage="Morada obrigatória" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;<br />
            <br />
            Regime:
            <asp:DropDownList ID="ddl_regime" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_regime_SelectedIndexChanged">
                <asp:ListItem>------</asp:ListItem>
                <asp:ListItem>Noturno</asp:ListItem>
                <asp:ListItem>Diurno</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Curso: <asp:DropDownList ID="ddl_curso" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            Género: <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            Hobbies:
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" MaxSelectionCount="3" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Caminhar</asp:ListItem>
                <asp:ListItem>Cinema</asp:ListItem>
                <asp:ListItem>Música</asp:ListItem>
                <asp:ListItem>Futebol</asp:ListItem>
                <asp:ListItem>Costura</asp:ListItem>
                <asp:ListItem>Natação</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            Email:
            <asp:TextBox ID="tb_email" runat="server" TextMode="Email" Width="418px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator_email" runat="server" ControlToValidate="tb_email" ErrorMessage="Email obrigatório" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator_email" runat="server" ControlToValidate="tb_email" ErrorMessage="Email inválido" Font-Bold="True" ForeColor="#00CC00" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            <br />
            <br />
            Código-postal:
            <asp:TextBox ID="tb_codpostal" runat="server" Width="418px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator_codpostal" runat="server" ControlToValidate="tb_codpostal" ErrorMessage="Código postal obrigatório" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator_codpostal" runat="server" ControlToValidate="tb_codpostal" ErrorMessage="Código postal inválido" Font-Bold="True" ForeColor="#00CC00" ValidationExpression="^\d{4}(-\d{3})?$">*</asp:RegularExpressionValidator>
            <br />
            <br />
            Palavra-passe:
            <asp:TextBox ID="tb_password" runat="server" TextMode="Password" Width="418px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator_password" runat="server" ControlToValidate="tb_password" ErrorMessage="Palavra-passe obrigatória" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" Height="100px" Width="680px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btn_submeter" runat="server" OnClick="btn_submeter_Click" Text="Submeter" />
        </div>
    </form>
</body>
</html>
