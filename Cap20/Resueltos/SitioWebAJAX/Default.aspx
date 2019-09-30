<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"/>
  
  <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString=
      "<%$ ConnectionStrings:bd_alumnosConnectionString %>"
    SelectCommand="SELECT id_alumno, nombre, apto FROM alumnos
      WHERE (apto = @apto)" 
    DeleteCommand="DELETE FROM alumnos WHERE id_alumno = @id_alumno"
    UpdateCommand="UPDATE alumnos SET nombre = @nombre, apto = @apto
      WHERE (id_alumno = @id_alumno)"
    InsertCommand="INSERT INTO alumnos (id_alumno, nombre, apto)
      VALUES (@id_alumno, @nombre, @apto)">
    <SelectParameters>
      <asp:ControlParameter ControlID="DropDownList1" Name="apto" 
        PropertyName="SelectedValue" />
    </SelectParameters>
    <DeleteParameters>
      <asp:Parameter Name="id_alumno" />
    </DeleteParameters>
    <UpdateParameters>
      <asp:Parameter Name="nombre" />
      <asp:Parameter Name="apto" />
      <asp:Parameter Name="id_alumno" />
    </UpdateParameters>
    <InsertParameters>
      <asp:Parameter Name="id_alumno" />
      <asp:Parameter Name="nombre" />
      <asp:Parameter Name="apto" />
    </InsertParameters>
  </asp:SqlDataSource>

  Opción:
  <asp:DropDownList ID="DropDownList1" runat="server"
                    AutoPostBack="True">
    <asp:ListItem Selected="True" Value="true">APTOS</asp:ListItem>
    <asp:ListItem Value="false">NO APTOS</asp:ListItem>
  </asp:DropDownList>
  <br /><br />
  <div class="cabeceraconstruir">
    Construir la lista:
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
      <ProgressTemplate>
        <div class="progreso">
          <img src="imagenes/indicador.gif" />
          Actualizando... 
          <a href="" onclick="CancelarLlamadaAsincrona()">(suspender)</a>
        </div>
      </ProgressTemplate>
    </asp:UpdateProgress>
  </div>
  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <asp:GridView ID="GridView1" runat="server" 
      DataSourceID="SqlDataSource1" DataKeyNames="id_alumno"
      AllowPaging="True" AllowSorting="True" CssClass="vistarejilla" 
      GridLines="None" AutoGenerateColumns="False" >
      <Columns>
        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
          <asp:BoundField DataField="id_alumno" HeaderText="ID alumno" SortExpression="id_alumno" />
          <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
          <asp:CheckBoxField DataField="apto" HeaderText="Apto" SortExpression="apto" />
      </Columns>
    </asp:GridView>
    </ContentTemplate>
    <Triggers>
      <asp:AsyncPostBackTrigger ControlID="DropDownList1" 
        EventName="SelectedIndexChanged" />
    </Triggers>
  </asp:UpdatePanel>
  <br />
  <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
    <ContentTemplate>
	  <asp:DetailsView ID="DetailsView1" runat="server" CssClass="vistadetalles"
	    DataSourceID="SqlDataSource1" DataKeyNames="id_alumno"
	    DefaultMode="Insert" AutoGenerateRows="false" GridLines="None"
        oniteminserted="DetailsView1_ItemInserted" >
	    <Fields>
	      <asp:BoundField DataField="id_alumno" HeaderText="ID alumno" />
	      <asp:BoundField DataField="nombre" HeaderText="Nombre" />
	      <asp:CheckBoxField DataField="apto" HeaderText="Apto" />
	      <asp:CommandField ShowInsertButton="True" />
	    </Fields>
	  </asp:DetailsView>
    </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>

