using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PaginaBase
/// </summary>
public class PaginaBase : System.Web.UI.Page
{
	public PaginaBase()
	{
	}

  protected void Page_PreInit(object sender, EventArgs e)
  {
    System.Web.Profile.ProfileBase perfil =
      new System.Web.Profile.ProfileBase();
    perfil = HttpContext.Current.Profile;
    Theme =
      perfil.GetPropertyValue("temaPredeterminado").ToString();
  }
}
