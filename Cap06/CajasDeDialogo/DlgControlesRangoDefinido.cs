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
  public partial class DlgControlesRangoDefinido : Form
  {
    public DlgControlesRangoDefinido()
    {
      InitializeComponent();
    }

    private void DlgControlesRangoDefinido_Load(object sender, EventArgs e)
    {
      Temporizador.Interval = 10 * desIntervalo.Value;
    }

    private void Temporizador_Tick(object sender, EventArgs e)
    {
      int inc = 1; // incremento
      int tpHecho = 0, carga = 1000; // la cuenta es hasta 1000
      int cuenta = Convert.ToInt32(etContador.Text) + inc;
      etContador.Text = Convert.ToString(cuenta);
      // Mostrar progreso
      tpHecho = (int)((float)cuenta / carga * 100);
      if (tpHecho > bpCuenta.Value)
        bpCuenta.Value = tpHecho;

      if (cuenta == carga) Temporizador.Stop();
    }

    private void desIntervalo_ValueChanged(object sender, EventArgs e)
    {
      Temporizador.Interval = 10 * desIntervalo.Value;
    }
  }
}
