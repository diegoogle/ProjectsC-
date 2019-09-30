<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgregarAlumno.aspx.cs" Inherits="AgregarAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Agregar alumno</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <h2>Agregar alumno:</h2>
      <br />
      <br />
      <asp:FormView ID="FormView1" runat="server"
        ItemType="alumno"
        DefaultMode="Insert"
        InsertMethod="InsertarAlumno"
        OnCallingDataMethods="FormView1_CallingDataMethods" >
        <InsertItemTemplate>
          <asp:Label ID="Label1" runat="server" Text="Identificador:"></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:TextBox ID="ctDni" runat="server"
            Text="<%# BindItem.id_alumno %>">
          </asp:TextBox>
          <asp:RequiredFieldValidator ID="cvDni" runat="server" ControlToValidate="ctDni" ErrorMessage="DNI requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
          <asp:RangeValidator ID="cvDniRango" runat="server" ControlToValidate="ctDni" ErrorMessage="Valor fuera de rango"
            MaximumValue="99999999" MinimumValue="999999" Type="Integer" ForeColor="Red">*</asp:RangeValidator>
          <asp:ValidationSummary ID="cvMensajes" runat="server" Style="left: 300px; top: 95px; position: absolute; height: 30px; width: 300px" ForeColor="Red" BorderStyle="None" />
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
          <asp:Button ID="btAgregarAl" runat="server" Text="Agregar alumno" CommandName="Insert" />
        </InsertItemTemplate>
      </asp:FormView>
      <br />
      <br />
      <asp:Label ID="etMsjAl" runat="server" Text="Error:"></asp:Label>
      <br />
      <br />
      <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Default.aspx">Volver</asp:HyperLink><br />
      <br />
    </div>
  </form>
</body>
</html>
