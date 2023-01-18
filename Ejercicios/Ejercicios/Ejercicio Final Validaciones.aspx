<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio Final Validaciones.aspx.cs" Inherits="Ejercicios.Ejercicio_Final_Validaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function ValidadLongitud(fuente, args) {
            args.IsValid = (args.Value.length >= 4);
        }
    </script>
    <style type="text/css">
    .centrar
    {
        position: absolute;
        /*nos posicionamos en el centro del navegador*/
        top:50%;
        left:50%;
        /*determinamos una anchura*/
        width:200px;
        /*indicamos que el margen izquierdo, es la mitad de la anchura*/
        margin-left:-200px;
        /*determinamos una altura*/
        height:200px;
        /*indicamos que el margen superior, es la mitad de la altura*/
        margin-top:-150px;
        border:1px solid #808080;
        padding:5px;
    }
</style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="0" class="centrar">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Usuario: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                            runat="server" 
                            ControlToValidate="txtUsuario"
                            Display="Static"
                            Text="*"
                            ErrorMessage="Usuario Requerido"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Edad: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEdad" runat="server" Height="202px" Width="426px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                            runat="server" 
                            ControlToValidate="txtEdad"
                            Display="Static"
                            Text="*"
                            ErrorMessage="Edad Requerido"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rangeValidator1"
                            runat="server"
                            ErrorMessage="error rango 18-50"
                            Display="Static"
                            MaximumValue="50"
                            MinimumValue="18"
                            ControlToValidate="txtEdad"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="contraseña: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpass" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                            runat="server" 
                            ControlToValidate="txtpass"
                            Display="Static"
                            Text="*"
                            ErrorMessage="contraseña Requerido"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator1" 
                            runat="server" 
                            ControlToValidate="txtpass"
                            ClientValidationFunction="ValidarLongitud"
                            Display="Dynamic"
                            ErrorMessage="Introduce al menos 4 caracteres"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Confirm contraseña: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpass2" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                            runat="server" 
                            ControlToValidate="txtpass2"
                            Display="Static"
                            Text="*"
                            ErrorMessage="Password Requerido"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" 
                            runat="server" 
                            ControlToValidate="txtpass2"
                            ControlToCompare="txtpass"
                            Display="Dynamic"
                            ErrorMessage="Las contraseñas no coinciden"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button1" 
                            runat="server" 
                            Text="ACEPTAR" 
                            OnClick="Button1_Click" Width="597px"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:ValidationSummary ID="ValidationSummary1" 
                            ShowSumary="true"
                            ShowMessageBox="false"
                            HeaderText="Han ocurrido los siguientes errores:"
                            DisplayMode="List"
                            runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
