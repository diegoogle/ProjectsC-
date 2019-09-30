<%@ Page Title="Página borrar" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Borrar.aspx.cs" Inherits="Borrar_Borrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
  <section class="featured">
    <div class="content-wrapper">
      <hgroup class="title">
        <h1><%: Title %> teléfono.</h1>
      </hgroup>
    </div>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
  <hgroup class="title">
    <h2>Use el formulario siguiente para borrar un teléfono.</h2>
  </hgroup>

  <p class="message-info">
    El campo teléfono es obligatorio.
  </p>

  <fieldset>
    <legend>Formulario de borrar</legend>
    <ol>
      <li>
        <asp:Label ID="Label3" runat="server" AssociatedControlID="ctTelefono">Teléfono:</asp:Label>
        <asp:TextBox runat="server" ID="ctTelefono" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ctTelefono"
          CssClass="field-validation-error" ErrorMessage="Número de teléfono requerido." />
      </li>
    </ol>
    <asp:Button ID="btBorrar" runat="server" Text="Borrar" OnClick="btBorrar_Click" />
  </fieldset>
</asp:Content>

