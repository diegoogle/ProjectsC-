using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace BindingList
{
  public partial class Form1 : Form
  {
    private BindingList<CTelefono> colTfnos;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      colTfnos = FactoriaCTelefono.ObtenerColeccionCTelefono();
      listTfnos.DataSource = colTfnos;
      listTfnos.DisplayMember = "Nombre";
      ctTfnoSelec.DataBindings.Add("Text", colTfnos, "Telefono");
    }

    private void btAñadir_Click(object sender, EventArgs e)
    {
      decimal tef = 0;
      if (ctNombre.Text.Length != 0 &&
          ctTfno.Text.Length != 0 &&
          Decimal.TryParse(ctTfno.Text, out tef))
      {
        colTfnos.Add(FactoriaCTelefono.CrearCTelefono(ctNombre.Text, tef));
      }
    }

    private void btBorrar_Click(object sender, EventArgs e)
    {
      int pos = listTfnos.SelectedIndex;
      if (pos < 0) return;
      colTfnos.RemoveAt(pos);
    }

    private void btModificar_Click(object sender, EventArgs e)
    {
      int pos = listTfnos.SelectedIndex;
      if (ctNombre.Text.Length != 0)
      {
        colTfnos[pos].Nombre = ctNombre.Text;
      }
      decimal tef = 0;
      if (ctTfno.Text.Length != 0 && Decimal.TryParse(ctTfno.Text, out tef))
      {
        colTfnos[pos].Telefono = tef;
      }
    }
  }
}
