using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conver3
{
  public partial class Form1 : Form
  {
    private double datoCajaTexto;

    public Form1()
    {
      InitializeComponent();
    }

    private void CajaTexto_KeyPress(object sender, KeyPressEventArgs e)
    {
      TextBox objTextBox = (TextBox)sender;
      if (e.KeyChar == Convert.ToChar(13))
      {
        // Se pulsó la tecla Entrar
        e.Handled = true;
        // Cambiar el foco a otro control
        if (objTextBox == ctGradosC)
        {
          ctGradosF.Focus();
        }
        else
        {
          ctGradosC.Focus();
        }
      }
    }

    private void Conversion(object sender)
    {
      TextBox objTextBox = (TextBox)sender;
      double grados;

      // Si se escribió en la caja de texto grados centígrados...
      if (objTextBox == ctGradosC)
      {
        grados = datoCajaTexto * 9.0 / 5.0 + 32.0;
        // Mostrar el resultado redondeado a dos decimales
        ctGradosF.Text = string.Format("{0:F2}", grados);
      }
      // Si se escribió en la caja de texto grados Fahrenheit...
      if (objTextBox == ctGradosF)
      {
        grados = (datoCajaTexto - 32.0) * 5.0 / 9.0;
        // Mostrar el resultado redondeado a dos decimales
        ctGradosC.Text = string.Format("{0:F2}", grados);
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

    private void CajaTexto_Validating(object sender, CancelEventArgs e)
    {
      TextBox objTextBox = (TextBox)sender;
      //try
      //{
      //  datoCajaTexto = Convert.ToDouble(objTextBox.Text);
      //}
      //catch (Exception)
      //{
      //  e.Cancel = true;
      //  objTextBox.SelectAll();
      //  ProveedorDeError.SetError(objTextBox, "Tiene que ser numérico");
      //}
      string patron = "^[+-]?[0-9]+,?[0-9]*$";
      if (Regex.IsMatch(objTextBox.Text, patron))
      {
        datoCajaTexto = Convert.ToDouble(objTextBox.Text); ;
      }
      else
      {
        e.Cancel = true;
        objTextBox.SelectAll();
        ProveedorDeError.SetError(objTextBox, "Tiene que ser numérico");
      }
    }

    private void CajaTexto_Validated(object sender, EventArgs e)
    {
      ProveedorDeError.Clear();
      Conversion(sender);
    }
  }
}
