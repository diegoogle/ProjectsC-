<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Filtrar Datos</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Label ID="Label1" runat="server" Text="Lista de alumnos:" Font-Size="Large" Font-Names="Arial"></asp:Label>
      <br />
      <asp:GridView ID="gvAlumnos" runat="server" Font-Names="Arial" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal"
         AutoGenerateColumns="False"
         AutoGenerateSelectButton="True"
         DataKeyNames="id_alumno"
         SelectMethod="ObtenerAlumnos"
         AllowSorting="True"
         AllowPaging="True" PageSize="5" >
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
          <asp:BoundField DataField="id_alumno" HeaderText="ID" ReadOnly="True" SortExpression="id_alumno">
          <ItemStyle Width="100px" />
          </asp:BoundField>
          <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre">
          <ItemStyle Width="400px" />
          </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
      </asp:GridView>
      <br /><br />
      <asp:RadioButton GroupName="g1" ID="rbTodas" runat="server" Font-Names="Arial" Text="Todas" Checked="true" AutoPostBack="true" OnCheckedChanged="rb_CheckedChanged" />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:RadioButton GroupName="g1"  ID="rbAprobadas" runat="server" Font-Names="Arial" Text="Aprobadas" AutoPostBack="true" OnCheckedChanged="rb_CheckedChanged" />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:RadioButton GroupName="g1" ID="rbSuspensas" runat="server" Font-Names="Arial" Text="Suspensas" AutoPostBack="true" OnCheckedChanged="rb_CheckedChanged" />
      <br /><br />
      <asp:Label ID="Label2" runat="server" Text="Lista de asignaturas:" Font-Size="Large" Font-Names="Arial"></asp:Label>
      <br />
      <asp:GridView ID="gvAsignaturas" runat="server" Font-Names="Arial" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal"
         DataKeyNames="id_asignatura"
         SelectMethod="ObtenerAsignaturasAlum" AutoGenerateSelectButton="True">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
          <asp:BoundField DataField="id_asignatura" HeaderText="ID" ReadOnly="True" SortExpression="id_asignatura">
          <ItemStyle Width="100px" />
          </asp:BoundField>
          <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre">
          <ItemStyle Width="400px" />
          </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
      </asp:GridView>
      <br /><br />
      <asp:Label ID="Label3" runat="server" Text="Nota del alumno y asignatura seleccionados:" Font-Size="Large" Font-Names="Arial"></asp:Label>
      <br />
      <asp:FormView ID="FormView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal"
        ItemType="alum_asig"
        DataKeyNames="id_alumno, id_asignatura"
        SelectMethod="ObtenerNota" Font-Names="Arial">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemTemplate>
          <asp:TextBox ID="TextBox1" runat="server" Text="<%# BindItem.nota %>" Font-Names="Arial" Font-Size="Medium" ReadOnly="True" Font-Bold="True" />
        </ItemTemplate>
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
      </asp:FormView>
      <br />
    </div>
    </form>
</body>
</html>
