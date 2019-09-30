using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
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

    private void lstAlumnos_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      ObjectView<alumno> al = odAlumnos.Current as ObjectView<alumno>;
      if (al == null) return;
      idAlumnoActual = al.Object.id_alumno;
      vistaAsignaturas = provDatos.ObtenerAsignaturas(idAlumnoActual);
      odAsignaturas.DataSource = vistaAsignaturas;
      lstAsignaturas_SelectedIndexChanged(lstAsignaturas, null);
    }

    private void lstAsignaturas_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      ObjectView<asignatura> asig =
        odAsignaturas.Current as ObjectView<asignatura>;
      if (asig == null) return;
      idAsignaturaActual = asig.Object.id_asignatura;
      odAlumAsig.DataSource =
        provDatos.ObtenerAlumAsig(idAlumnoActual, idAsignaturaActual);
    }

    private void CambiosModificar_Click(object sender, EventArgs e)
    {
      // Mostrar el diálogo para obtener la nota
      if (lstAlumnos.SelectedIndex < 0 || lstAsignaturas.SelectedIndex < 0) return;

      ModificarNota formModNota = new ModificarNota(
          lstAlumnos.Text, lstAsignaturas.Text,
          Convert.ToSingle(ctNota.Text));
      if (formModNota.ShowDialog() == DialogResult.OK &&
          Convert.ToSingle(ctNota.Text) != formModNota.Nota)
      {
        provDatos.ModificarNota(idAlumnoActual, idAsignaturaActual, formModNota.Nota);
        lstAsignaturas_SelectedIndexChanged(lstAsignaturas, null);
      }
    }

    private void CambiosInsertarAlumno_Click(object sender, EventArgs e)
    {
      // Obtener los datos
      int idAlum = 1234560;
      string nomAlum = "Alberto García Sánchez";

      provDatos.AñadirAlumno(idAlum, nomAlum);
      odAlumnos.DataSource = provDatos.ObtenerAlumnos();
    }

    private void CambiosInsertarAsignatura_Click(object sender, EventArgs e)
    {
      // Obtener los datos
      int idAsig = 34680;
      string nomAsig = "PROGRAMACIÓN CONCURRENTE";

      provDatos.AñadirAsignatura(idAsig, nomAsig);
    }

    private void CambiosMatricular_Click(object sender, EventArgs e)
    {
      // Obtener los datos
      int idAlum = 1234560;
      int idAsig = 34680;

      provDatos.AñadirAlumnoAsignatura(idAlum, idAsig);
    }

    private void CambiosBorrarAlumno_Click(object sender, EventArgs e)
    {
      // Obtener los datos
      int idAlum = 1234560;

      provDatos.BorrarAlumno(idAlum);
      odAlumnos.DataSource = provDatos.ObtenerAlumnos();
    }

    private void CambiosBorrarAsignatura_Click(object sender, EventArgs e)
    {
      // Obtener los datos
      int idAsig = 34680;

      provDatos.BorrarAsignatura(idAsig);
    }

    private void CambiosConcurrencia_Click(object sender, EventArgs e)
    {
      // Obtener los datos
      int idAlum = 1234567;
      int idAsig = 20590;

      provDatos.TestConcurrencia(idAlum, idAsig);
    }

    private void CambiosEstado_Click(object sender, System.EventArgs e)
    {
      // Obtener los datos
      int idAlum = 1234567;
      int idAsig = 20590;

      provDatos.TestEstadoEntidades(idAlum, idAsig);
    }
  }
}
