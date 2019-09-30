<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Insertar.aspx.cs" Inherits="Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Matricular</title>
</head>
<body>
  <form id="form1" runat="server">
  <div>
    <h2>Matricular:</h2>
    <asp:DropDownList ID="lsdAlumnos" runat="server" Width="320px" 
      ItemType="alumno"
      DataTextField="nombre" 
      DataValueField="id_alumno"
      SelectMethod="ObtenerAlumnos"
      OnCallingDataMethods="DropDownList_CallingDataMethods" >
    </asp:DropDownList>
    <br />
    <br />
    <asp:DropDownList ID="lsdAsignaturas" runat="server"  Width="320px"
      ItemType="asignatura"
      DataTextField="nombre"
      DataValueField="id_asignatura" 
      SelectMethod="ObtenerAsignaturas"
      OnCallingDataMethods="DropDownList_CallingDataMethods" >
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btMatricular" runat="server" Text="Matricular" 
      onclick="btMatricular_Click" />
    <br />
    <br />
    <asp:Label ID="etMsj" runat="server" Text="Error:"></asp:Label>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Default.aspx">Volver</asp:HyperLink><br /><br />
  </div>
  </form>
</body>
</html>
