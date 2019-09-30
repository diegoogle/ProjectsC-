using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ControlMenuPrincipal : System.Web.UI.UserControl
{
  protected void Page_Load(object sender, EventArgs e)
  {
    string ruta = Request.ApplicationPath;
    string codigo = "";

    codigo += "<ul>";
    codigo += "<li><a href=\"" + ruta +
      "/Borrar.aspx\" title=\"Borrar...\"><span>Borrar</span></a></li>";
    codigo += "<li><a href=\"" + ruta +
      "/Añadir.aspx\" title=\"Añadir...\"><span>Añadir</span></a></li>";
    codigo += "<li><a href=\"" + ruta +
      "/Default.aspx\" title=\"Mostrar...\"><span>Mostrar</span></a></li>";
    codigo += "</ul>";
    Literal1.Text = codigo;
  }
}
