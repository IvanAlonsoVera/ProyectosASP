<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SegundaPaginaAsociada.aspx.cs" Inherits="PreviousPage.SegundaPaginaAsociada" %>

<asp:Content ID="ContentCabecera" ContentPlaceHolderID="header" runat="server">

</asp:Content>

<asp:Content ID="ContentContenido" ContentPlaceHolderID="contenido" runat="server">
    Dato de la primera: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:Content>
<asp:Content ID="ContentFooter" ContentPlaceHolderID="footer" runat="server">
    <asp:TextBox ID="txtFecha" runat="server" Text="<%DateTime.Now.toShortDateString() %>"></asp:TextBox>
    Pie de la Primera pagina
</asp:Content>