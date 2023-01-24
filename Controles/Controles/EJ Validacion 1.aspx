<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EJ Validacion 1.aspx.cs" Inherits="Controles.EJ_Validacion_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Apellidos: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" />Especialista NET
            <asp:CheckBox ID="CheckBox2" runat="server" />Especialista PHP
            <asp:CheckBox ID="CheckBox3" runat="server" />Especialista JAVA
            <asp:Button ID="Button1" runat="server" Text="Aceptar" />
            <br />
            <span id="spn" runat="server"></span>
        </div>
    </form>
</body>
</html>
