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
  public partial class DlgListaDesplegable : Form
  {
    public DlgListaDesplegable()
    {
      InitializeComponent();
    }

    private void DlgListaDesplegable_Load(object sender, EventArgs e)
    {
      //string[] elemento = new string[] {
      //    "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete",
      //    "ocho", "nueve", "diez", "once", "doce", "trece", "catorce" };
      //this.ldLista1.Items.AddRange(elemento);
    }

    private void btAceptar_Click(object sender, EventArgs e)
    {
      if (ldLista1.SelectedIndex < 0) return;
      object elementoSeleccionado;
      elementoSeleccionado = ldLista1.SelectedItem;
      MessageBox.Show(elementoSeleccionado.ToString());
    }

    private void btAñadir_Click(object sender, EventArgs e)
    {
      // Añadir el elemento introducido en la
      // caja de texto ctAñadir
      if (ctAñadir.Text.Length != 0)
        ldLista1.Items.Add(ctAñadir.Text);
    }

    private void btBorrar_Click(object sender, EventArgs e)
    {
      if (ldLista1.SelectedIndex < 0) return;
      ldLista1.Items.RemoveAt(ldLista1.SelectedIndex);
    }
  }
}
