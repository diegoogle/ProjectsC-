using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  RefServicioTfnos.telefono entTfno = null;
  RefServicioTfnos.ServiceClient cliente = null;

  protected void Page_Load(object sender, EventArgs e)
  {
    etError.Text = "";
  }

  protected void Page_Error(object sender, EventArgs e)
  {
    Exception objError = Server.GetLastError().GetBaseException();

    string mensajeError = "<h3>Error: </h3><hr><br>" +
      objError.Message.ToString() +
      "<br><br><a href='Default.aspx'>Volver</a>";
    Response.Write(mensajeError.ToString());
    Server.ClearError();
  }

  protected void DropDownList1_DataBound(object sender, EventArgs e)
  {
    ActualizarCajasDeTexto();
  }

  private void ActualizarCajasDeTexto()
  {
    cliente = new RefServicioTfnos.ServiceClient();
    entTfno = cliente.ObtenerTfno(
                this.DropDownList1.SelectedValue.ToString());
    imFoto.ImageUrl = entTfno.foto;
    ctNombre.Text = entTfno.nombre;
    ctApellido1.Text = entTfno.apellido1;
    ctApellido2.Text = entTfno.apellido2;
    ctDireccion.Text = entTfno.direccion;
    ctTelfono.Text = entTfno.telefono1;
    this.ctObservaciones.Text = entTfno.observaciones;
  }

  protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
  {
    ActualizarCajasDeTexto();
  }

  protected void btActualizar_Click(object sender, EventArgs e)
  {
    cliente = new RefServicioTfnos.ServiceClient();
    entTfno = cliente.ObtenerTfno(
                this.DropDownList1.SelectedValue.ToString());
    entTfno.nombre = ctNombre.Text;
    entTfno.apellido1 = ctApellido1.Text;
    entTfno.apellido2 = ctApellido2.Text;
    entTfno.direccion = ctDireccion.Text;
    entTfno.telefono1 = ctTelfono.Text;
    if (FileUpload1.FileName.Length != 0) 
      CambiarFoto();
    cliente.ActualizarTfno(entTfno);
    Response.AppendHeader("Refresh", "0");
  }

  protected void btAgregar_Click(object sender, EventArgs e)
  {
    cliente = new RefServicioTfnos.ServiceClient();
    entTfno = new RefServicioTfnos.telefono();
    entTfno.nombre = ctNombre.Text;
    entTfno.apellido1 = ctApellido1.Text;
    entTfno.apellido2 = ctApellido2.Text;
    entTfno.direccion = ctDireccion.Text;
    entTfno.telefono1 = ctTelfono.Text;
    try
    {
      cliente.AgregarTfno(entTfno);
      Response.AppendHeader("Refresh", "0");
    }
    catch (Exception ex)
    {
      etError.Text = "Error: ¿existe el teléfono?";
    }
  }

  protected void btBorrar_Click(object sender, EventArgs e)
  {
    cliente = new RefServicioTfnos.ServiceClient();
    entTfno = cliente.ObtenerTfno(
                this.DropDownList1.SelectedValue.ToString());
    try
    {
      cliente.BorrarTfno(entTfno);
      BorrarFoto();
      Response.AppendHeader("Refresh", "0");
    }
    catch (Exception ex)
    {
      etError.Text = "Error: ¿existe el teléfono?";
    }
  }

  protected void CambiarFoto()
  {
    try
    {
      // Ruta hasta la carpeta del sitio web
      string sRutaSitioWeb = Server.MapPath("/ClienteWCFLinq");
      // Borramos la imagen actual
      if (entTfno.foto != null)
        File.Delete(sRutaSitioWeb + "/" + entTfno.foto);
      // Subir la foto al servidor
      FileUpload1.PostedFile.SaveAs(sRutaSitioWeb +
                                "/fotos/" + FileUpload1.FileName);
      // Cambiar el campo foto de la entidad actual
      entTfno.foto = "fotos/" + FileUpload1.FileName;
    }
    catch (Exception ex)
    {
      etError.Text = ex.Message;
    }
  }

  protected void BorrarFoto()
  {
    try
    {
      // Ruta hasta la carpeta del sitio web
      string sRutaSitioWeb = Server.MapPath("/ClienteWCFLinq");
      // Borramos la imagen actual
      if (entTfno.foto != null)
        File.Delete(sRutaSitioWeb + "/" + entTfno.foto);
    }
    catch (Exception ex)
    {
      etError.Text = ex.Message;
    }
  }
}