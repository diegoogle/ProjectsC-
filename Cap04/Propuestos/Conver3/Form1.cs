using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Conver3
{
  public partial class Form1 : Form
  {
    private double datoCajaTexto;

    public Form1()
    {
      InitializeComponent();
    }

    private void Conversion(System.Object sender)
    {
      TextBox objTextBox = (TextBox)sender;
      double grados;

      // Si se escribió en la caja de texto grados centígrados ...
      if (objTextBox == ctGradosC)
      {
        grados = datoCajaTexto * 9.0 / 5.0 + 32.0;
        // Mostrar el resultado redondeado a dos decimales
        ctGradosF.Text = string.Format("{0:F2}", grados);
      }
      // Si se escribió en la caja de texto grados Fahrenheit ...
      if (objTextBox == ctGradosF)
      {
        grados = (datoCajaTexto - 32.0) * 5.0 / 9.0;
        // Mostrar el resultado redondeado a dos decimales
        ctGradosC.Text = string.Format("{0:F2}", grados);
      }
    }

    private void Form1_Load(System.Object sender, System.EventArgs e)
    {
      ctGradosC.Focus();
      etMostrarFecha.Text = DateTime.Now.ToLongDateString();
    }

    private void CajaTexto_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
    {
      TextBox objTextBox = (TextBox)sender;
      try
      {
        datoCajaTexto = Convert.ToDouble(objTextBox.Text);
      }
      catch (Exception)
      {
        e.Cancel = true;
        objTextBox.SelectAll();
        ProveedorDeError.SetError(objTextBox, "Tiene que ser numérico");
        //MsgBox("Tiene que ser numérico")
      }
    }

    private void CajaTexto_Validated(System.Object sender, System.EventArgs e)
    {
      Debug.WriteLine("Caja de texto validada");
      ProveedorDeError.Clear();
      Conversion(sender);
    }

    private void CajaTexto_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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

    private void btGradosCmas1_Click(System.Object sender, System.EventArgs e)
    {
      try
      {
        // Se incrementó el valor de los grados C.
        double grados = double.Parse(ctGradosC.Text) + 1;
        ctGradosC.Text = grados.ToString();
        ctGradosC.Focus(); // Como si la entrada hubiera sido en ctGradosC
        ctGradosF.Focus(); // Cambiar el foco para llamar a CajaTexto_Validating
      }
      catch (Exception)
      {
        Debug.WriteLine("El dato no es correcto");
      }
    }

    private void btGradosFmas1_Click(System.Object sender, System.EventArgs e)
    {
      try
      {
        // Se incrementó el valor de los grados F.
        double grados = double.Parse(ctGradosF.Text) + 1;
        ctGradosF.Text = grados.ToString();
        ctGradosF.Focus(); // Como si la entrada hubiera sido en ctGradosF
        ctGradosC.Focus(); // Cambiar el foco para llamar a CajaTexto_Validating
      }
      catch (Exception)
      {
        Debug.WriteLine("El dato no es correcto");
      }
    }
  }
}