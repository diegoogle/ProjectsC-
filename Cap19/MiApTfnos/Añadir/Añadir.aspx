<%@ Page Title="Página añadir" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Añadir.aspx.cs" Inherits="Añadir_Añadir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="Server">
  <section class="featured">
    <div class="content-wrapper">
      <hgroup class="title">
        <h1><%: Title %> teléfono.</h1>
      </hgroup>
    </div>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="Server">
  <hgroup class="title">
    <h2>Use el formulario siguiente para añadir un nuevo teléfono.</h2>
  </hgroup>

  <p class="message-info">
    Los campos nombre, dirección y teléfono son obligatorios.
  </p>

  <fieldset>
    <legend>Formulario de añadir</legend>
    <ol>
      <li>
        <asp:Label ID="Label1" runat="server" AssociatedControlID="ctNombre">Nombre:</asp:Label>
        <asp:TextBox runat="server" ID="ctNombre" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ctNombre"
          CssClass="field-validation-error" ErrorMessage="Nombre requerido." />
      </li>
      <li>
        <asp:Label ID="Label2" runat="server" AssociatedControlID="ctDireccion">Dirección:</asp:Label>
        <asp:TextBox runat="server" ID="ctDireccion" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ctDireccion"
          CssClass="field-validation-error" ErrorMessage="Dirección requerida." />
      </li>
      <li>
        <asp:Label ID="Label3" runat="server" AssociatedControlID="ctTelefono">Teléfono:</asp:Label>
        <asp:TextBox runat="server" ID="ctTelefono" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ctTelefono"
          CssClass="field-validation-error" ErrorMessage="Número de teléfono requerido." />
      </li>
      <li>
        <asp:Label ID="Label4" runat="server" AssociatedControlID="ctObservaciones">Observaciones:</asp:Label>
        <asp:TextBox runat="server" ID="ctObservaciones" TextMode="MultiLine" />
      </li>
    </ol>
    <asp:Button ID="btAñadir" runat="server" Text="Añadir" OnClick="btAñadir_Click" />
  </fieldset>
</asp:Content>

