<%@ Page Title="Acerca de" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
        <h2>mi aplicación ASP.NET.</h2>
    </hgroup>

    <article>
        <p>        
            Todos los usuarios pueden ver la lista de teléfonos.
        </p>

        <p>        
            Sólo los usuarios autenticados pueden añadir teléfonos.
        </p>

        <p>        
            Sólo los usuarios autenticados que pertenezcan al grupo de "administradores" pueden borrar teléfonos.
        </p>
    </article>

    <aside>
        <h3>Menú</h3>
        <p>        
            Menú adicional.
        </p>
        <ul>
            <li><a runat="server" href="~/">Inicio</a></li>
            <li><a runat="server" href="~/Añadir/Añadir.aspx">Añadir</a></li>
            <li><a runat="server" href="~/Borrar/Borrar.aspx">Borrar</a></li>
            <li><a runat="server" href="~/About">Acerca de</a></li>
        </ul>
    </aside>
</asp:Content>