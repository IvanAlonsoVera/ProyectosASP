<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Tienda_productos.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Clientes:
            <asp:DropDownList ID="cmbClientes" AutoPostBack="true"
                OnSelectedIndexChanged="cmbClientes_SelectedIndexChanged"
                runat="server"></asp:DropDownList>
            <br />
            Productos:
            <asp:DropDownList ID="cmbProductos" AutoPostBack="true"
                OnSelectedIndexChanged="cmbProductos_SelectedIndexChanged"
                runat="server"></asp:DropDownList>
            <br />
            Cantidad:
            <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number"></asp:TextBox><br />
            Iva:
            <asp:RadioButtonList ID="rdbIVA" runat="server"> 
                <asp:ListItem Selected="True">SI</asp:ListItem>
                <asp:ListItem>NO</asp:ListItem>
            </asp:RadioButtonList><br />
            Precio:
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            <%--Campos ocultos--%>
            <asp:HiddenField ID="hdnIdCliente" runat="server" />
            <asp:HiddenField ID="hdnNombreCliente" runat="server" />
            <asp:HiddenField ID="hdnIdProducto" runat="server" />
            <asp:HiddenField ID="hdnNombreProducto" runat="server" />

        </div>
    </form>
</body>
</html>
