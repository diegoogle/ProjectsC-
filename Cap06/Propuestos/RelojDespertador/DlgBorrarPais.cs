using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelojDespertador
{
  public partial class DlgBorrarPais : Form
  {
    public DlgBorrarPais()
    {
      InitializeComponent();
    }

    private void DlgBorrarPais_Load(object sender, EventArgs e)
    {
			// Llenar la lista con los nombres de los países
			List<Pais> objListaPaises = ((Form1) this.Owner).ObtenerDatos();
			Pais elemento;
      foreach (Pais tempLoopVar_elemento in objListaPaises)
      {
        elemento = tempLoopVar_elemento;
        lsListaPaises.Items.Add(elemento);
      }
    }
  }
}