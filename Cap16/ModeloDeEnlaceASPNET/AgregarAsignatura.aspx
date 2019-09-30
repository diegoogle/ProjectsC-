<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgregarAsignatura.aspx.cs" Inherits="AgregarAsignatura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Agregar asignatura</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <h2>Agregar asignatura:</h2>
      <br />
      <br />
      <asp:FormView ID="FormView1" runat="server"
        ItemType="asignatura"
        DefaultMode="Insert"
        InsertMethod="InsertarAsignatura">
        <InsertItemTemplate>
          <asp:Label ID="Label1" runat="server" Text="Identificador:"></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:TextBox ID="ctIdAsig" runat="server"
            Text="<%# BindItem.id_asignatura %>">
          </asp:TextBox>
          <asp:RequiredFieldValidator ID="cvIdAsig" runat="server" ControlToValidate="ctIdAsig" ErrorMessage="ID requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
          <asp:RangeValidator ID="cvIdAsigRango" runat="server" ControlToValidate="ctIdAsig" ErrorMessage="Valor fuera de rango"
            MaximumValue="99999" MinimumValue="9999" Type="Integer" ForeColor="Red">*</asp:RangeValidator>
          <asp:ValidationSummary ID="cvMensajes" runat="server" Style="left: 300px; top: 95px; position: absolute; height: 30px; width: 300px" ForeColor="Red" />
          <br />
          <br />
          <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:TextBox ID="ctNombre" runat="server"
            Text="<%# BindItem.nombre %>">
          </asp:TextBox>
          <asp:RequiredFieldValidator ID="cvNombre" runat="server" ControlToValidate="ctNombre" ErrorMessage="Nombre requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
          <br />
          <br />
          <asp:Button ID="btAgregarAl" runat="server" Text="Agregar asignatura" CommandName="Insert" />
        </InsertItemTemplate>
      </asp:FormView>
      <br />
      <br />
      <asp:Label ID="etMsj" runat="server" Text="Error:"></asp:Label>
      <br />
      <br />
      <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Default.aspx">Volver</asp:HyperLink><br />
      <br />
    </div>
  </form>
</body>
</html>
