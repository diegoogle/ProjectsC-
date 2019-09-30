using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      etError.Text = "";
    }

    public IQueryable<asignatura> ObtenerAsignaturas()
    {
      bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
      var consulta = bd.asignaturas;
      return consulta;
    }

    protected void DetailsView1_PreRender(object sender, EventArgs e)
    {
      if (this.IsPostBack && DetailsView1.DataItemCount == 0)
        etError.Text = "Error: no está en acta";
      else
        etError.Text = "";
    }

    public object ObtenerNota([Control("ctDni", "Text")] int? idAlum, [Control("lsdAsignatura", "SelectedValue")] int? idAsig)
    {
      if (!IsPostBack) return null;
      if (!idAlum.HasValue || !idAsig.HasValue) return null;
      bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
      // Consulta para obtener el nombre de idAlum y su nota en idAsig
      var consulta = from alum in bd.alumnos
                     from al_as in alum.alums_asigs
                     where al_as.id_alumno == idAlum &&
                           al_as.id_asignatura == idAsig
                     select new { alum.nombre, al_as.nota };
      return consulta.ToList();
    }
}