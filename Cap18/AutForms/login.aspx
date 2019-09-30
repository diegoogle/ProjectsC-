<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:Label ID="etUsuario" runat="server" Style="z-index: 100; left: 216px; position: absolute; top: 48px"
        Text="Usuario:" Width="72px"></asp:Label>
      <asp:TextBox ID="ctUsuario" runat="server" Height="16px" Style="z-index: 101; left: 304px; position: absolute; top: 48px"
        Width="152px"></asp:TextBox>
      <asp:Label ID="etContraseña" runat="server" Style="z-index: 102; left: 216px; position: absolute; top: 88px"
        Text="Contraseña:" Width="72px"></asp:Label>
      <asp:TextBox ID="ctContraseña" runat="server" Height="16px" Style="z-index: 103; left: 304px; position: absolute; top: 88px"
        TextMode="Password" Width="152px"></asp:TextBox>
      <asp:CheckBox ID="cvRecordarContraseña" runat="server" Style="z-index: 104; left: 216px; position: absolute; top: 128px"
        Text="Recordar contraseña" Width="248px" />
      <asp:Button ID="btEnviar" runat="server" Style="z-index: 105; left: 216px; position: absolute; top: 168px"
        Text="Enviar" Width="80px" OnClick="btEnviar_Click" />
      <asp:Label ID="etError" runat="server" Style="z-index: 109; left: 216px; position: absolute; top: 208px"
        Text="Error:" Width="440px"></asp:Label>
    </div>
  </form>
</body>
</html>
