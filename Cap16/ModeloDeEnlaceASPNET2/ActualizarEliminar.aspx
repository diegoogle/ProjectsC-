<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActualizarEliminar.aspx.cs" Inherits="ActualizarEliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Actualizar o eliminar</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Default.aspx">Volver</asp:HyperLink><br />
      <br />
      <asp:ListView ID="ListView1" runat="server"
        ItemType="alum_asig"
        DataKeyNames="id_alumno,id_asignatura"
        SelectMethod="ObtenerNotas"
        UpdateMethod="ModificarNota"
        DeleteMethod="BorrarNota" 
        OnCallingDataMethods="ListView_CallingDataMethods" >
        <AlternatingItemTemplate>
          <tr style="background-color: #FFF8DC;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_alumnoLabel" runat="server" Text='<%# Eval("id_alumno") %>' />
            </td>
            <td>
              <asp:Label ID="id_asignaturaLabel" runat="server" Text='<%# Eval("id_asignatura") %>' />
            </td>
            <td>
              <asp:Label ID="notaLabel" runat="server" Text='<%# Eval("nota") %>' />
            </td>
          </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
          <tr style="background-color: #008A8C; color: #FFFFFF;">
            <td>
              <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
              <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
            </td>
            <td>
              <asp:Label ID="id_alumnoLabel1" runat="server" Text='<%# Eval("id_alumno") %>' />
            </td>
            <td>
              <asp:Label ID="id_asignaturaLabel1" runat="server" Text='<%# Eval("id_asignatura") %>' />
            </td>
            <td>
              <asp:TextBox ID="notaTextBox" runat="server" Text='<%# Bind("nota") %>' />
            </td>
          </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
          <table runat="server" style="">
            <tr>
              <td>No se han devuelto datos.</td>
            </tr>
          </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
          <tr style="">
            <td>
              <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
              <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
            </td>
            <td>
              <asp:TextBox ID="id_alumnoTextBox" runat="server" Text='<%# Bind("id_alumno") %>' />
            </td>
            <td>
              <asp:TextBox ID="id_asignaturaTextBox" runat="server" Text='<%# Bind("id_asignatura") %>' />
            </td>
            <td>
              <asp:TextBox ID="notaTextBox" runat="server" Text='<%# Bind("nota") %>' />
            </td>
          </tr>
        </InsertItemTemplate>
        <ItemTemplate>
          <tr style="background-color: #DCDCDC; color: #000000;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_alumnoLabel" runat="server" Text='<%# Eval("id_alumno") %>' />
            </td>
            <td>
              <asp:Label ID="id_asignaturaLabel" runat="server" Text='<%# Eval("id_asignatura") %>' />
            </td>
            <td>
              <asp:Label ID="notaLabel" runat="server" Text='<%# Eval("nota") %>' />
            </td>
          </tr>
        </ItemTemplate>
        <LayoutTemplate>
          <table runat="server">
            <tr runat="server">
              <td runat="server">
                <table id="itemPlaceholderContainer" runat="server" border="0" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                  <tr runat="server" style="background-color: #DCDCDC; color: #000000;">
                    <th runat="server"></th>
                    <th runat="server">ID alumno</th>
                    <th runat="server">ID asignatura</th>
                    <th runat="server">Nota</th>
                  </tr>
                  <tr id="itemPlaceholder" runat="server">
                  </tr>
                </table>
              </td>
            </tr>
            <tr runat="server">
              <td runat="server" style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                <asp:DataPager ID="DataPager1" runat="server">
                  <Fields>
                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                  </Fields>
                </asp:DataPager>
              </td>
            </tr>
          </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
          <tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_alumnoLabel" runat="server" Text='<%# Eval("id_alumno") %>' />
            </td>
            <td>
              <asp:Label ID="id_asignaturaLabel" runat="server" Text='<%# Eval("id_asignatura") %>' />
            </td>
            <td>
              <asp:Label ID="notaLabel" runat="server" Text='<%# Eval("nota") %>' />
            </td>
          </tr>
        </SelectedItemTemplate>
      </asp:ListView>
      <br />
      <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Default.aspx">Volver</asp:HyperLink><br />
      <br />
      <asp:ListView ID="ListView2" runat="server"
        ItemType="alumno"
        DataKeyNames="id_alumno"
        SelectMethod="ObtenerAlumnos"
        UpdateMethod="ModificarAlumno"
        DeleteMethod="BorrarAlumno"
        InsertItemPosition="LastItem"
        InsertMethod="InsertarAlumno"
        OnCallingDataMethods="ListView_CallingDataMethods" >
        <AlternatingItemTemplate>
          <tr style="background-color: #FFF8DC;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_alumnoLabel" runat="server" Text='<%# Eval("id_alumno") %>' />
            </td>
            <td>
              <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
            </td>
          </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
          <tr style="background-color: #008A8C; color: #FFFFFF;">
            <td>
              <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
              <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
            </td>
            <td>
              <asp:Label ID="id_alumnoLabel1" runat="server" Text='<%# Eval("id_alumno") %>' />
            </td>
            <td>
              <asp:TextBox ID="nombreTextBox" runat="server" Text='<%# Bind("nombre") %>' />
            </td>
          </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
          <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
            <tr>
              <td>No se han devuelto datos.</td>
            </tr>
          </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
          <tr style="">
            <td>
              <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
              <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
            </td>
            <td>
              <asp:TextBox ID="id_alumnoTextBox" runat="server" Text='<%# Bind("id_alumno") %>' />
            </td>
            <td>
              <asp:TextBox ID="nombreTextBox" runat="server" Text='<%# Bind("nombre") %>' />
            </td>
          </tr>
        </InsertItemTemplate>
        <ItemTemplate>
          <tr style="background-color: #DCDCDC; color: #000000;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_alumnoLabel" runat="server" Text='<%# Eval("id_alumno") %>' />
            </td>
            <td>
              <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
            </td>
          </tr>
        </ItemTemplate>
        <LayoutTemplate>
          <table runat="server">
            <tr runat="server">
              <td runat="server">
                <table id="itemPlaceholderContainer" runat="server" border="0" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                  <tr runat="server" style="background-color: #DCDCDC; color: #000000;">
                    <th runat="server"></th>
                    <th runat="server">ID alumno</th>
                    <th runat="server">Nombre</th>
                  </tr>
                  <tr id="itemPlaceholder" runat="server">
                  </tr>
                </table>
              </td>
            </tr>
            <tr runat="server">
              <td runat="server" style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                <asp:DataPager ID="DataPager1" runat="server">
                  <Fields>
                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                  </Fields>
                </asp:DataPager>
              </td>
            </tr>
          </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
          <tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_alumnoLabel" runat="server" Text='<%# Eval("id_alumno") %>' />
            </td>
            <td>
              <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
            </td>
          </tr>
        </SelectedItemTemplate>
      </asp:ListView>
      <br />
      <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Default.aspx">Volver</asp:HyperLink><br />
      <br />
      <asp:ListView ID="ListView3" runat="server"
        ItemType="asignatura"
        DataKeyNames="id_asignatura"
        SelectMethod="ObtenerAsignaturas"
        UpdateMethod="ModificarAsignatura"
        DeleteMethod="BorrarAsignatura"
        InsertItemPosition="LastItem"
        InsertMethod="InsertarAsignatura"
        OnCallingDataMethods="ListView_CallingDataMethods" >
        <AlternatingItemTemplate>
          <tr style="background-color: #FFF8DC;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_asignaturaLabel" runat="server" Text='<%# Eval("id_asignatura") %>' />
            </td>
            <td>
              <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
            </td>
          </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
          <tr style="background-color: #008A8C; color: #FFFFFF;">
            <td>
              <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
              <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
            </td>
            <td>
              <asp:Label ID="id_asignaturaLabel1" runat="server" Text='<%# Eval("id_asignatura") %>' />
            </td>
            <td>
              <asp:TextBox ID="nombreTextBox" runat="server" Text='<%# Bind("nombre") %>' />
            </td>
          </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
          <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
            <tr>
              <td>No se han devuelto datos.</td>
            </tr>
          </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
          <tr style="">
            <td>
              <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
              <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
            </td>
            <td>
              <asp:TextBox ID="id_asignaturaTextBox" runat="server" Text='<%# Bind("id_asignatura") %>' />
            </td>
            <td>
              <asp:TextBox ID="nombreTextBox" runat="server" Text='<%# Bind("nombre") %>' />
            </td>
          </tr>
        </InsertItemTemplate>
        <ItemTemplate>
          <tr style="background-color: #DCDCDC; color: #000000;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_asignaturaLabel" runat="server" Text='<%# Eval("id_asignatura") %>' />
            </td>
            <td>
              <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
            </td>
          </tr>
        </ItemTemplate>
        <LayoutTemplate>
          <table runat="server">
            <tr runat="server">
              <td runat="server">
                <table id="itemPlaceholderContainer" runat="server" border="0" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                  <tr runat="server" style="background-color: #DCDCDC; color: #000000;">
                    <th runat="server"></th>
                    <th runat="server">ID asignatura</th>
                    <th runat="server">Nombre</th>
                  </tr>
                  <tr id="itemPlaceholder" runat="server">
                  </tr>
                </table>
              </td>
            </tr>
            <tr runat="server">
              <td runat="server" style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                <asp:DataPager ID="DataPager1" runat="server">
                  <Fields>
                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                  </Fields>
                </asp:DataPager>
              </td>
            </tr>
          </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
          <tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">
            <td>
              <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
              <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
              <asp:Label ID="id_asignaturaLabel" runat="server" Text='<%# Eval("id_asignatura") %>' />
            </td>
            <td>
              <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
            </td>
          </tr>
        </SelectedItemTemplate>
      </asp:ListView>
      <br />
      <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="Default.aspx">Volver</asp:HyperLink><br />
      <br />
    </div>
  </form>
</body>
</html>
