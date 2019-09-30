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
using System.IO;
using System.Collections.Generic;

public partial class ControlLogin : System.Web.UI.UserControl
{
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!IsPostBack && HttpContext.Current.User.Identity.IsAuthenticated)
    {
      // Cargar la lista desplegable con los temas
      string[] nombreTema = ObtenerTemas();
      DropDownList DropDownList1 = (DropDownList)LoginView1.FindControl("DropDownList1");
      DropDownList1.DataSource = nombreTema;
      DropDownList1.DataBind();
      DropDownList1.SelectedValue = Profile.temaPredeterminado;
    }
  }

  private string[] ObtenerTemas()
  {
    string[] nombreTema;
    DirectoryInfo directorio;
    // Recuperar las rutas de todos los temas
    nombreTema = Directory.GetDirectories(Server.MapPath("App_Themes"));

    for (int i = 0; i < nombreTema.Length; i++)
    {
      directorio = new DirectoryInfo(nombreTema[i]);
      // Guardar solo el nombre del tema (coincide con la carpeta)
      nombreTema[i] = directorio.Name;
    }
    return nombreTema;
  }

  protected void CambiarTema(object sender, EventArgs e)
  {
    DropDownList DropDownList1 = (DropDownList)LoginView1.FindControl("DropDownList1");
    Profile.temaPredeterminado = DropDownList1.SelectedValue;
    Profile.Save();
    Server.Transfer(Request.FilePath);
  }
}
