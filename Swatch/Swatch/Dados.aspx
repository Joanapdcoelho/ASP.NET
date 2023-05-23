<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dados.aspx.cs" Inherits="Swatch.Dados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_dados" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btn_excel" runat="server" OnClick="btn_excel_Click" Text="Excel" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_word" runat="server" OnClick="btn_word_Click" Text="Word" />
        </div>
    </form>
</body>
</html>
