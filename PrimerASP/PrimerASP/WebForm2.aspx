<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PrimerASP.WebForm2" %>

<script runat="server">
    private void Page_Load(object sender, EventArgs e){
        ElCuerpo.Style[HtmlTextWriterStyle.BackgroundColor] = "lightblue";
    }
</script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body id="ElCuerpo" runat="server">
    <h3>
        He modificado el background mediante programacion
    </h3>
    <input id="Button1" type="button" value="button" runat="server"/>
    <asp:Button ID="Button2" runat="server" Text="Button" OnClick=""/>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

</body>
</html>
