<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pag2.aspx.cs" Inherits="_1site.pag2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hobbies:<asp:CheckBoxList ID="cbl_hobbies" runat="server">
                <asp:ListItem>Caminhar</asp:ListItem>
                <asp:ListItem>Ler</asp:ListItem>
                <asp:ListItem>Futebol</asp:ListItem>
                <asp:ListItem>Viajar</asp:ListItem>
                <asp:ListItem>Jogos Online</asp:ListItem>
                <asp:ListItem>Passear</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            Cursos:<br />
            <asp:RadioButtonList ID="rbl_cursos" runat="server">
                <asp:ListItem>CET TPSI</asp:ListItem>
                <asp:ListItem>CET GRSI</asp:ListItem>
                <asp:ListItem>CET Multimédia</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Distrito:
            <asp:DropDownList ID="ddl_distrito" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_distrito_SelectedIndexChanged">
                <asp:ListItem>-----</asp:ListItem>
                <asp:ListItem>Lisboa</asp:ListItem>
                <asp:ListItem>Porto</asp:ListItem>
                <asp:ListItem>Setúbal</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Concelho:
            <asp:DropDownList ID="ddl_concelho" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
        </div>
    </form>
</body>
</html>
