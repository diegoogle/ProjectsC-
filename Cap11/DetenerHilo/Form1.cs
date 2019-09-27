using System;
using System.Windows.Forms;
using System.Threading;

namespace ApMultiproceso
{
  public partial class Form1 : Form
  {
    // Hilo para ejecutar una tarea secundaria
    private Thread hiloSecundario;

    // Controladores de espera de eventos:
    // "Parar hilo" e "Hilo parado"
    private ManualResetEvent controladorPararHiloSecundario;
    private ManualResetEvent controladorHiloSecundarioParado;

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

        // ¿El hilo principal ha solicitado parar?
        // WaitOne devolverá true cuando el estado del controlador
        // pase a señalizado
        if (controladorPararHiloSecundario.WaitOne(0, false))
        {
          // Tareas de limpieza
          // Informar al hilo principal de que este hilo ha parado
          // cambiando el estado de este controlador de espera a
          // señalizado.
          SetEnabled_btCalcular(true);
          SetEnabled_numCargaUCP(true);
          controladorHiloSecundarioParado.Set();
          return;
        }
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
        btCalcular.BeginInvoke(delegado, new object[] { b });
      }
      else
        btCalcular.Enabled = b;
    }

    private void SetEnabled_numCargaUCP(bool b)
    {
      if (numCargaUCP.InvokeRequired)
      {
        SetEnabledDelegate delegado = new SetEnabledDelegate(SetEnabled_numCargaUCP);
        numCargaUCP.BeginInvoke(delegado, new object[] { b });
      }
      else
        numCargaUCP.Enabled = b;
    }

    private void btCalcular_Click(object sender, EventArgs e)
    {
      btCalcular.Enabled = false;
      numCargaUCP.Enabled = false;
      bpProgreso.Value = 0;
      // Crear los controladores "Parar hilo" e "Hilo parado".
      // False: el estado de los controladores es no señalizado
      controladorPararHiloSecundario = new ManualResetEvent(false);
      controladorHiloSecundarioParado = new ManualResetEvent(false);
      // Creación del hilo
      hiloSecundario = new Thread(TareaSecundaria);
      // Ejecución del hilo
      hiloSecundario.Start();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      PararHiloSecundario();
    }

    private bool PararHiloSecundario()
    {
      // Método utilizado por el hilo principal para
      // detener la ejecución del hilo secundario
      if (hiloSecundario == null || !hiloSecundario.IsAlive)
        return false;

      // Cambiar el estado de este controlador de espera a señalizado
      // para informar al hilo secundario de que debe parar
      controladorPararHiloSecundario.Set();

      // Esperar a que el hilo secundario informe de que ha parado
      while (hiloSecundario.IsAlive)
      {
        // MUY IMPORTANTE:
        // Aquí no se puede utilizar una espera indefinida porque el 
        // hilo secundario hace llamadas síncronas al hilo principal, 
        // y esto podría causar interbloqueos (abrazo mortal). Por 
        // esta razón, se espera por controladorHiloSecundarioParado 
        // (un tiempo apropiado y de paso damos tiempo al hilo 
        // secundario) y se permite procesar otros eventos. Estos
        // eventos pueden incluir llamadas Invoke.
        WaitHandle.WaitAll((new ManualResetEvent[] { controladorHiloSecundarioParado }), 100, false);
        Application.DoEvents(); // procesar otros eventos
      }
      hiloSecundario = null;
      return true;
    }
  }
}
