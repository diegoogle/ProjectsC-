using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajasDeDialogo
{
  public partial class DlgListaSimple : Form
  {
    public DlgListaSimple()
    {
      InitializeComponent();
    }

    private void DlgListaSimple_Load(object sender, EventArgs e)
    {
      //string[] elemento = new string[] {
      //"uno", "dos", "tres", "cuatro", "cinco", "seis", "siete",
      //"ocho", "nueve", "diez", "once", "doce", "trece", "catorce" };
      //this.lsLista1.Items.AddRange(elemento);
    }

    private void btAceptar_Click(object sender, EventArgs e)
    {
      //if (lsLista1.SelectedIndex < 0) return;
      //object elementoSeleccionado;
      //elementoSeleccionado = lsLista1.SelectedItem;
      //MessageBox.Show(elementoSeleccionado.ToString());

      if (lsLista1.SelectedIndex < 0) return;
      string s = "";
      for (int i = 0; i < lsLista1.SelectedItems.Count; i++)
        s = s + lsLista1.SelectedItems[i].ToString() + Environment.NewLine;
      MessageBox.Show(s);
    }

    private void btAñadir_Click(object sender, EventArgs e)
    {
      // Añadir el elemento introducido en la
      // caja de texto ctAñadir
      if (ctAñadir.Text.Length != 0)
        lsLista1.Items.Add(ctAñadir.Text);
    }

    private void btBorrar_Click(object sender, EventArgs e)
    {
      if (lsLista1.SelectedIndex < 0) return;
      lsLista1.Items.RemoveAt(lsLista1.SelectedIndex);
    }
  }
}
