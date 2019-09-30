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
    etError.Text = "";
  }

  protected void DetailsView1_PreRender(object sender, EventArgs e)
  {
    if (this.IsPostBack && DetailsView1.DataItemCount == 0)
      etError.Text = "Error: no está en acta";
    else
      etError.Text = "";
  }


  // FuenteDeDatosEDS2 incluye una consulta que da el mismo resultado que la siguiente.

  // Consulta independiente (FuenteDeDatosEDS3)
  protected void FuenteDeDatosEDS3_Selecting(object sender, EntityDataSourceSelectingEventArgs e)
  {
    e.DataSource.Where = "it.id_asignatura == @idAsig && it.id_alumno == @idAlum";
    e.DataSource.WhereParameters.Clear();
    e.DataSource.WhereParameters.Add(new ControlParameter("idAsig", TypeCode.Int32, "lsdAsignatura", "SelectedValue"));
    e.DataSource.WhereParameters.Add(new ControlParameter("idAlum", TypeCode.Int32, "ctDni", "Text"));
  }
}