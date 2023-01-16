<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PrimerASP.WebForm1" %>
<script runat="server">
    private void Convertir(object sender, EventArgs e)
    {
        string cadena = txtCaja.Value;
        spnRes.InnerHtml = cadena.ToUpper();
    }
</script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" id="txtCaja" runat="server" />
            <input type="button" id="btnOK" value="ok" runat="server" onserverclick="Convertir"/>
            <hr />
            <h3>Resultado</h3>
            <span runat="server" id="spnRes"></span>
        </div>
    </form>
</body>
</html>
