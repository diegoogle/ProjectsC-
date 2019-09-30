using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarAsignatura : System.Web.UI.Page
{
  protected void Page_Error(object sender, EventArgs e)
  {
    Exception objError = Server.GetLastError().GetBaseException();

    string mensajeError = "<h3>Error: </h3><hr><br>" +
      objError.Message.ToString() +
      "<br><br><a href='ActualizarEliminar.aspx'>Volver</a>";
    Response.Write(mensajeError.ToString());
    Server.ClearError();
  }

  protected void Page_Load(object sender, EventArgs e)
  {
    etMsj.Text = "";
  }

  public void InsertarAsignatura()
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      var objAsignatura = new asignatura();
      TryUpdateModel(objAsignatura);
      if (ModelState.IsValid)
      {
        // Guardar los cambios
        bd.asignaturas.Add(objAsignatura);
        bd.SaveChanges();
        etMsj.Text = "Asignatura añadida.";
      }
    }
  }
}
