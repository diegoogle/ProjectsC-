using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close(); // cerrar el formulario principal
    }

    private void ArchivoAbrir_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Archivo > Abrir");
    }

    private void ArchivoGuardarMismoNombre_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Archivo > Guardar mismo nombre");
    }

    private void ArchivoGuardarOtroNombre_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Archivo > Guardar otro nombre");
    }

    private void ArchivoSalir_MouseEnter(object sender, EventArgs e)
    {
      etbarestPpal.Text = "Cierra la aplicación";
    }

    private void OrdenMenu_MouseLeave(object sender, EventArgs e)
    {
      etbarestPpal.Text = "Listo";
    }

    private void ArchivoAbrir_MouseEnter(object sender, EventArgs e)
    {
      etbarestPpal.Text = "Abre un fichero";
    }

    private void ArchivoGuardar_MouseEnter(object sender, EventArgs e)
    {
      etbarestPpal.Text = "Guarda un fichero";
    }

    private void ArchivoGuardarMismoNombre_MouseEnter(object sender, EventArgs e)
    {
      etbarestPpal.Text = "Guarda un fichero con el mismo nombre";
    }

    private void ArchivoGuardarOtroNombre_MouseEnter(object sender, EventArgs e)
    {
      etbarestPpal.Text = "Guarda un fichero con otro nombre";
    }
  }
}
