<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GrillaTurno.aspx.cs" Inherits="Presentacion.GrillaTurno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gdvGrillaTurno" runat="server"></asp:GridView>
        </div>
        <asp:TextBox ID="txtFranjaHoraria" runat="server"></asp:TextBox>
        <asp:DropDownList ID="ddlFranjaHoraria" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlFranjaHoraria_SelectedIndexChanged">
            <%-- <asp:listitem text="Mañana" value="1"></asp:listitem>
            <asp:listitem text="Tarde" value="2"></asp:listitem>
            <asp:listitem text="Noche" value="3"></asp:listitem>--%>
        </asp:DropDownList>
    </form>
</body>
</html>
