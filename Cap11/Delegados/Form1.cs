using System;
using System.Threading;
using System.Windows.Forms;

namespace ApMultiproceso
{
  public partial class Form1 : Form
  {
    // Hilo para ejecutar una tarea secundaria
    private Thread hiloSecundario;

    // Delegado para acceder a la propiedad Value de bpProgreso
    private delegate void SetValueDelegate(int prValue);
    // Delegado para acceder a la propiedad Enabled de los botones
    private delegate void SetEnabledDelegate(bool prEnabled);

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
          SetValue_bpProgreso(tpHecho);
      }
      SetEnabled_btCalcular(true);
      SetEnabled_numCargaUCP(true);
    }

    private void SetValue_bpProgreso(int hecho)
    {
      // control.InvokeRequired devuelve true si el ID del hilo para
      // el que ha sido invocado este método es el ID del hilo que
      // creo el control
      if (bpProgreso.InvokeRequired)
      {
        // Acceso seguro a la propiedad Value de bpProgreso desde un hilo
        SetValueDelegate delegado = new SetValueDelegate(SetValue_bpProgreso);
        bpProgreso.Invoke(delegado, new object[] { hecho });
      }
      else
        bpProgreso.Value = hecho;
    }

    private void SetEnabled_btCalcular(bool b)
    {
      if (btCalcular.InvokeRequired)
      {
        SetEnabledDelegate delegado = new SetEnabledDelegate(SetEnabled_btCalcular);
        btCalcular.Invoke(delegado, new object[] { b });
      }
      else
        btCalcular.Enabled = b;
    }

    private void SetEnabled_numCargaUCP(bool b)
    {
      if (numCargaUCP.InvokeRequired)
      {
        SetEnabledDelegate delegado = new SetEnabledDelegate(SetEnabled_numCargaUCP);
        numCargaUCP.Invoke(delegado, new object[] { b });
      }
      else
        numCargaUCP.Enabled = b;
    }

    private void btCalcular_Click(object sender, EventArgs e)
    {
      btCalcular.Enabled = false;
      numCargaUCP.Enabled = false;
      bpProgreso.Value = 0;
      // Delegado que hace referencia al método que tiene que
      // ejecutar el hilo
      ThreadStart delegadoPS = new ThreadStart(TareaSecundaria);
      // Creación del hilo
      hiloSecundario = new Thread(delegadoPS);
      // Ejecución del hilo
      hiloSecundario.Start();
    }
  }
}
