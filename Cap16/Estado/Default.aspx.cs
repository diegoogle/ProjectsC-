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
    if (!this.IsPostBack)
      if (this.ViewState.Count == 0)
        this.ViewState["cuenta"] = "0";
  }

  protected void btEnviar_Click(object sender, EventArgs e)
  {
    etMensaje.Text = "Bienvenido " + ctNombre.Text;
    this.ViewState["cuenta"] = Convert.ToString(Convert.ToInt32(this.ViewState["cuenta"]) + 1);
    etVisitas.Text = "Visitas a esta página en esta sesión: " +
                     this.ViewState["cuenta"];
  }

  //protected void Page_Load(object sender, EventArgs e)
  //{
  //  if (!this.IsPostBack)
  //    if (this.Application.Count == 0)
  //      this.Application["cuenta"] = "0";
  //}

  //protected void btEnviar_Click(object sender, EventArgs e)
  //{
  //  etMensaje.Text = "Bienvenido " + ctNombre.Text;
  //  this.Application["cuenta"] = Convert.ToString(Convert.ToInt32(this.Application["cuenta"]) + 1);
  //  etVisitas.Text = "Visitas a esta página: " + this.Application["cuenta"];
  //}

  //protected void Page_Load(object sender, EventArgs e)
  //{
  //  if (!this.IsPostBack)
  //    if (this.Session.Count == 0)
  //      this.Session["cuenta"] = "0";
  //}

  //protected void btEnviar_Click(object sender, EventArgs e)
  //{
  //  etMensaje.Text = "Bienvenido " + ctNombre.Text;
  //  this.Session["cuenta"] = Convert.ToString(Convert.ToInt32(this.Session["cuenta"]) + 1);
  //  etVisitas.Text = "Visitas a esta página en esta sesión: " + this.Session["cuenta"];
  //}
}