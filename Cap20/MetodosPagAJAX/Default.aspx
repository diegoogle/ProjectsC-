<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>AJAX y métodos página</title>
  <script src="funciones.js"></script>
</head>
<body>
  <form id="form2" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True" />
    <div>
      <p><script>hora()</script></p>
      Nombre:&nbsp;<input type="text" id="nombre" />
      <input id="btMensaje" type="button" value="Haga clic aquí" onclick="InvocarMetodoPag()" />
      <br /><br />
      <label id="etMensaje" />
    </div>
  </form>
</body>
</html>
