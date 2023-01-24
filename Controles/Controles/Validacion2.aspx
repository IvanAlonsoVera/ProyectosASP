<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validacion2.aspx.cs" Inherits="Controles.Validacion2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            NumeroPar: 
            <asp:TextBox ID="txtnumero" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" 
                controltovalidate="txtnumero"
                Display="Dynamic"
                OnServerValidate="CustomValidator1_ServerValidate"
                ErrorMessage="Debe Indicar Numero par"></asp:CustomValidator>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            <asp:TextBox ID="txtRes" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
