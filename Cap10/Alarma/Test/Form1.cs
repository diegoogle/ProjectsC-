using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Alarma1.FechaHoraAlarma = DateTime.Parse("1/1/2013 12:00:00 PM");
    }

    private void btAlarma_Click(object sender, EventArgs e)
    {
      if (!Alarma1.Activada)
        Alarma1.IniciarTemporizador();
      else
        Alarma1.PararTemporizador();

      if (Alarma1.Activada)
      {
        btAlarma.Text = "Desactivar alarma";
        etEstadoAlarma.Text = "Alarma activada";
        etEstadoAlarma.ForeColor = Color.Red;
      }
      else
      {
        btAlarma.Text = "Activar alarma";
        etEstadoAlarma.Text = "Alarma desactivada";
        etEstadoAlarma.ForeColor = Color.Blue;
      }
    }

    private void Alarma1_TiempoAgotado(object sender, Alarma.TiempoAgotadoEventArgs e)
    {
      MessageBox.Show("Se generó el evento TiempoAgotado");
      btAlarma.Text = "Activar alarma";
      etEstadoAlarma.Text = "Alarma desactivada";
      etEstadoAlarma.ForeColor = Color.Blue;
    }
  }
}