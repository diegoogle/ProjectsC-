<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>AJAX y servicios Web</title>
  <script src="funciones.js"></script>
</head>
<body>
  <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" >
      <Services>
        <asp:ServiceReference Path="Service.svc" />
      </Services>
    </asp:ScriptManager>
    <div>
      <p><script>hora()</script></p>
      <input id="btMensaje" type="button" value="Haga clic aquí" onclick="InvocarServicioWeb()" />
      <br /><br />
      <label id="etMensaje" />
    </div>
  </form>
</body>
</html>
