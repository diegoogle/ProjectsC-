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
  public partial class DlgBotonOpcion : Form
  {
    private int numeroActual;
  
    public DlgBotonOpcion()
    {
      InitializeComponent();
    }

    private void ctDato_TextChanged(object sender, EventArgs e)
    {
      if (ctDato.Text.Length == 0) return;

      string texto = ctDato.Text;
      int baseNum = 0;

      if (btopDecimal.Checked)
        baseNum = 10;
      else if (btopOctal.Checked)
        baseNum = 8;
      else if (btopHex.Checked)
        baseNum = 16;

      try
      {
        numeroActual = Convert.ToInt32(texto, baseNum);
      }
      catch (FormatException ex)
      {
        if (texto == "-" || texto == "+") return;
        MessageBox.Show(ex.Message);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btopDecOcHex_CheckedChanged(object sender, EventArgs e)
    {
      if (btopDecimal.Checked)
        ctDato.Text = Convert.ToString(numeroActual, 10);
      else if (btopOctal.Checked)
        ctDato.Text = Convert.ToString(numeroActual, 8);
      else if (btopHex.Checked)
        ctDato.Text = Convert.ToString(numeroActual, 16).ToUpper();
      ctDato.Focus();
    }
  }
}
