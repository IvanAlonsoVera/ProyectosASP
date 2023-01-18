<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ejercicio_asp_javier.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Add Product</legend>

                    <asp:Label ID="Label1" runat="server" Text="name: "></asp:Label>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="category"></asp:Label>
                    <asp:DropDownList ID="ddlCategry" runat="server" 
                        AutoPostBack="true"
                        OnSelectedIndexChanged="ddlCategory_SelectedIndexchanged"                        
                        >
                        <asp:ListItem Selected="True" Value="0"></asp:ListItem>
                        <asp:ListItem Value="1" Text="category 1"></asp:ListItem>
                        <asp:ListItem Value="2" Text="category 1"></asp:ListItem>
                        <asp:ListItem Value="3" Text="category 1"></asp:ListItem>
                        <asp:ListItem Value="4" Text="category 1"></asp:ListItem>
                        <asp:ListItem Value="5" Text="category 1"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:HiddenField ID="hdncategory" runat="server" />

                    <asp:Label ID="Label3" runat="server" Text="Supplier"></asp:Label>
                     <asp:DropDownList ID="ddlSupplires" runat="server" 
                         AutoPostBack="true"
                         OnSelectedIndexChanged="ddlSupplier_SelectedIndexchanged">
                        <asp:ListItem Selected="True" Value="0" ></asp:ListItem>
                        <asp:ListItem Value="1" Text="Supplier 1"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Supplier 2"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Supplier 3"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Supplier 4"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Supplier 5"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:HiddenField ID="hdnSuplier" runat="server" />

                    <asp:Label ID="Lavel4" runat="server" Text="unit price"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPrice" ></asp:TextBox>
                    <asp:Button ID="btnSalvar" runat="server" Text="save" OnClick="btnSalvar_click" />

            </fieldset> 
        </div>
    </form>
</body>
</html>
