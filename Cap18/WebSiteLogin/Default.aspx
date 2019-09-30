<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
          <span lang="ES-TRAD" style="font-size:11.0pt;mso-bidi-font-size:10.0pt;
                font-family:Arial, Helvetica, sans-serif;">
            Haga clic en “Iniciar sesión” para autenticarse. Si no está registrado en este sitio web, puede hacerlo haciendo clic en “Nuevo usuario” del formulario login.
          </span>
        </AnonymousTemplate>
        <LoggedInTemplate>
          <span lang="ES-TRAD" style="font-size:11.0pt;mso-bidi-font-size:10.0pt;
                font-family: Arial, Helvetica, sans-serif;">
            Usted ya está autenticado</span>
        </LoggedInTemplate>
      </asp:LoginView>
      <br />
      <asp:LoginStatus ID="LoginStatus1" runat="server" />
      <br />
      <asp:HyperLink ID="HyperLink1" runat="server" Text="Usuarios suscritos" NavigateUrl="~/Admin/usuariosSuscritos.aspx">HyperLink</asp:HyperLink>
    </div>
    </form>
</body>
</html>
