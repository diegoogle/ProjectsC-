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
      <asp:SqlDataSource ID="FuenteDeDatosSql" runat="server"
        ConnectionString="<%$ ConnectionStrings:bd_notasAlumnosConnectionString %>"
        SelectCommand="SELECT [id_asignatura], [nombre] FROM [asignaturas]">
      </asp:SqlDataSource>
      <asp:SqlDataSource ID="FuenteDeDatosSql2" runat="server"
        ConnectionString="<%$ ConnectionStrings:bd_notasAlumnosConnectionString %>"
        SelectCommand="SELECT alumnos.nombre, alums_asigs.nota FROM alumnos
                       INNER JOIN alums_asigs ON alumnos.id_alumno = alums_asigs.id_alumno
                       INNER JOIN asignaturas ON alums_asigs.id_asignatura = asignaturas.id_asignatura
                       WHERE (alumnos.id_alumno = @id_alumno) AND (asignaturas.id_asignatura = @id_asignatura)">
        <SelectParameters>
          <asp:ControlParameter ControlID="ctDni" Name="id_alumno" PropertyName="Text" />
            <asp:ControlParameter ControlID="lsdAsignatura" Name="id_asignatura" PropertyName="SelectedValue" />
        </SelectParameters>
      </asp:SqlDataSource>
      <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 160px; position: absolute; top: 68px"
        Text="DNI:"></asp:Label>
      <asp:TextBox ID="ctDni" runat="server" Style="z-index: 101; left: 210px; position: absolute; top: 68px; width: 253px;"></asp:TextBox>
      <asp:DropDownList ID="lsdAsignatura" runat="server" Style="z-index: 102; left: 210px;
        position: absolute; top: 104px" Width="320px"
        DataSourceID="FuenteDeDatosSql"
        DataTextField="nombre" DataValueField="id_asignatura">
      </asp:DropDownList>
      <asp:Button ID="btConsultarNota" runat="server" Style="z-index: 103; left: 210px; position: absolute; top: 140px"
        Text="Consultar nota" Width="255px" />
      <asp:Label ID="etError" runat="server" Style="z-index: 106; left: 160px; position: absolute; top: 258px"
        Text="Error:" Width="388px"></asp:Label>
      <asp:RequiredFieldValidator ID="cvDni" runat="server" ControlToValidate="ctDni" ErrorMessage="DNI requerido"
        Style="z-index: 107; left: 500px; position: absolute; top: 71px; " ForeColor="Red">*</asp:RequiredFieldValidator>
      <asp:RangeValidator ID="cvDniRango" runat="server" ControlToValidate="ctDni" ErrorMessage="Valor fuera de rango"
        MaximumValue="99999999" MinimumValue="999999" Style="z-index: 108; left: 505px; position: absolute; top: 71px"
        Type="Integer" ForeColor="Red">*</asp:RangeValidator>
      <asp:ValidationSummary ID="cvMensajes" runat="server" Style="z-index: 109; left: 530px; position: absolute; top: 52px; width: 194px;" ForeColor="Red" />
      <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="FuenteDeDatosSql2"
          Height="50px" Style="z-index: 111; left: 161px; position: absolute; top: 189px"
          Width="349px" onprerender="DetailsView1_PreRender">
          <Fields>
              <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
              <asp:BoundField DataField="nota" HeaderText="Nota" SortExpression="nota" />
          </Fields>
      </asp:DetailsView>
    </div>
  </form>
</body>
</html>
