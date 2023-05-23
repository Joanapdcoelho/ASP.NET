<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="App.aspx.cs" Inherits="Swatch.App" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_boasvindas" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#006600"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btn_inscricao" runat="server" OnClick="btn_inscricao_Click" Text="Inscrição" />
            <br />
        </div>
    </form>
</body>
</html>
