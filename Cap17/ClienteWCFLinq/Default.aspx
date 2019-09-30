<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Cliente WCF</title>
</head>
<body>
  <form id="form1" runat="server">
  <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
    SelectMethod="ObtenerTfnos"
    TypeName="RefServicioTfnos.ServiceClient">
  </asp:ObjectDataSource>
  <div>
    <asp:Label ID="Label5" runat="server" Text="Listado por el primer apellido:"></asp:Label><br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1"
      DataTextField="apellido1" DataValueField="telefono" Width="220px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
      OnDataBound="DropDownList1_DataBound">
    </asp:DropDownList>
    <br /><br />
    <asp:Label ID="Label6" runat="server" Text="Foto:" />&nbsp;&nbsp;
    <asp:Image ID="imFoto" runat="server" />
    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Nombre y apellidos:"></asp:Label><br />
    <asp:TextBox ID="ctNombre" runat="server"></asp:TextBox>
    <asp:TextBox ID="ctApellido1" runat="server"></asp:TextBox>
    <asp:TextBox ID="ctApellido2" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Dirección:"></asp:Label><br />
    <asp:TextBox ID="ctDireccion" runat="server" Width="255px"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Teléfono:"></asp:Label><br />
    <asp:TextBox ID="ctTelfono" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Observaciones:"></asp:Label><br />
    <asp:TextBox ID="ctObservaciones" runat="server" Width="255px"></asp:TextBox><br />
    <asp:Label ID="Label7" runat="server" Text="Cambiar foto:"></asp:Label><br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br /><br />
    <asp:Button ID="btActualizar" runat="server" Text="Actualizar" 
      onclick="btActualizar_Click" Width="100px" />&nbsp;&nbsp;
    <asp:Button ID="btAgregar" runat="server" Text="Añadir" 
      onclick="btAgregar_Click" Width="100px" />&nbsp;&nbsp;
    <asp:Button ID="btBorrar" runat="server" Text="Borrar" 
      onclick="btBorrar_Click" Width="100px" />&nbsp;&nbsp;
    <br /><br />
    <asp:Label ID="etError" runat="server" Text="Error:"></asp:Label><br />
    </div>
  </form>
</body>
</html>
