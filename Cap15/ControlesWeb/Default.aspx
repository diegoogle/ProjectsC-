<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:Label ID="Etiqueta1" runat="server" Text="Etiqueta"></asp:Label><br />
      <br />
      <asp:TextBox ID="CajaTexto1" runat="server" Width="120px">Caja de texto</asp:TextBox><br />
      <br />
      <asp:CheckBox ID="CasillaVerifacion1" runat="server" Checked="True" Text="Opción 1" /><br />
      <br />
      <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        <asp:ListItem Selected="True" Value="1">Opci&#243;n 1</asp:ListItem>
        <asp:ListItem Value="2">Opci&#243;n 2</asp:ListItem>
      </asp:CheckBoxList><br />
      <asp:RadioButton ID="BotonOpcion1" runat="server" Checked="True" GroupName="Grupo1"
        Text="Opción 1" /><br />
      <asp:RadioButton ID="BotonOpcion2" runat="server" GroupName="Grupo1" Text="Opción 2" /><br />
      <br />
      <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Selected="True" Value="1">Opci&#243;n 1</asp:ListItem>
        <asp:ListItem Value="2">Opci&#243;n 2</asp:ListItem>
      </asp:RadioButtonList>
      <br />
      <asp:ListBox ID="ListaFija1" runat="server">
        <asp:ListItem Selected="True" Value="1">Elemento 1</asp:ListItem>
        <asp:ListItem Value="2">Elemento 2</asp:ListItem>
      </asp:ListBox><br />
      <br />
      <asp:DropDownList ID="ListaDesp1" runat="server">
        <asp:ListItem Value="1">Elemento 1</asp:ListItem>
        <asp:ListItem Value="2">Elemento 2</asp:ListItem>
      </asp:DropDownList><br />
      <br />
      <asp:Button ID="Boton1" runat="server" Text="Botón" Width="96px" /><br />
      <br />
      <asp:LinkButton ID="Enviar1" runat="server">Enviar</asp:LinkButton><br />
      <br />
      <asp:HyperLink ID="Enlace1" runat="server" NavigateUrl="MiPagina.aspx">Enlace</asp:HyperLink><br />
      <br />
      <asp:ImageButton ID="btImagen1" runat="server" ImageUrl="miLogo.png" Height="48px" Width="145px" /><br />
      <br />
      <asp:Table ID="Tabla1" runat="server" GridLines="Both">
        <asp:TableRow ID="TableRow1" runat="server">
          <asp:TableCell ID="TableCell1" runat="server">[0,0]</asp:TableCell>
          <asp:TableCell ID="TableCell2" runat="server">[0,1]</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow2" runat="server">
          <asp:TableCell ID="TableCell3" runat="server">[1,0]</asp:TableCell>
          <asp:TableCell ID="TableCell4" runat="server">[1,1]</asp:TableCell>
        </asp:TableRow>
      </asp:Table>
      <br />
      <asp:Calendar ID="Calendar1" runat="server"
        BackColor="White" BorderColor="#3366CC"
        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
        Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
        <WeekendDayStyle BackColor="#CCCCFF" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
          Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
      </asp:Calendar>
      &nbsp;<br />
    </div>
  </form>
</body>
</html>
