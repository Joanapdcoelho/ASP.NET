<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Swatch.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Utilizador:
        <asp:TextBox ID="tb_utilizador" runat="server" Width="350px"></asp:TextBox>
        <br />
        <br />
        Palavra-passe:
        <asp:TextBox ID="tb_password" runat="server" TextMode="Password" Width="307px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btn_entrar" runat="server" OnClick="btn_entrar_Click" Text="Entrar" />
        <br />
        <br />
        <asp:Label ID="lbl_mensagem" runat="server" Font-Bold="True" ForeColor="Red" Text="Utilizador ou palavra-passe errados!!" Visible="False"></asp:Label>
        <div>
        </div>
    </form>
</body>
</html>
