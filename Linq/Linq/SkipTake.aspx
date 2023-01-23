<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SkipTake.aspx.cs" Inherits="Linq.SkipTake" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            Start:<asp:DropDownList ID="ddStart" runat="server"></asp:DropDownList>
            End:<asp:DropDownList ID="ddlEnd" runat="server"></asp:DropDownList>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
