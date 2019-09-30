<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Insertar.aspx.cs" Inherits="Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Matricular</title>
</head>
<body>
  <form id="form1" runat="server">
  <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
    ConnectionString="name=bd_notasAlumnosEntities" 
    DefaultContainerName="bd_notasAlumnosEntities" EntitySetName="alumnos">
  </asp:EntityDataSource>
  <asp:EntityDataSource ID="EntityDataSource2" runat="server" 
    ConnectionString="name=bd_notasAlumnosEntities" 
    DefaultContainerName="bd_notasAlumnosEntities" EntitySetName="asignaturas">
  </asp:EntityDataSource>
  <asp:EntityDataSource ID="EntityDataSource3" runat="server" 
    ConnectionString="name=bd_notasAlumnosEntities" 
    DefaultContainerName="bd_notasAlumnosEntities" EntitySetName="alums_asigs" 
    EnableInsert="True" oninserting="EntityDataSource3_Inserting">
  </asp:EntityDataSource>
  <div>
    <h2>Matricular:</h2>
    <asp:DropDownList ID="DropDownList1" runat="server" 
      DataSourceID="EntityDataSource1" DataTextField="nombre" 
      DataValueField="id_alumno" Width="250px">
    </asp:DropDownList>
    <br />
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server" 
      DataSourceID="EntityDataSource2" DataTextField="nombre" 
      DataValueField="id_asignatura" Width="250px">
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
