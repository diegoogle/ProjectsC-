<%@ Page Title="Página de inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
  <section class="featured">
    <div class="content-wrapper">
      <hgroup class="title">
        <h1><%: Title %>. Lista de teléfonos:</h1>
      </hgroup>
    </div>
  </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="telefono" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar.">
    <Columns>
      <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
      <asp:BoundField DataField="direccion" HeaderText="Dirección" SortExpression="direccion" />
      <asp:BoundField DataField="telefono" HeaderText="Teléfono" ReadOnly="True" SortExpression="telefono" />
      <asp:BoundField DataField="observaciones" HeaderText="Observaciones" SortExpression="observaciones" />
    </Columns>
  </asp:GridView>
  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bd_telefonosConnectionString1 %>" DeleteCommand="DELETE FROM [telefonos] WHERE [telefono] = @telefono" InsertCommand="INSERT INTO [telefonos] ([nombre], [direccion], [telefono], [observaciones]) VALUES (@nombre, @direccion, @telefono, @observaciones)" ProviderName="<%$ ConnectionStrings:bd_telefonosConnectionString1.ProviderName %>" SelectCommand="SELECT [nombre], [direccion], [telefono], [observaciones] FROM [telefonos]" UpdateCommand="UPDATE [telefonos] SET [nombre] = @nombre, [direccion] = @direccion, [observaciones] = @observaciones WHERE [telefono] = @telefono">
    <DeleteParameters>
      <asp:Parameter Name="telefono" Type="String" />
    </DeleteParameters>
    <InsertParameters>
      <asp:Parameter Name="nombre" Type="String" />
      <asp:Parameter Name="direccion" Type="String" />
      <asp:Parameter Name="telefono" Type="String" />
      <asp:Parameter Name="observaciones" Type="String" />
    </InsertParameters>
    <UpdateParameters>
      <asp:Parameter Name="nombre" Type="String" />
      <asp:Parameter Name="direccion" Type="String" />
      <asp:Parameter Name="observaciones" Type="String" />
      <asp:Parameter Name="telefono" Type="String" />
    </UpdateParameters>
  </asp:SqlDataSource>

</asp:Content>
