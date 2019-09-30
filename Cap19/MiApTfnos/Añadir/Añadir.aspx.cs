using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Añadir_Añadir : System.Web.UI.Page
{
  protected void Page_Error(object sender, EventArgs e)
  {
    Exception objError = Server.GetLastError().GetBaseException();

    string mensajeError = "<h3>Error: </h3><hr><br>" +
      objError.Message.ToString() +
      "<br><br><a href='../Default.aspx'>Volver</a>";
    Response.Write(mensajeError.ToString());
    Server.ClearError();
  }

  protected void btAñadir_Click(object sender, EventArgs e)
  {
    // Recuperar los datos de la página web
    string nombre = ctNombre.Text;
    string dirección = ctDireccion.Text;
    string teléfono = ctTelefono.Text;
    string observaciones = ctObservaciones.Text;
    // Añadir el registro correspondiente a la base de datos
    refServicioTfnos.ServiceClient proxy = new refServicioTfnos.ServiceClient();
    proxy.Añadir_telefono(nombre, dirección, teléfono, observaciones);
    Response.Redirect("../Default.aspx");
  }
}