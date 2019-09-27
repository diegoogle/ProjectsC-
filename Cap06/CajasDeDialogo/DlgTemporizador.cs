using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajasDeDialogo
{
  public partial class DlgTemporizador : Form
  {
    private TimeSpan tAntes;
    private TimeSpan tDespues;

    public DlgTemporizador()
    {
      InitializeComponent();
    }

    private void DlgTemporizador_Load(object sender, EventArgs e)
    {
      tAntes = DateTime.Now.TimeOfDay;
      Temporizador.Interval = 1; // milisegundo
    }

    private void Temporizador_Tick(object sender, EventArgs e)
    {
      etHora.Text = DateTime.Now.ToLongTimeString(); // hora actual

      tDespues = DateTime.Now.TimeOfDay;
      Debug.WriteLine((tDespues - tAntes).Milliseconds + " mseg.");
      tAntes = tDespues;
    }
  }
}
