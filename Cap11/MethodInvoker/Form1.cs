using System;
using System.Threading;
using System.Windows.Forms;

namespace ApMultiproceso
{
  public partial class Form1 : Form
  {
    // Hilo para ejecutar una tarea secundaria
    private Thread hiloSecundario;

    // Cantidad de tarea realizada en tanto por ciento
    private int tpHecho;

    public Form1()
    {
      InitializeComponent();
    }

    private void Temporizador_Tick(object sender, EventArgs e)
    {
      etHora.Text = DateTime.Now.ToLongTimeString();
    }

    private void SetValue_bpProgreso()
    {
      bpProgreso.Value = tpHecho;
    }

    private void SetEnabled_btCalcular()
    {
      btCalcular.Enabled = true;
    }

    private void SetEnabled_numCargaUCP()
    {
      numCargaUCP.Enabled = true;
    }

    private void TareaSecundaria()
    {
      int hecho = 0;
      tpHecho = 0;

      MethodInvoker delegado;
      delegado = new MethodInvoker(SetValue_bpProgreso);

      while (hecho < numCargaUCP.Value)
      {
        // Tarea secundaria
        hecho += 1;
        // Mostrar progreso
        tpHecho = (int)(hecho / numCargaUCP.Value * 100);
        if (tpHecho > bpProgreso.Value)
          bpProgreso.Invoke(delegado);
      }

      delegado = new MethodInvoker(SetEnabled_btCalcular);
      btCalcular.Invoke(delegado);
      delegado = new MethodInvoker(SetEnabled_numCargaUCP);
      numCargaUCP.Invoke(delegado);
    }

    private void btCalcular_Click(object sender, EventArgs e)
    {
      btCalcular.Enabled = false;
      numCargaUCP.Enabled = false;
      bpProgreso.Value = 0;
      // Delegado que hace referencia al método
      // que tiene que ejecutar el hilo
      ThreadStart delegadoPS = new ThreadStart(TareaSecundaria);
      // Creación del hilo
      hiloSecundario = new Thread(delegadoPS);
      // Ejecución del hilo
      hiloSecundario.Start();
    }
  }
}
