using System.Windows.Forms;
using BaseDeDatos;
using Equin.ApplicationFramework;

namespace OperacionesConDatos
{
  public partial class Form1 : Form
  {
    BindingListView<Alumno> vista;

    public Form1()
    {
      InitializeComponent();
      vista = new BindingListView<Alumno>(bbdd.Alumnos);
      listAlumnosBindingSource.DataSource = vista;
      MostrarPosicion();
    }

    private void MostrarPosicion()
    {
      // Total elementos
      int iTotal = listAlumnosBindingSource.Count;
      // Número (1, 2, ...) de elemento
      int iPos;

      if (iTotal == 0)
        etPosicion.Text = "0 de 0";
      else
      {
        iPos = listAlumnosBindingSource.Position + 1;
        // Mostrar información en la etiqueta
        etPosicion.Text = iPos.ToString() + " de " + iTotal.ToString();
      }
    }

    private void listAlumnosDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      MostrarPosicion();
    }

    private void btPrimero_Click(object sender, System.EventArgs e)
    {
      listAlumnosBindingSource.MoveFirst();
    }

    private void btUltimo_Click(object sender, System.EventArgs e)
    {
      listAlumnosBindingSource.MoveLast();
    }

    private void btAñadir_Click(object sender, System.EventArgs e)
    {
      bindingNavigatorAddNewItem.PerformClick();
    }

    private void btBorrar_Click(object sender, System.EventArgs e)
    {
      bindingNavigatorDeleteItem.PerformClick();
    }

    private void cvOrdenar_CheckedChanged(object sender, System.EventArgs e)
    {
      if (!listAlumnosBindingSource.SupportsAdvancedSorting) return;
      if (cvOrdenar.Checked == true)
        //listAlumnosBindingSource.Sort = "BecaAlumno DESC, NomAlumno ASC";
        vista.ApplySort("BecaAlumno DESC, NomAlumno ASC");
      else
        //listAlumnosBindingSource.Sort = "IdAlumno";
        vista.ApplySort("IdAlumno");
    }

    private void cvFiltrar_CheckedChanged(object sender, System.EventArgs e)
    {
      if (!listAlumnosBindingSource.SupportsFiltering) return;
      if (cvFiltrar.Checked == true)
      {
        vista.ApplyFilter(delegate(Alumno alum)
        {
          return alum.BecaAlumno == true;
        });
      }
      else
        vista.RemoveFilter();
    }

    private void ctBuscar_TextChanged(object sender, System.EventArgs e)
    {
      if (!listAlumnosBindingSource.SupportsSearching) return;
      if (cvBuscar.Checked == true)
        listAlumnosBindingSource.Position = vista.Find("NomAlumno", ctBuscar.Text);
        //listAlumnosBindingSource.Position = listAlumnosBindingSource.Find("NomAlumno", ctBuscar.Text);
      else
        ctBuscar.Text = "";
    }
  }
}
