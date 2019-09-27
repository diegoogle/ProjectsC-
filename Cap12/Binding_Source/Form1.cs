using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Binding_Source
{
  public partial class Form1 : Form
  {
    private List<CTelefono> colTfnos;
    private BindingSource bs;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      colTfnos = FactoriaCTelefono.ObtenerColeccionCTelefono();
      bs = new BindingSource();
      bs.DataSource = colTfnos;
      listTfnos.DataSource = bs;
      listTfnos.DisplayMember = "Nombre";
      ctTfnoSelec.DataBindings.Add("Text", bs, "Telefono");
    }

    private void btAñadir_Click(object sender, EventArgs e)
    {
      decimal tef = 0;
      if (ctNombre.Text.Length != 0 && ctTfno.Text.Length != 0 &&
          Decimal.TryParse(ctTfno.Text, out tef))
      {
        colTfnos.Add(FactoriaCTelefono.CrearCTelefono(ctNombre.Text, tef));
        bs.Position = bs.Count;
        bs.CurrencyManager.Refresh();
      }
    }

    private void btBorrar_Click(object sender, EventArgs e)
    {
      if (bs.Position < 0) return;
      colTfnos.RemoveAt(bs.Position);
      bs.CurrencyManager.Refresh();
    }

    private void btModificar_Click(object sender, EventArgs e)
    {
      bool cambios = false;
      if (ctNombre.Text.Length != 0)
      {
        (bs.Current as CTelefono).Nombre = ctNombre.Text;
        cambios = true;
      }
      decimal tef = 0;
      if (ctTfno.Text.Length != 0 && Decimal.TryParse(ctTfno.Text, out tef))
      {
        (bs.Current as CTelefono).Telefono = tef;
        cambios = true;
      }
      if (cambios) bs.CurrencyManager.Refresh();
    }
  }
}
