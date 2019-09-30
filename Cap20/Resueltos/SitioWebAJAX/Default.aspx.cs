using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
      // Sólo para pruebas. Para ver la acción del contenedor UpdateProgress
      // cuando se inserta un nuevo registro
      System.Threading.Thread.Sleep(2000); // dos segundos
    }
}
