using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public IQueryable<alumno> ObtenerAlumnos([QueryString] string clave)
    {
      bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
      IQueryable<alumno> consulta = bd.alumnos;
      if (!String.IsNullOrWhiteSpace(clave))
      {
        consulta = consulta.Where(e => e.nombre.Contains(clave));
      }
      return consulta;
    }

    public IQueryable<asignatura> ObtenerAsignaturasAlum([Control("gvAlumnos", "SelectedValue")] int? idAlumno)
    {
      if (!idAlumno.HasValue) return null;
      bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
      var consulta =
        from al_as in bd.alums_asigs
        where al_as.id_alumno == idAlumno
        select al_as;
      if (rbAprobadas.Checked) consulta = consulta.Where(a => a.nota >= 5);
      if (rbSuspensas.Checked) consulta = consulta.Where(a => a.nota < 5);
      return consulta.Select(a => a.asignatura);
    }

    public alum_asig ObtenerNota(
      [Control("gvAsignaturas", "SelectedValue")] int? idAsignatura,
      [Control("gvAlumnos", "SelectedValue")] int? idAlumno)
    {
      if (!idAsignatura.HasValue || !idAlumno.HasValue) return null;
      bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
      var consulta =
        from al_as in bd.alums_asigs
        where al_as.id_alumno == idAlumno &&
              al_as.id_asignatura == idAsignatura
        select al_as;
      if (consulta.Count() == 0) return null;
      return consulta.First();
    }

    protected void rb_CheckedChanged(object sender, EventArgs e)
    {
      gvAsignaturas.DataBind();
    }
}