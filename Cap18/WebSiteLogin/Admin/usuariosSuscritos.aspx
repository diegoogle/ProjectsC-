<%@ Page Language="C#" AutoEventWireup="true" CodeFile="usuariosSuscritos.aspx.cs" Inherits="Admin_usuariosSuscritos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
          <asp:BoundField DataField="UserName" HeaderText="Nombre del usuario" />
          <asp:BoundField DataField="Email" HeaderText="Correo-e" />
          <asp:BoundField DataField="LastActivityDate" HeaderText="Último acceso" />
          <asp:BoundField DataField="IsOnline" HeaderText="¿Está en línea?" />
        </Columns>
      </asp:GridView>
    </div>
    </form>
</body>
</html>
