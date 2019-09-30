<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Formulario web notas</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:EntityDataSource ID="FuenteDeDatosEDS" runat="server"
        ConnectionString="name=bd_notasAlumnosEntities"
        DefaultContainerName="bd_notasAlumnosEntities"
        EnableFlattening="False" EntitySetName="asignaturas"
        Select="it.[id_asignatura], it.[nombre]" >
      </asp:EntityDataSource>
      <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 160px; position: absolute; top: 68px"
        Text="DNI:"></asp:Label>
      <asp:TextBox ID="ctDni" runat="server" Style="z-index: 101; left: 210px; position: absolute; top: 68px; width: 253px;"></asp:TextBox>
      <asp:DropDownList ID="lsdAsignatura" runat="server" Style="z-index: 102; left: 210px; position: absolute; top: 104px" Width="320px" 
        DataSourceID="FuenteDeDatosEDS"
        DataTextField="nombre" DataValueField="id_asignatura">
      </asp:DropDownList>
      <asp:Button ID="btConsultarNota" runat="server" Style="z-index: 103; left: 210px; position: absolute; top: 140px"
        Text="Consultar nota" Width="255px" OnClick="btConsultarNota_Click" />
      <asp:Label ID="etNombre" runat="server" Style="z-index: 104; left: 160px; position: absolute; top: 186px"
        Text="Nombre:" Width="388px"></asp:Label>
      <asp:Label ID="etNota" runat="server" Style="z-index: 105; left: 160px; position: absolute; top: 222px"
        Text="Nota:" Width="388px"></asp:Label>
      <asp:Label ID="etError" runat="server" Style="z-index: 106; left: 160px; position: absolute; top: 258px"
        Text="Error:" Width="388px"></asp:Label>
      <asp:RequiredFieldValidator ID="cvDni" runat="server" ControlToValidate="ctDni" ErrorMessage="DNI requerido"
        Style="z-index: 107; left: 500px; position: absolute; top: 71px; " ForeColor="Red">*</asp:RequiredFieldValidator>
      <asp:RangeValidator ID="cvDniRango" runat="server" ControlToValidate="ctDni" ErrorMessage="Valor fuera de rango"
        MaximumValue="99999999" MinimumValue="999999" Style="z-index: 108; left: 505px; position: absolute; top: 71px"
        Type="Integer" ForeColor="Red">*</asp:RangeValidator>
      <asp:ValidationSummary ID="cvMensajes" runat="server" Style="z-index: 109; left: 530px; position: absolute; top: 52px; width: 194px;" ForeColor="Red" />
      <asp:HyperLink ID="HyperLink1" runat="server" 
        style="z-index: 1; left: 160px; top: 295px; position: absolute" 
        NavigateUrl="ActualizarEliminar.aspx">Actualizar o eliminar</asp:HyperLink>
      <asp:HyperLink ID="HyperLink2" runat="server" 
        style="z-index: 1; left: 330px; top: 295px; position: absolute" 
        NavigateUrl="Insertar.aspx">Matricular</asp:HyperLink>
      <asp:HyperLink ID="HyperLink3" runat="server" 
        style="z-index: 1; left: 425px; top: 295px; position: absolute" 
        NavigateUrl="AgregarAlumno.aspx">Agregar alumno</asp:HyperLink>
      <asp:HyperLink ID="HyperLink4" runat="server" 
        style="z-index: 1; left: 555px; top: 295px; position: absolute; height: 18px;" 
        NavigateUrl="AgregarAsignatura.aspx">Agregar asignatura</asp:HyperLink>
    </div>
  </form>
</body>
</html>
