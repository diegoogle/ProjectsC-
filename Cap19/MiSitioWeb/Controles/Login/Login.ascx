<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="ControlLogin" %>
<asp:LoginView ID="LoginView1" runat="server">
  <LoggedInTemplate>
    Hola,
    <asp:LoginName ID="LoginName1" runat="server" Font-Names="Arial" Font-Size="0.9em" />
    &nbsp;<br />
    <asp:LoginStatus ID="LoginStatus1" runat="server" Font-Names="Arial" Font-Size="0.9em"
      LogoutPageUrl="~/Default.aspx" />
    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Tema: "></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br /><br />
    <asp:Button ID="Button1" runat="server" OnClick="CambiarTema"
      Text="Aceptar" /><br /><br />
  </LoggedInTemplate>
  <AnonymousTemplate>
    <asp:Login ID="Login1" runat="server" Font-Names="Arial" Font-Size="0.9em" CreateUserText="Registrarse"
      CreateUserUrl="~/Controles/Login/Registro.aspx">
    </asp:Login>
  </AnonymousTemplate>
</asp:LoginView>
