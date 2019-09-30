using System.Linq;
using BDNotasAlumnos;
using Equin.ApplicationFramework;

namespace ApEntidades
{
  public class ProveedorDeDatos
  {
    private bd_notasAlumnosEntities contextoDeObjs;

    public ProveedorDeDatos()
    {
      contextoDeObjs = new bd_notasAlumnosEntities();
    }

    public BindingListView<alumno> ObtenerAlumnos()
    {
      BindingListView<alumno> vista;
      vista = new BindingListView<alumno>(contextoDeObjs.alumnos.ToList());
      return vista;
    }

    public BindingListView<asignatura> ObtenerAsignaturas(int idAlumno)
    {
      var asigs =
        from al_as in contextoDeObjs.alums_asigs
        where al_as.id_alumno == idAlumno
        select al_as.asignatura;
      BindingListView<asignatura> vista;
      vista = new BindingListView<asignatura>(asigs.ToList());
      return vista;
    }

    public BindingListView<alum_asig> ObtenerAlumAsig(int idAlumno, int idAsignatura)
    {
      var alumAsig =
        from al_as in contextoDeObjs.alums_asigs
        where al_as.id_alumno == idAlumno && al_as.id_asignatura == idAsignatura
        select al_as;
      BindingListView<alum_asig> vista;
      vista = new BindingListView<alum_asig>(alumAsig.ToList());
      return vista;
    }

    public float ObtenerNota(int idAlumno, int idAsignatura)
    {
      var alumAsigs =
        from al_as in contextoDeObjs.alums_asigs
        where al_as.id_alumno == idAlumno && al_as.id_asignatura == idAsignatura
        select al_as.nota;
      return alumAsigs.First();
    }

    //public void SalvarCambios()
    //{
    //  contextoDeObjs.SaveChanges();
    //}
  }
}
