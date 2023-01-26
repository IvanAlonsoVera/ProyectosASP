<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Selec.aspx.cs" Inherits="LinqCasa.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Por favor seleccione una categoria:</h1>
            <asp:DropDownList 
                ID="ddl1" 
                runat="server" 
                OnSelectedIndexChanged="ddl1_SelectedIndexChanged" 
                AppendDataBoundItems="true"
                AutoPostBack="true">
                <asp:ListItem Selected="True" Text="-Seleccione Categoria-" Value="0"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:GridView ID="gv1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="no available">
                <AlternatingRowStyle BackColor="White" />
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
    </form>
</body>
</html>
