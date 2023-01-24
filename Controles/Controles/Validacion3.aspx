<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validacion3.aspx.cs" Inherits="Controles.Validacion3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h3>Secuancia correlativa de 2 en 2</h3>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="lbOutput" runat="server" Text="Label" Font-Names="Verdana" Font-Size="10pt"></asp:Label>
            <asp:CustomValidator 
                ID="CustomValidator1" runat="server" 
                ControlToValidate="TextBox1"
                Display="Static"
                ForeColor="Green"
                Font-Names="Verdana"
                Font-Size="10px"
                OnServerValidate="CustomValidator1_ServerValidate"
                Text="*"
                ErrorMessage="Numeros no correlativos"></asp:CustomValidator>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" onclick="Button1_Click" runat="server" Text="Validate" />
        </div>
    </form>
</body>
</html>
