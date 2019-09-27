using System;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EnlaceDatosNET
{
  public partial class Form1 : Form
  {
    private CTelefono objTfno = new CTelefono();

    public Form1()
    {
      InitializeComponent();
      ctNombre.DataBindings.Add(new Binding("Text", objTfno, "Nombre"));
      ctTfno.DataBindings.Add(new Binding("Text", objTfno, "Telefono"));
      // Controlar los eventos Parse y Format del enlace de ctTfno
      Binding bTelefono = ctTfno.DataBindings["Text"];
      bTelefono.Parse += new ConvertEventHandler(StringToDecimal);
      bTelefono.Format += new ConvertEventHandler(DecimalToString);
      Binding bNombre = ctNombre.DataBindings["Text"];
      bNombre.Parse += new ConvertEventHandler(bNombre_Parse);
    }

    private void StringToDecimal(object sender, ConvertEventArgs e)
    {
      // Parse ocurre siempre que haya que actualizar
      // la propiedad Telefono con el contenido de ctTfno
      if (e.DesiredType != typeof(decimal)) return;
      try
      {
        e.Value = Decimal.Parse(e.Value.ToString());
      }
      catch (FormatException exc)
      {
        MessageBox.Show("Introducir el teléfono sin espacios");
      }
    }

    private void DecimalToString(object sender, ConvertEventArgs e)
    {
      // Format ocurre siempre que haya que mostrar en ctTfno
      // el valor de la propiedad Telefono
      if (e.DesiredType != typeof(string)) return;
      e.Value = ((decimal)e.Value).ToString("# 000 000 000");
    }

    private void bNombre_Parse(object sender, ConvertEventArgs e)
    {
      // Parse ocurre siempre que haya que actualizar
      // la propiedad Nombre con el contenido de ctNombre
      if (e.DesiredType != typeof(string)) return;
      try
      {
        // Expresión regular: una o más letras y espacios
        Regex ex_reg = new Regex("^([a-zA-ZñÑáÁéÉíÍóÓúÚ]\\s*)+$");
        if (!ex_reg.IsMatch(e.Value.ToString()))
          throw new FormatException("Debe especificar un nombre");
      }
      catch (FormatException exc)
      {
        MessageBox.Show(exc.Message);
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
      objTfno.Telefono = 123456789M;
    }
  }
}
