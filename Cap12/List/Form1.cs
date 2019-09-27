using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace List
{
  public partial class Form1 : Form
  {
    private List<CTelefono> colTfnos;
    private CurrencyManager cm; 

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

      cm = listTfnos.BindingContext[colTfnos] as CurrencyManager;
    }

    private void btAñadir_Click(object sender, EventArgs e)
    {
      decimal tef = 0;
      if (ctNombre.Text.Length != 0 && ctTfno.Text.Length != 0 &&
          Decimal.TryParse(ctTfno.Text, out tef))
      {
        colTfnos.Add(FactoriaCTelefono.CrearCTelefono(ctNombre.Text, tef));
        cm.Position = cm.Count;
        cm.Refresh();
      }
    }

    private void btBorrar_Click(object sender, EventArgs e)
    {
      if (cm.Position < 0) return;
      colTfnos.RemoveAt(cm.Position);
      cm.Refresh();
    }

    private void btModificar_Click(object sender, EventArgs e)
    {
      bool cambios = false;
      if (ctNombre.Text.Length != 0)
      {
        (cm.Current as CTelefono).Nombre = ctNombre.Text;
        cambios = true;
      }
      decimal tef = 0;
      if (ctTfno.Text.Length != 0 && Decimal.TryParse(ctTfno.Text, out tef))
      {
        (cm.Current as CTelefono).Telefono = tef;
        cambios = true;
      }
      if (cambios) cm.Refresh();
    }
  }
}
