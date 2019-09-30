<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ OutputCache Duration="30" VaryByParam="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Caché</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:Label ID="Label1" runat="server" Text="Label" /><br />
    <!--
      <asp:Substitution ID="Hora" runat="server" MethodName="hora" /><br />
    -->
      <br />
      <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
  </form>
</body>
</html>
