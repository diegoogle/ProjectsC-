<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Formulario web notas</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 160px; position: absolute; top: 68px"
        Text="DNI:"></asp:Label>
      <asp:TextBox ID="ctDni" runat="server" Style="z-index: 101; left: 210px; position: absolute; top: 68px; width: 309px;"></asp:TextBox>
      <asp:DropDownList ID="lsdAsignatura" runat="server" Style="z-index: 102; left: 210px; position: absolute; top: 104px; width: 315px; bottom: 469px;"
        ItemType="asignatura"
        DataTextField="nombre"
        DataValueField="id_asignatura"
        SelectMethod="ObtenerAsignaturas"
        OnCallingDataMethods="Default_CallingDataMethods">
      </asp:DropDownList>
      <asp:Button ID="btConsultarNota" runat="server" Style="z-index: 103; left: 210px; position: absolute; top: 140px; width: 315px;"
        Text="Consultar nota" />
      <asp:Label ID="etError" runat="server" Style="z-index: 106; left: 160px; position: absolute; top: 248px"
        Text="Error:" Width="388px"></asp:Label>
      <asp:RequiredFieldValidator ID="cvDni" runat="server" ControlToValidate="ctDni" ErrorMessage="DNI requerido"
        Style="z-index: 107; left: 540px; position: absolute; top: 71px; right: 749px;" ForeColor="Red">*</asp:RequiredFieldValidator>
      <asp:RangeValidator ID="cvDniRango" runat="server" ControlToValidate="ctDni" ErrorMessage="Valor fuera de rango"
        MaximumValue="99999999" MinimumValue="999999" Style="z-index: 108; left: 545px; position: absolute; top: 71px; width: 9px;"
        Type="Integer" ForeColor="Red">*</asp:RangeValidator>
      <asp:ValidationSummary ID="cvMensajes" runat="server" Style="z-index: 109; left: 570px; position: absolute; top: 52px; width: 194px;" ForeColor="Red" />
      <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False"
        Height="50px" Style="z-index: 111; left: 161px; position: absolute; top: 189px; width: 364px;" OnPreRender="DetailsView1_PreRender"
        SelectMethod="ObtenerNota"
        OnCallingDataMethods="Default_CallingDataMethods">
        <Fields>
          <asp:BoundField DataField="nombre" HeaderText="Nombre" />
          <asp:BoundField DataField="nota" HeaderText="Nota" />
        </Fields>
      </asp:DetailsView>
      <asp:HyperLink ID="HyperLink1" runat="server"
        Style="z-index: 1; left: 160px; top: 295px; position: absolute"
        NavigateUrl="ActualizarEliminar.aspx">Actualizar o eliminar</asp:HyperLink>
      <asp:HyperLink ID="HyperLink2" runat="server"
        Style="z-index: 1; left: 330px; top: 295px; position: absolute"
        NavigateUrl="Insertar.aspx">Matricular</asp:HyperLink>
      <asp:HyperLink ID="HyperLink3" runat="server"
        Style="z-index: 1; left: 425px; top: 295px; position: absolute"
        NavigateUrl="AgregarAlumno.aspx">Agregar alumno</asp:HyperLink>
      <asp:HyperLink ID="HyperLink4" runat="server"
        Style="z-index: 1; left: 555px; top: 295px; position: absolute; height: 18px;"
        NavigateUrl="AgregarAsignatura.aspx">Agregar asignatura</asp:HyperLink>
    </div>
  </form>
</body>
</html>
