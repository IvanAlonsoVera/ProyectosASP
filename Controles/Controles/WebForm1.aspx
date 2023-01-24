<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FormularioWeb.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script>
        function cargarOculto() {
            alert(document.getElementById("Oculto1").getAttribute("value"));
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:FileUpload ID="FileUpload1" runat="server" /><br />
            <asp:Label ID="Label1" runat="server" Text="Archivo:"></asp:Label><br />
            <asp:Button ID="btnCargarArchivo" runat="server" Text="Cargar" onclick="btnCargarArchivo_Click"/>
        </div>
    </form>
</body>
</html>
