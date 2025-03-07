﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="olvidóContraseña.aspx.cs" Inherits="Cuenta_olvidóContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em">
        <SubmitButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
        <MailDefinition BodyFileName="~/Cuenta/CorreoAOlvidóContraseña.txt" From="ceballos@aut.uah.es" Subject="Contraseña olvidada">
        </MailDefinition>
        <SuccessTextStyle Font-Bold="True" ForeColor="#5D7B9D" />
        <TextBoxStyle Font-Size="0.8em" />
        <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
      </asp:PasswordRecovery>
    </div>
    </form>
</body>
</html>
