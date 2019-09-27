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
  public partial class DlgGestionFechas : Form
  {
    public DlgGestionFechas()
    {
      InitializeComponent();
    }

    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {
      DateTime fecha = e.Start;
      if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
      {
        etMensaje.Text = "Los fines de semana no se pueden seleccionar.";
      }
      else
        etMensaje.Text = "";
    }
  }
}
