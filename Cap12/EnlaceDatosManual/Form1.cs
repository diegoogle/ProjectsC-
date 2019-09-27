using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnlaceDatosManual
{
  public partial class Form1 : Form
  {
    private CTelefono objTfno = new CTelefono();

    public Form1()
    {
      InitializeComponent();
      ctNombre.Text = objTfno.Nombre;
      ctTfno.Text = objTfno.Telefono;
      objTfno.PropertyChanged += objTfno_PropertyChanged;
    }

    private void objTfno_PropertyChanged(object sender,
    PropertyChangedEventArgs e)
    {
      switch (e.PropertyName)
      {
        case "Nombre":
          ctNombre.Text = objTfno.Nombre;
          break;
        case "Telefono":
          ctTfno.Text = objTfno.Telefono;
          break;
      }
    }

    private void btDatosObj_Click(object sender, EventArgs e)
    {
      string sDatos = objTfno.Nombre + "\n" + objTfno.Telefono;
      MessageBox.Show(sDatos);
    }

    private void btModificarObj_Click(object sender, EventArgs e)
    {
      objTfno.Nombre = "Abcde Fghijk";
      objTfno.Telefono = "123456789";
    }

    private void ctNombre_TextChanged(object sender, EventArgs e)
    {
      objTfno.Nombre = ctNombre.Text;
    }

    private void ctTfno_TextChanged(object sender, EventArgs e)
    {
      objTfno.Telefono = ctTfno.Text;
    }
  }
}
