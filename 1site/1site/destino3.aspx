<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="destino3.aspx.cs" Inherits="_1site.destino3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="lbl_mensagem" runat="server"></asp:Label></h1>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="btn_logout" runat="server" OnClick="btn_logout_Click" Text="Logout" />
            </p>
        </div>
    </form>
</body>
</html>
