using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenusDinamicos
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void ElementoMenuPais_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem elemento = (ToolStripMenuItem)sender;
      MessageBox.Show(elemento.Text);
    }

    private void PaisAnadir_Click(object sender, EventArgs e)
    {
      // Inicialmente hay 3 elementos (dos ocultos)
      if (menuPais.DropDownItems.Count == 3)
      {
        // Hacer visibles los elementos Eliminar y el Separador1
        PaisEliminar.Visible = true;
        Separador1.Visible = true;
      }
      // Construir un título para el menú
      string titulo;
      titulo = "País " + (menuPais.DropDownItems.Count - 2);
      // Crear un elemento con el título construido
      ToolStripMenuItem elemento = new ToolStripMenuItem(titulo);
      // Especificar cuál será su controlador de eventos Click
      elemento.Click += new EventHandler(ElementoMenuPais_Click);
      // Añadir el elemento al menú País
      menuPais.DropDownItems.Add(elemento);
    }

    private void PaisEliminar_Click(object sender, EventArgs e)
    {
      // Eliminar el último elemento
      int indUltimo = menuPais.DropDownItems.Count - 1;
      menuPais.DropDownItems.RemoveAt(indUltimo);
      if (menuPais.DropDownItems.Count == 3)
      {
        // No quedan más países. Ocultar los elementos
        // Eliminar y el separador
        PaisEliminar.Visible = false;
        Separador1.Visible = false;
      }
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
