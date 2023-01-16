<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="PrimerASP.WebForm3" %>

<script>
    function saluda() {
        
    }
</script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <asp:Label ID="Label1" runat="server" Text="Label" >Nombre: </asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" onclick="Escribir" runat="server" onclientclick="saluda()" Text="BtnServer" />
</body>
</html>
