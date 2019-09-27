using System;
using System.Windows.Forms;

namespace Alarma
{
  // Delegado para el evento
  public delegate void TiempoAgotadoEventHandler(
                           object sender, TiempoAgotadoEventArgs e);

  public partial class Alarma : UserControl
  {
    private bool _Activada;
    private DateTime _FechaHoraAlarma;

    // Evento TiempoAgotado; es implementado por un
    // delegado TiempoAgotadoEventHandler
    public event TiempoAgotadoEventHandler TiempoAgotado;

    // Método que genera el evento invocando al delegado
    protected virtual void OnTiempoAgotado(TiempoAgotadoEventArgs e)
    {
      if (TiempoAgotado != null)
      {
        // Invocar al delegado
        TiempoAgotado(this, e);
      }
    }

    public Alarma()
    {
      InitializeComponent();
    }

    public bool Activada
    {
      get { return _Activada; }
    }

    public DateTime FechaHoraAlarma
    {
      get { return _FechaHoraAlarma; }
      set
      {
        _FechaHoraAlarma = value;
        ctAlarma.Text = value.ToString("dd/MM/yyyy HH:mm:ss");
      }
    }

    public void IniciarTemporizador()
    {
      // Asignar la fecha-hora introducida en el control
      // a la propiedad FechaHoraAlarma
      try
      {
        FechaHoraAlarma = DateTime.Parse(ctAlarma.Text);
      }
      catch (InvalidCastException)
      {
        MessageBox.Show("La fecha-hora alarma no es correcta");
        return;
      }
      // No permitir asignar una fecha-hora anterior a la actual
      if (FechaHoraAlarma.CompareTo(DateTime.Now) <= 0)
      {
        MessageBox.Show("La fecha-hora alarma es menor que la actual");
        return;
      }
      // Activar el temporizador
      if (!Timer1.Enabled)
      {
        Timer1.Enabled = true;
        _Activada = true;
      }
    }

    public void PararTemporizador()
    {
      // Desactivar el temporizador
      if (Timer1.Enabled)
      {
        Timer1.Enabled = false;
        _Activada = false;
      }
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      // Si se agotó el tiempo, generar el evento TiempoAgotado
      if (DateTime.Now.CompareTo(FechaHoraAlarma) >= 0)
      {
        Timer1.Enabled = false;
        _Activada = false;
        if (TiempoAgotado != null)
          OnTiempoAgotado(new TiempoAgotadoEventArgs());
        return;
      }
      //Visualizar
      if (boFechaHoraAlarma.Checked)
      {
        //fecha-hora alarma
        ctAlarma.Text = FechaHoraAlarma.ToString("dd/MM/yyyy HH:mm:ss");
      }
      else
      {
        //fecha-hora actual
        ctAlarma.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
      }
    }

    private void boFechaHoraAlarma_CheckedChanged(object sender, EventArgs e)
    {
      if (!boFechaHoraAlarma.Checked) return;
      ctAlarma.ReadOnly = false;
      ctAlarma.Text = FechaHoraAlarma.ToString("dd/MM/yyyy HH:mm:ss");
    }

    private void boFechaHoraActual_CheckedChanged(object sender, EventArgs e)
    {
      if (!boFechaHoraActual.Checked) return;
      ctAlarma.ReadOnly = true;
      ctAlarma.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }
  }
}