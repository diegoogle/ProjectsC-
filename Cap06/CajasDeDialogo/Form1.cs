using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajasDeDialogo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      if (!contraseña()) Close();
    }

    private bool contraseña()
    {
      int nCuenta = 0;
      string sPalabraDePaso;
      // Crear la caja de diálogo de entrada
      DlgPalabraDePaso Dlg = new DlgPalabraDePaso();
      // Se admiten tres intentos para introducir la palabra de paso
      do
      {
        // Mostrar el diálogo
        if (Dlg.ShowDialog() == DialogResult.OK)
          sPalabraDePaso = Dlg.ctPalabraDePaso.Text;
        else
          return false;

        // Verificar si la palabra de paso es correcta
        if (sPalabraDePaso.Length != 0 &&
            sPalabraDePaso.CompareTo("Javier") != 0)
        {
          MessageBox.Show("La palabra de paso no es correcta", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
          nCuenta += 1;
        }
        else
          nCuenta = 4;
      }
      while (nCuenta < 3);
      if (sPalabraDePaso.Length == 0 || nCuenta == 3)
        return false; // salir de la aplicación

      return true;
    }

    private void AyudaAcercaDe_Click(object sender, EventArgs e)
    {
      DlgAcercaDe dlg = new DlgAcercaDe();
      dlg.ShowDialog();
    }

    private void DialogoCasillaV_Click(object sender, EventArgs e)
    {
      DlgCasillaVerificacion Dlg = new DlgCasillaVerificacion();
      Dlg.ShowDialog();
    }

    private void DialogoBtOpcion_Click(object sender, EventArgs e)
    {
      DlgBotonOpcion Dlg = new DlgBotonOpcion();
      Dlg.ShowDialog();
    }

    private void DialogoListaSimple_Click(object sender, EventArgs e)
    {
      DlgListaSimple Dlg = new DlgListaSimple();
      Dlg.ShowDialog();
    }

    private void DialogoListaDesplegable_Click(object sender, EventArgs e)
    {
      DlgListaDesplegable Dlg = new DlgListaDesplegable();
      Dlg.ShowDialog();
    }

    private void DialogoRangos_Click(object sender, EventArgs e)
    {
      DlgControlesRangoDefinido Dlg = new DlgControlesRangoDefinido();
      Dlg.ShowDialog();
    }

    private void DialogoTabControl_Click(object sender, EventArgs e)
    {
      DlgControlConPestañas Dlg = new DlgControlConPestañas();
      Dlg.ShowDialog();
    }

    private void DialogoGestionDefechas_Click(object sender, EventArgs e)
    {
      DlgGestionFechas Dlg = new DlgGestionFechas();
      Dlg.ShowDialog();
    }

    private void DialogoPanelDeDiseño_Click(object sender, EventArgs e)
    {
      DlgPanelDeDiseño Dlg = new DlgPanelDeDiseño();
      Dlg.ShowDialog();
    }

    private void ArchivoAbrir_Click(object sender, EventArgs e)
    {
      OpenFileDialog DlgAbrir = new OpenFileDialog();

      DlgAbrir.ShowReadOnly = true;
      DlgAbrir.InitialDirectory = "c:\\";
      DlgAbrir.Filter = "ficheros txt (*.txt)|*.txt|Todos (*.*)|*.*";
      DlgAbrir.FilterIndex = 2;
      DlgAbrir.RestoreDirectory = true;
      // Mostrar el diálogo Abrir
      if (DlgAbrir.ShowDialog() == DialogResult.OK)
      {
        // Si ReadOnlyChecked es true, utilizar OpenFile para
        // abrir el fichero solo para leer
        if (DlgAbrir.ReadOnlyChecked)
        {
          Stream fs = DlgAbrir.OpenFile();
          // Código para trabajar con el fichero
          // ...
          MessageBox.Show(DlgAbrir.FileName);
        }
        else // En otro caso, abrir el fichero para leer y escribir
        {
          string ruta = DlgAbrir.FileName;
          FileStream fs = new FileStream(ruta, FileMode.Open,
                                         FileAccess.ReadWrite);
          // Código para trabajar con el fichero
          // ...
          MessageBox.Show(DlgAbrir.FileName);
        }
      }
    }

    private void ArchivoGuardar_Click(object sender, EventArgs e)
    {
      Stream fs;
      SaveFileDialog DlgGuardar = new SaveFileDialog();

      DlgGuardar.Filter = "ficheros txt (*.txt)|*.txt|Todos (*.*)|*.*";
      DlgGuardar.FilterIndex = 2;
      DlgGuardar.RestoreDirectory = true;

      if (DlgGuardar.ShowDialog() == DialogResult.OK)
      {
        // Abrir el fichero para leer y escribir
        fs = DlgGuardar.OpenFile();
        if (fs != null)
        {
          // Código para trabajar con el fichero
          // ...
          fs.Close();
        }
      }
    }

    private void DialogoColor_Click(object sender, EventArgs e)
    {
      ColorDialog DlgColor = new ColorDialog();

      // Seleccionar inicialmente el color actual del texto
      DlgColor.Color = TextBox1.ForeColor;
      // Actualizar el color del texto de TextBox1
      if (DlgColor.ShowDialog() == DialogResult.OK)
      {
        TextBox1.ForeColor = DlgColor.Color;
      }
    }

    private void DialogoFuente_Click(object sender, EventArgs e)
    {
      FontDialog DlgFuente = new FontDialog();
      // Mostrar la lista para la elección del color
      DlgFuente.ShowColor = true;
      // Seleccionar inicialmente la fuente y el color actual del texto
      DlgFuente.Font = TextBox1.Font;
      DlgFuente.Color = TextBox1.ForeColor;

      if (DlgFuente.ShowDialog() == DialogResult.OK)
      {
      // Actualizar la fuente y el color del texto
        TextBox1.Font = DlgFuente.Font;
        TextBox1.ForeColor = DlgFuente.Color;
      }
    }

    private void DialogoTimer_Click(object sender, EventArgs e)
    {
      DlgTemporizador Dlg = new DlgTemporizador();
      Dlg.ShowDialog();
    }
  }
}
