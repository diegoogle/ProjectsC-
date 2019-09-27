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
  public partial class DlgCasillaVerificacion : Form
  {
    public DlgCasillaVerificacion()
    {
      InitializeComponent();
    }

    private void cvConverMayus_CheckedChanged(object sender, EventArgs e)
    {
      //string texto = ctTexto.Text;
      //if (cvConverMayus.Checked)
      //  ctTexto.Text = texto.ToUpper();
      //else
      //  ctTexto.Text = texto.ToLower();
      //ctTexto.Focus();
      //ctTexto.SelectionStart = ctTexto.Text.Length;
    }

    private void ctTexto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (cvConverMayus.CheckState == CheckState.Unchecked)
      {
        if (char.IsUpper(e.KeyChar))
          e.KeyChar = char.ToLower(e.KeyChar);
      }
      else if (cvConverMayus.CheckState == CheckState.Checked)
      {
        if (char.IsLower(e.KeyChar))
          e.KeyChar = char.ToUpper(e.KeyChar);
      }
    }

    private void cvConverMayus_Click(object sender, EventArgs e)
    {
      ctTexto.Focus();
      ctTexto.SelectionStart = ctTexto.Text.Length;
    }
  }
}
