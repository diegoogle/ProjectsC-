using System.Windows.Forms;
using BaseDeDatos;
using Equin.ApplicationFramework;
using System;
using System.Text.RegularExpressions;

namespace ControlDeErrores
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
      contextMenuEstudios.Items.AddRange(bbdd.ObtenerEstudios);
      contextMenuTiposAsigs.Items.AddRange(bbdd.ObtenerTiposAsigs);
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
        vista.ApplySort("BecaAlumno DESC, NomAlumno ASC");
      else
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

    private void ctFiltrarBuscar_TextChanged(object sender, System.EventArgs e)
    {
      if (!listAlumnosBindingSource.SupportsSearching) return;
      if (cvBuscar.Checked == true)
        listAlumnosBindingSource.Position = vista.Find("NomAlumno", ctBuscar.Text);
      else
        ctBuscar.Text = "";
    }

    private void listAlumnosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      if (e.Exception != null &&
          e.Context == DataGridViewDataErrorContexts.Commit)
      {
        switch (this.listAlumnosDataGridView.Columns[e.ColumnIndex].HeaderText)
        {
          case "ID":
            MessageBox.Show(e.Exception.Message);
            break;
        }
      }
    }

    private void listAlumnosDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
      Regex ex_reg;
      switch (listAlumnosDataGridView.Columns[e.ColumnIndex].HeaderText)
      {
        case "Nombre":
          // Expresión regular: una o más letras/espacios
          ex_reg = new Regex("^([a-zA-ZñÑáÁéÉíÍóÓúÚ]\\s*)+$");
          if (!ex_reg.IsMatch(e.FormattedValue.ToString()))
          {
            listAlumnosDataGridView.Rows[e.RowIndex].ErrorText =
                "El nombre tiene que tener una o más letras/espacios";
            e.Cancel = true;
          }
          break;
        case "Dirección":
          // Expresión regular: uno o más caracteres alfanuméricos
          ex_reg = new Regex("^(\\w\\s*)+$");
          if (!ex_reg.IsMatch(e.FormattedValue.ToString()))
          {
            listAlumnosDataGridView.Rows[e.RowIndex].ErrorText =
                "La dirección no puede estar vacía";
            e.Cancel = true;
          }
          break;
      }
    }

    private void listAlumnosDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      listAlumnosDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
    }

    private void contextMenuEstudios_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      ObjectView<Alumno> obVista =
        listAlumnosBindingSource.Current as ObjectView<Alumno>;
      obVista.Object.EstAlumno = e.ClickedItem.Text;
    }

    // Segunda rejilla

    private void contextMenuTiposAsigs_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      Asignaturas obj =
        listaCoAsignaturasBindingSource.Current as Asignaturas;
      // Modificar el tipo de asignaturas
      obj.Tipo = e.ClickedItem.Text;
    }

    private void listaCoAsignaturasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      // Si es la fila siguiente a la última válida
      if (e.RowIndex == listaCoAsignaturasDataGridView.Rows.Count - 1)
      {
        MessageBox.Show("Haga clic sobre una fila existente");
        return;
      }
      // Añadir una fila nueva; pasa a ser la actual.
      listaCoAsignaturasBindingSource.AddNew();
      Asignaturas obj = listaCoAsignaturasBindingSource.Current as Asignaturas;
      obj.Tipo = "Clic con el botón secundario para elegir un tipo";
    }

    private void listaCoAsignaturasDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      string tipo = listaCoAsignaturasDataGridView.CurrentCell.Value.ToString();
      contextMenuAsigs.Items.Clear();
      switch (tipo)
      {
        case "Obligatorias":
          contextMenuAsigs.Items.AddRange(bbdd.ObtenerAsigsOB);
          break;
        case "Optativas":
          contextMenuAsigs.Items.AddRange(bbdd.ObtenerAsigsOP);
          break;
      }
    }

    // Tercera rejilla

    private void contextMenuAsigs_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      // Verificar si el alumno ya está matriculado de esta asignatura
      ObjectView<Alumno> obVista =
        listAlumnosBindingSource.Current as ObjectView<Alumno>;
      if (obVista.Object.ObtenerAsignatura((int)e.ClickedItem.Tag) != null)
      {
        MessageBox.Show("IdAsignatura duplicado");
        return;
      }
      Asignatura obj =
        listaAsignaturasBindingSource.Current as Asignatura;
      // Modificar id y nombre de la asignatura
      obj.IdAsignatura = (int)e.ClickedItem.Tag;
      obj.NomAsignatura = e.ClickedItem.Text;
    }

    private void listaAsigsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      // Si es la fila siguiente a la última válida
      if (e.RowIndex == listaAsigsDataGridView.Rows.Count - 1)
      {
        MessageBox.Show("Haga clic sobre una fila existente");
        return;
      }
      // Añadir una fila nueva; pasa a ser la actual.
      listaAsignaturasBindingSource.AddNew();
      Asignatura obj = listaAsignaturasBindingSource.Current as Asignatura;
      obj.NomAsignatura = "Clic con el botón secundario para elegir una asignatura";
    }
  }
}
