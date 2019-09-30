using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  public List<profesor> lsProfs { get; set; }

  protected void Page_Load(object sender, EventArgs e)
  {
    using (var bd = new ContextoTutorias())
    {
      Database.SetInitializer<ContextoTutorias>(new IniciarBaseDeDatos());

      var profs =
        from prof in bd.profesores
        select prof;

      lsProfs = profs.ToList();
      lsProfesor.DataBind();

      //lsProfesor.DataSource = profs.ToList();
      //lsProfesor.DataTextField = "nombre";
      //lsProfesor.DataBind();
    }
  }
}