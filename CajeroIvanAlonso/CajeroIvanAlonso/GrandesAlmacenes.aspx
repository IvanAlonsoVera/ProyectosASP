<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GrandesAlmacenes.aspx.cs" Inherits="CajeroIvanAlonso.GrandesAlmacenes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Grandes Almacenes</h1>
            <div class="row">
                <asp:Label Class="col-4" ID="lbl1" runat="server">Cajero: </asp:Label>
                <asp:DropDownList 
                    Class="col-4"
                    ID="ddlCajero" 
                    runat="server" 
                    AutoPostBack="true"
                    AppendDataBoundItems="true"
                    OnSelectedIndexChanged="ddlCajero_SelectedIndexChanged" >
                    <asp:ListItem Selected="True" Text="-Seleccione Cajero-" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="row">
                <asp:Label  Class="col-4" ID="lbl2" runat="server">Planta: </asp:Label>
                <asp:DropDownList 
                    Class="col-4"
                    ID="ddlPlanta" 
                    runat="server"  
                    AutoPostBack="true"
                    AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="-Seleccione Planta-" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="row">
                <asp:Label Class="col-4" ID="lbl3" runat="server">Producto: </asp:Label>
                <asp:DropDownList 
                    Class="col-4"
                    ID="ddlProducto" 
                    runat="server"
                    AutoPostBack="true"
                    AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="-Seleccione Producto-" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="row">
                <asp:Label ID="Label4" Class="col-4" runat="server">Cantidad: </asp:Label>
                <asp:TextBox ID="tbCantidad" Class="col-2" runat="server"></asp:TextBox>
                <asp:Button ID="btnVenta" Class="col-2" runat="server" OnClick="btnVenta_Click" Text="Venta" />
            </div>
            <div class="row">
                <asp:GridView
                    Class="col-8"
                    ID="gv1" 
                    AutoGenerateColumns="False"
                    OnRowCommand="gv1_RowCommand"
                    runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="IdVenta" HeaderText="Id"/>
                        <asp:BoundField DataField="Producto" HeaderText="Producto"/>
                        <asp:BoundField DataField="Precio" HeaderText="Precio"/>
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad"/>
                        <asp:BoundField DataField="Total" HeaderText="Total"/>
                        <asp:ButtonField runat="server" CommandName="eliminar" Text="Eliminar" ButtonType="Button"/>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
            <div>

            </div>
            <asp:Label ID="Label5" runat="server" Enabled="false">Total Facturado: </asp:Label>
            <asp:TextBox ID="tbTotal" runat="server"></asp:TextBox>
            <br />
            <asp:Button 
                ID="btnImprimir" 
                OnClick="btnImprimir_Click" 
                runat="server" 
                Text="Imprimir Listado Facturacion" />
            <asp:HiddenField ID="hdnID" runat="server" />
        </div>
    </form>
</body>
</html>
