<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div>
      <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
      <asp:TextBox ID="ctNombre" runat="server" Width="160px"></asp:TextBox>
      <asp:Button ID="btEnviar" runat="server" Text="Enviar" OnClick="btEnviar_Click" /><br />
      <br />
      <asp:Label ID="etMensaje" runat="server" Text="Mensaje"></asp:Label>
      <br />
      <asp:Label ID="etVisitas" runat="server" Text="Visitas"></asp:Label><br />
    </div>
    </form>
</body>
</html>
