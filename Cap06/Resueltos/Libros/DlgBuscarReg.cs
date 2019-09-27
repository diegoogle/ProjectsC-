using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros
{
  public partial class DlgBuscarReg : Form
  {
    public DlgBuscarReg()
    {
      InitializeComponent();
    }

    private void DlgBuscarReg_Load(object sender, EventArgs e)
    {
      // Llenar la lista con los títulos de los libros
      SortedList<string, Libro> objListaLibros =
                                  ((Form1)this.Owner).ObtenerDatos();
      foreach (KeyValuePair<string, Libro> elemento in objListaLibros)
        lsListaLibros.Items.Add(elemento.Key);
    }

    private void btAceptar_Click(object sender, EventArgs e)
    {
      if (lsListaLibros.SelectedIndex < 0) return;
      ((Form1)this.Owner).MostrarRegDatos(
                            lsListaLibros.SelectedItem.ToString());
    }

    private void btCancelar_Click(object sender, EventArgs e)
    {
      Hide();
    }

    public void Actualizar(int ind, Libro unLibro)
    {
      // Actualizar la lista con el nuevo título introducido
      lsListaLibros.Items.Insert(ind, unLibro.ToString());
    }

    private void btBorrar_Click(object sender, EventArgs e)
    {
      int ind = lsListaLibros.SelectedIndex;
      if (ind < 0) return;
      // Borrar en listaLibros el libro correspondiente al título seleccionado
      ((Form1)this.Owner).ObtenerDatos().Remove(
                              lsListaLibros.SelectedItem.ToString());
      // Borrar el título seleccionado en el control lista
      lsListaLibros.Items.RemoveAt(ind);
    }
  }
}
