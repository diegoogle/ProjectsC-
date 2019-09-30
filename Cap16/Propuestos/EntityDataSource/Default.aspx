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
        Text="Consultar nota" Width="255px" />
      <asp:Label ID="etError" runat="server" Style="z-index: 106; left: 160px; position: absolute; top: 188px"
        Text="Error:" Width="388px"></asp:Label>
      <asp:RequiredFieldValidator ID="cvDni" runat="server" ControlToValidate="ctDni" ErrorMessage="DNI requerido"
        Style="z-index: 107; left: 500px; position: absolute; top: 71px; " ForeColor="Red">*</asp:RequiredFieldValidator>
      <asp:RangeValidator ID="cvDniRango" runat="server" ControlToValidate="ctDni" ErrorMessage="Valor fuera de rango"
        MaximumValue="99999999" MinimumValue="999999" Style="z-index: 108; left: 505px; position: absolute; top: 71px"
        Type="Integer" ForeColor="Red">*</asp:RangeValidator>
      <asp:ValidationSummary ID="cvMensajes" runat="server" Style="z-index: 109; left: 530px; position: absolute; top: 52px; width: 194px;" ForeColor="Red" />

      <asp:EntityDataSource ID="FuenteDeDatosEDS2" runat="server" 
        ConnectionString="name=bd_notasAlumnosEntities" 
        DefaultContainerName="bd_notasAlumnosEntities" EntitySetName="alums_asigs" 
        Select="it.nota, it.alumno.nombre as nombre" 
        Where="it.id_asignatura == @idAsig &amp;&amp; it.id_alumno == @idAlum">
        <WhereParameters>
          <asp:ControlParameter ControlID="lsdAsignatura" Name="idAsig" 
            PropertyName="SelectedValue" Type="Int32" />
          <asp:ControlParameter ControlID="ctDni" DefaultValue="0" Name="idAlum" 
            PropertyName="Text" Type="Int32" />
        </WhereParameters>
      </asp:EntityDataSource>
      
      <asp:EntityDataSource ID="FuenteDeDatosEDS3" runat="server" 
        ConnectionString="name=bd_notasAlumnosEntities" 
        DefaultContainerName="bd_notasAlumnosEntities" EntitySetName="alums_asigs" 
        Select="it.nota, it.alumno.nombre as nombre" 
        onselecting="FuenteDeDatosEDS3_Selecting">
      </asp:EntityDataSource>
      
      <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="FuenteDeDatosEDS2"
          Height="50px" Style="z-index: 111; left: 163px; position: absolute; top: 199px"
          Width="349px" OnPreRender="DetailsView1_PreRender" >
          <Fields>
              <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
              <asp:BoundField DataField="nota" HeaderText="Nota" SortExpression="nota" />
          </Fields>
      </asp:DetailsView>
      
      <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" DataSourceID="FuenteDeDatosEDS3"
          Height="50px" Style="z-index: 111; left: 163px; position: absolute; top: 260px"
          Width="349px" >
          <Fields>
              <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
              <asp:BoundField DataField="nota" HeaderText="Nota" SortExpression="nota" />
          </Fields>
      </asp:DetailsView>
    </div>
  </form>
</body>
</html>
