using System;
using System.Threading;
using System.Windows.Forms;

namespace ApMultiproceso
{
  public partial class Form1 : Form
  {
    // Hilo para ejecutar una tarea secundaria
    private Thread hiloSecundario;

    public Form1()
    {
      InitializeComponent();
    }

    private void Temporizador_Tick(object sender, EventArgs e)
    {
      etHora.Text = DateTime.Now.ToLongTimeString();
    }

    private void TareaSecundaria()
    {
      int hecho = 0, tpHecho = 0;

      while (hecho < numCargaUCP.Value)
      {
        // Tarea secundaria
        hecho += 1;
        // Mostrar progreso
        tpHecho = (int)(hecho / numCargaUCP.Value * 100);
        if (tpHecho > bpProgreso.Value)
          bpProgreso.Value = tpHecho;
      }
      btCalcular.Enabled = true;
      numCargaUCP.Enabled = true;
    }

    private void btCalcular_Click(object sender, EventArgs e)
    {
      btCalcular.Enabled = false;
      numCargaUCP.Enabled = false;
      bpProgreso.Value = 0;
      // Delegado que hace referencia al método
      // que tiene que ejecutar el hilo
      //ThreadStart delegadoPS = new ThreadStart(TareaSecundaria);
      //// Creación del hilo
      //hiloSecundario = new Thread(delegadoPS);

      // O bien:
      hiloSecundario = new Thread(TareaSecundaria);

      // Ejecución del hilo
      hiloSecundario.Start();
    }
  }
}
