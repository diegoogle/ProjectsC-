using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ActualizarEliminar : System.Web.UI.Page
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

    protected void ListView_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    {
      e.DataMethodsObject = new GestionAlumsAsigs();
    }
}