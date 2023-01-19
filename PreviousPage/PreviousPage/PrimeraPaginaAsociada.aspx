<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PrimeraPaginaAsociada.aspx.cs" Inherits="PreviousPage.PrimeraPaginaAsociada" %>

<asp:Content ID="ContentCabecera" ContentPlaceHolderID="header" runat="server">

</asp:Content>

<asp:Content ID="ContentContenido" ContentPlaceHolderID="contenido" runat="server">
    <asp:Label ID="label1" runat="server" Text="nombre"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
</asp:Content>
<asp:Content ID="ContentFooter" ContentPlaceHolderID="footer" runat="server">
    @Todos los derechos reservados
</asp:Content>
