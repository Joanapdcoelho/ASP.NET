<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_1site.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Olá TPSI, boa noite!
            <br />
            <br />
          <h1><asp:Label ID="lbl_nome" runat="server"></asp:Label></h1>
            <br />
            Nome a apresentar:
            <asp:TextBox ID="tb_nome" runat="server" Width="482px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_mostrar" runat="server" OnClick="btn_mostrar_Click" Text="Mostrar" />
        </div>
    </form>
</body>
</html>
