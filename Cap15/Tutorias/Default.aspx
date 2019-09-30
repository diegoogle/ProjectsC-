<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title></title>
</head>
<body style="text-align: center">
  <form id="formTutorias" runat="server">
    <strong><span style="font-family: Arial; font-size: 24pt">CONCERTAR UNA TUTORÍA</span></strong><br />
    <br />
    <div style="text-align: left; font-family: Arial">
      Alumno:<br />
      <asp:TextBox ID="ctAlumno" runat="server" Width="504px"></asp:TextBox><br />
      <br />
      Con el profesor:<br />
      <asp:DropDownList ID="lsProfesor" 
                        DataSource="<%# lsProfs %>" 
                        DataTextField="nombre"
                        runat="server" Width="296px" Font-Size="Medium">
      </asp:DropDownList><br />
      <br /><br />
      Día:<br />
      <asp:DropDownList ID="lsDia" runat="server" Font-Size="Medium">
        <asp:ListItem Value="1">lunes</asp:ListItem>
        <asp:ListItem Value="2">martes</asp:ListItem>
        <asp:ListItem Value="3">miércoles</asp:ListItem>
        <asp:ListItem Value="4">jueves</asp:ListItem>
        <asp:ListItem Value="5">viernes</asp:ListItem>
      </asp:DropDownList><br />
      <br />
      Hora: &nbsp;
      <asp:RadioButtonList ID="btopHora" runat="server" TextAlign="Left" RepeatDirection="Horizontal" RepeatLayout="Flow">
        <asp:ListItem Selected="True">10</asp:ListItem>
        <asp:ListItem>&#160;&#160;&#160;12</asp:ListItem>
        <asp:ListItem>&#160;&#160;&#160;16</asp:ListItem>
        <asp:ListItem>&#160;&#160;&#160;18</asp:ListItem>
      </asp:RadioButtonList><br />
      <br />
      Asunto:<br />
      <asp:TextBox ID="ctAsunto" runat="server" Height="64px" TextMode="MultiLine" Width="440px"></asp:TextBox><br />
      <br />
      <asp:Button ID="btEnviar" runat="server" Text="Enviar datos" Width="112px" />
      &nbsp;
      <asp:Button ID="btRestablecer" runat="server" Text="Restablecer" Width="112px" />
    </div>
  </form>
</body>
</html>
