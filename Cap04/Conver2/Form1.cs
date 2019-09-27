using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conver2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void CajaTexto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == Convert.ToChar(13))
      {
        // Se pulsó la tecla Entrar
        e.Handled = true;
        Conversion(sender);
      }
      else if (e.KeyChar == Convert.ToChar(8))
      {
        // Se pulsó la tecla retroceso
        e.Handled = false;
      }
      else if (e.KeyChar == ',')
      {
        TextBox ObjTextBox = (TextBox)sender;
        if (ObjTextBox.Text.IndexOf(',') != -1)
        {
          // Solo puede haber una coma
          e.Handled = true;
        }
      }
      else if (e.KeyChar == '-' || e.KeyChar == '+')
      {
        TextBox ObjTextBox = (TextBox)sender;
        // Admitir - o + solo en la primera posición:
        if (ObjTextBox.SelectionLength == ObjTextBox.TextLength)
        {
          // Todo el texto está seleccionado: se sobrescribe con el signo
          e.Handled = false;
        }
        else if (ObjTextBox.TextLength != 0)
        {
          // La primera posición ya está ocupada
          e.Handled = true;
        }
      }
      else if (e.KeyChar < '0' || e.KeyChar > '9')
      {
        // Desechar los caracteres que no son dígitos
        e.Handled = true;
      }
    }

    private void Conversion(object sender)
    {
      TextBox objTextBox = (TextBox)sender;
      try
      {
        double grados;
        // Si se escribió en la caja de texto grados centígrados...
        if (objTextBox == ctGradosC)
        {
          grados = Convert.ToDouble(ctGradosC.Text) * 9.0 / 5.0 + 32.0;
          // Mostrar el resultado redondeado a dos decimales
          ctGradosF.Text = string.Format("{0:F2}", grados);
        }
        // Si se escribió en la caja de texto grados Fahrenheit...
        if (objTextBox == ctGradosF)
        {
          grados = (Convert.ToDouble(ctGradosF.Text) - 32.0) * 5.0 / 9.0;
          // Mostrar el resultado redondeado a dos decimales
          ctGradosC.Text = string.Format("{0:F2}", grados);
        }
      }
      catch (FormatException)
      {
        ctGradosC.Text = "0,00";
        ctGradosF.Text = "32,00";
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //this.Visible = true;
      //ctGradosC.Focus();
      //ctGradosF.Select();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      ctGradosC.Focus();
    }

    private void CajaTexto_Enter(object sender, EventArgs e)
    {
      TextBox ObjTextBox = (TextBox)sender;
      ObjTextBox.SelectAll();
    }

    private void CajaTexto_MouseClick(object sender, MouseEventArgs e)
    {
      TextBox ObjTextBox = (TextBox)sender;
      ObjTextBox.SelectAll();
    }
  }
}
