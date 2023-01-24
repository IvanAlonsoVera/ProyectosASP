<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validacion.aspx.cs" Inherits="Controles.Validacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        function ValidateLength(oSrc,args) {
            args.IsValid = (args.Value.Length >= 8);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Edad: <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server"
                ControlToValidate="TxtAge"
                ValueToCompare="18"
                Operator="GreaterThanEqual"
                Type="Integer"
                ErrorMessage="Debe de especificar una edad mayor a 17"></asp:CompareValidator>
            <br />
            <br />
            Primer Valor:
            <asp:TextBox ID="txtPrimerValor" runat="server"></asp:TextBox>
            Segundo Valor:
            <asp:TextBox ID="txtSegundoValor" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                ControlToValidate="txtPrimerValor"
                ControlToCompare="txtSegundoValor"
                Operator="LessThan" Type="Integer"
                ErrorMessage="El primer valor debe ser mas pequeño que el segundo valor"></asp:CompareValidator>
            <br />
            <br />
        </div>
        <div>
            Fecha: <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <asp:RangeValidator 
                ID="RangeValidator1" 
                ControlToValidate="txt1"
                MinimumValue="2002-01-04"
                MaximumValue="2015-12-31"
                type="Date"
                runat="server"
                ErrorMessage="Fuera de rango"></asp:RangeValidator>
        </div>
        <div>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="OK" />
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1"
                ForeColor="Red"
                SetFocusOnError="true"
                ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
        </div>
        <div>
            <br />
            <br />
            <asp:DropDownList ID="ddlFruits" runat="server">
                <asp:ListItem Text="-slect fruit-" Value="0"></asp:ListItem>
                <asp:ListItem Text="Mango" Value="1"></asp:ListItem>
                <asp:ListItem Text="Apple-" Value="2"></asp:ListItem>
                <asp:ListItem Text="Bannana" Value="3"></asp:ListItem>
                <asp:ListItem Text="Orange" Value="4"></asp:ListItem>
                <asp:ListItem Text="Lemon" Value="5"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator2" runat="server" 
                controltovalidate="ddlFruits"
                initialValue="0"
                foreColor="Red"
                ErrorMessage="requiered"></asp:RequiredFieldValidator>
        </div>
        <div>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator2" runat="server" 
                OnServerValidate="CustomValidator1_ServerValidate"
                ClientValidationFunction="ValidateLength"
                ControlToValidate="TextBox2"
                SetFocusOnError="true"
                ForeColor="Red"
                ErrorMessage="El texto debe tener 8 o mas caracteres"></asp:CustomValidator>
        </div>
    </form>
</body>
</html>
