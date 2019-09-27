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
  public partial class DlgPanelDeDiseño : Form
  {
    private TextBox ctEnfocada = null;

    public DlgPanelDeDiseño()
    {
      InitializeComponent();
    }

    private void btAñadir_Click(object sender, EventArgs e)
    {
      // Añadir un nuevo elemento con el contenido de la
      // caja de texto ctAñadir
      if (ctAñadir.Text.Length != 0)
      {
        TextBox elemento = new TextBox();
        elemento.Click += textBox_Click; // controlador del evento Click
        elemento.Width = flpLista.Width - 28;
        elemento.Text = ctAñadir.Text;
        // Añadir el elemento a la lista
        flpLista.Controls.Add(elemento);
      }
    }

    private void textBox_Click(object sender, EventArgs e)
    {
      ctEnfocada = sender as TextBox;
    }

    private void btAceptar_Click(object sender, EventArgs e)
    {
      if (ctEnfocada != null)
        MessageBox.Show(ctEnfocada.Text);
    }

    private void btBorrar_Click(object sender, EventArgs e)
    {
      flpLista.Controls.Remove(ctEnfocada);
      ctEnfocada = null;
    }
  }
}
