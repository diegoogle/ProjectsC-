<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgregarAsignatura.aspx.cs" Inherits="AgregarAsignatura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar asignatura</title>
</head>
<body>
  <form id="form1" runat="server">
  <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
    ConnectionString="name=bd_notasAlumnosEntities" 
    DefaultContainerName="bd_notasAlumnosEntities" EnableInsert="True" 
    EntitySetName="asignaturas">
  </asp:EntityDataSource>
  <div>
    <h2>Agregar asignatura:</h2>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Identificador:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="ctIdAsig" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="ctNombre" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btAgregarAs" runat="server" Text="Agregar asignatura" OnClick="btAgregarAs_Click" />
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
