<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Conversión Centígrados <--> Fahrenheit</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
      <asp:Label ID="etTitulo" runat="server" Text="Conversión entre grados Centígrados y Fahrenheit" style="z-index: 1; left: 184px; top: 17px; position: absolute"/>
      <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 50px; top: 75px; position: absolute; height: 250px; width: 200px" HorizontalAlign="Right">
        <asp:Label ID="etGrados" runat="server" Text="Grados: "/>
      </asp:Panel>
      <asp:Panel ID="Panel2" runat="server" style="position: absolute; z-index: 1; left: 266px; top: 75px; height: 250px; width: 350px">
        <asp:TextBox ID="ctGrados" runat="server" Width="227px"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btConvertir" runat="server" Text="Convertir" Width="232px" OnClick="btConvertir_Click" />
        <br /><br />
        <asp:Button ID="btDetalles" runat="server" Text="Detalles" Width="231px" OnClick="btDetalles_Click" />
        <br /><br />
        <asp:RadioButton GroupName="g1" ID="boConvCF" runat="server" Text="Centígrados a Fahrenheit" Checked="True"/>
        <br /><br />
        <asp:RadioButton GroupName="g1" ID="boConvFC" runat="server" Text="Fahrenheit a Centígrados"/>
        <br /><br />
        <asp:Label ID="etError" runat="server" Text="Error: "></asp:Label>
      </asp:Panel>
    </div>
    </form>
</body>
</html>
