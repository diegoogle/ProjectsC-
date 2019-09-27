using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bodega
{
  public partial class formPlantilla : Form
  {
    public formPlantilla()
    {
      InitializeComponent();
    }

    private void btAceptar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btCancelar_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}