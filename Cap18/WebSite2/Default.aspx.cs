using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    string UsuarioAutenticado;
    string UsuarioASP;
    // Usuario que realiza la solicitud de la página
    UsuarioAutenticado = User.Identity.Name;
    UsuarioASP = WindowsIdentity.GetCurrent().Name;
    etUsuarioAut.Text = "Usted es el usuario: " + UsuarioAutenticado;
    // Contexto de seguridad bajo el que se ejecuta la página
    etUsuarioASP.Text = "La página se ejecuta bajo el " +
                        "contexto de seguridad: " + UsuarioASP;
    HttpClientCertificate certificado = Request.ClientCertificate;
    if (certificado.IsPresent)
      // Obtener el campo "organización" (O) del certificado
      etCertificado.Text = certificado.Get("Subject O");
    else
      etCertificado.Text = " El certificado de cliente se ha omitido.";
  }
}