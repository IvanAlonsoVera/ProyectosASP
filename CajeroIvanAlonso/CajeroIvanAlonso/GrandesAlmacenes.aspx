<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GrandesAlmacenes.aspx.cs" Inherits="CajeroIvanAlonso.GrandesAlmacenes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Grandes Almacenes</h1>
            <asp:Label ID="lbl1" runat="server">Cajero: </asp:Label>
            <asp:DropDownList 
                ID="ddlCajero" 
                runat="server" 
                AutoPostBack="true"
                AppendDataBoundItems="true"
                OnSelectedIndexChanged="ddlCajero_SelectedIndexChanged" >
                <asp:ListItem Selected="True" Text="-Seleccione Cajero-" Value="0"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lbl2" runat="server">Planta: </asp:Label>
            <asp:DropDownList 
                ID="ddlPlanta" 
                runat="server"  
                AutoPostBack="true"
                AppendDataBoundItems="true">
                <asp:ListItem Selected="True" Text="-Seleccione Planta-" Value="0"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lbl3" runat="server">Producto: </asp:Label>
            <asp:DropDownList 
                ID="ddlProducto" 
                runat="server"
                AutoPostBack="true"
                AppendDataBoundItems="true">
                <asp:ListItem Selected="True" Text="-Seleccione Producto-" Value="0"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server">Cantidad: </asp:Label>
            <asp:TextBox ID="tbCantidad" runat="server"></asp:TextBox>
            <asp:Button ID="btnVenta" runat="server" OnClick="btnVenta_Click" Text="Venta" />
            <br />
            <asp:GridView ID="gv1" runat="server"></asp:GridView>
            <br />
            <asp:Label ID="Label5" runat="server">Total Facturado: </asp:Label>
            <asp:TextBox ID="tbTotal" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnImprimir" OnClick="btnImprimir_Click" runat="server" Text="Imprimir Listado Facturacion" />

        </div>
    </form>
</body>
</html>
