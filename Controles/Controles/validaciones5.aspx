<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validaciones5.aspx.cs" Inherits="Controles.validaciones5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                runat="server" 
                ControlToValidate="txtName"
                ForeColor="Red"
                text="*"
                ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            City: <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                runat="server" 
                ControlToValidate="txtcity"
                ForeColor="Red"
                text="*"
                ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            Email:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBox3"
                ValidationExpression="^([\w-.]+)@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.)|(([\w-]+.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(]?)$"
                Text="*"
                ErrorMessage="Email invalido"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Save" />
            <asp:ValidationSummary ID="ValidationSummary1" 
                runat="server" 
                HeaderText="Erros"
                DisplayMode="BulletList"

                />
        </div>
    </form>
</body>
</html>
