<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grids.aspx.cs" Inherits="LinqSelectToMany.Grids" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCliente" Text="Cliente:" runat="server"></asp:Label> 
            <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox>
            <asp:Button ID="btnAceptar" runat="server" Text="Buscar Clientes" OnClick="btnAceptar_Click"/>
            <br />
            <asp:GridView ID="GridView1" 
                AutoGenerateColumns="false"
                EmptyDataText="No data available"
                AllowPaging="true"
                AllowSorting="true"
                PageSize="8"
                DataKeyNames="CustomerID"
                runat="server"
                OnPageIndexChanging="GridView1_PageIndexChanging" 
                OnSorting="GridView1_Sorting" 
                OnRowCommand="GridView1_RowCommand" 
                OnRowEditing="GridView1_RowEditing" 
                OnRowUpdating="GridView1_RowUpdating"
                
                >
                <PagerSettings 
                    FirstPageText="Primero"
                    LastPageText="Ultimo"
                    Mode="NumericFirstLast" 
                    PageButtonCount="5" 
                    Position="Bottom"/>
                <PagerStyle BackColor="LightBlue" Height="30px" VerticalAlign="Bottom" HorizontalAlign="Center"/>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LB1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                            <asp:LinkButton ID="LB2" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton ID="LB3" runat="server" CommandName="Update">Update</asp:LinkButton>
                            <asp:LinkButton ID="LB4" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton ID="LBK1" runat="server" CommandName="Insert">Insert</asp:LinkButton>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CompanyName">
                        <ItemTemplate>
                            <asp:Label ID="label1" runat="server" Text='<%#  Eval("CompanyName")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_CompanyName" runat="server" Text='<%#  Eval("CompanyName")%>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txt_companyName_insert" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="CustomerID" HeaderText="ID_Columnas" SortExpression="CustomerID"/>
                    <asp:BoundField DataField="CompanyName" HeaderText="Company" SortExpression="CompanyName"/>
                    <asp:BoundField DataField="ContactName" HeaderText="Contact"/>
                    <asp:BoundField DataField="City" HeaderText="City"/>
                    <asp:ButtonField ButtonType="Button" Text="Edit" CommandName="Edit" />
                </Columns>
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
