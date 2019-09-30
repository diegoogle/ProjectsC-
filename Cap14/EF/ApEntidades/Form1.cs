using System.Windows.Forms;
using BDNotasAlumnos;
using Equin.ApplicationFramework;

namespace ApEntidades
{
  public partial class Form1 : Form
  {
    private ProveedorDeDatos provDatos = new ProveedorDeDatos();
    BindingListView<asignatura> vistaAsignaturas;
    public int idAlumnoActual;
    public int idAsignaturaActual;

    public Form1()
    {
      InitializeComponent();
      odAlumnos.DataSource = provDatos.ObtenerAlumnos();
    }

    private void dgAlumnos_SelectionChanged(object sender, System.EventArgs e)
    {
      bopTodas.Checked = true;
      ObjectView<alumno> al = odAlumnos.Current as ObjectView<alumno>;
      if (al == null) return;
      idAlumnoActual = al.Object.id_alumno;
      vistaAsignaturas = provDatos.ObtenerAsignaturas(idAlumnoActual);
      odAsignaturas.DataSource = vistaAsignaturas;
    }

    private void dgAsignaturas_SelectionChanged(object sender, System.EventArgs e)
    {
      ObjectView<asignatura> asig =
        odAsignaturas.Current as ObjectView<asignatura>;
      if (asig == null) return;
      idAsignaturaActual = asig.Object.id_asignatura;
      odAlumAsig.DataSource =
        provDatos.ObtenerAlumAsig(idAlumnoActual, idAsignaturaActual);
    }

    private void bopTodas_CheckedChanged(object sender, System.EventArgs e)
    {
      if (!odAsignaturas.SupportsFiltering) return;
      vistaAsignaturas.RemoveFilter();
    }

    private void bopSuspensas_CheckedChanged(object sender, System.EventArgs e)
    {
      if (!odAsignaturas.SupportsFiltering) return;
      if (bopSuspensas.Checked == true)
      {
        vistaAsignaturas.ApplyFilter(delegate(asignatura asig)
        {
          return provDatos.ObtenerNota(idAlumnoActual, asig.id_asignatura) < 5.0F;
        });
      }
    }

    private void bopAprobadas_CheckedChanged(object sender, System.EventArgs e)
    {
      if (!odAsignaturas.SupportsFiltering) return;
      if (bopAprobadas.Checked == true)
      {
        vistaAsignaturas.ApplyFilter(delegate(asignatura asig)
        {
          return provDatos.ObtenerNota(idAlumnoActual, asig.id_asignatura) >= 5.0F;
        });
      }
    }
  }
}
