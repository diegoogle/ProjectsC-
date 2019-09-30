using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    etError.Text = "";
  }

  protected void btEnviar_Click(object sender, EventArgs e)
  {
    // Obtener las credenciales para realizar la autenticación
    string usuario = "usuario1";
    string contraseña = "contraseña1";
    if (Page.IsValid)
      if (ctUsuario.Text.Equals(usuario) &&
          ctContraseña.Text.Equals(contraseña))
        // Retornar a la petición (URL) inicial
        FormsAuthentication.RedirectFromLoginPage(
               ctUsuario.Text, cvRecordarContraseña.Checked);
      else
        etError.Text = "Acceso denegado";
  }
}