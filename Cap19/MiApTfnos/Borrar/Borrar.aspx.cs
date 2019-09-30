using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Borrar_Borrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btBorrar_Click(object sender, EventArgs e)
    {
      // Recuperar los datos de la página web
      string teléfono = ctTelefono.Text;
      // Borrar el registro correspondiente de la base de datos
      refServicioTfnos.ServiceClient proxy =
        new refServicioTfnos.ServiceClient();
      proxy.Borrar_telefono(teléfono);
      Response.Redirect("../Default.aspx");
    }
}