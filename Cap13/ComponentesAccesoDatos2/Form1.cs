using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesAccesoDatos
{
  public partial class Form1 : Form
  {
    private CTelefonoBLL bd = new CTelefonoBLL();
    private ColCTelefonos coTfnos;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        // Origen de datos
        coTfnos = bd.ObtenerFilasTfnos();
        colCTelefonosBindingSource.DataSource = coTfnos;
      }
      catch (System.Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
