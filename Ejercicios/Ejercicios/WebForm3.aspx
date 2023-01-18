<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Ejercicios.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="Radio1" runat="server">
                <asp:ListItem Selected="true" Value="0">Si</asp:ListItem>
                <asp:ListItem Value="1">No</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btnSeleccionar" runat="server" Text="Ver_Seleccionado" OnClick="btnSeleccionar_Click" />
            <asp:Label ID="LblSeleccionado" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
