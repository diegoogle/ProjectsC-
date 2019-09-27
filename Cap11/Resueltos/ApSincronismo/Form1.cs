using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ApSincronismo
{
  public partial class Form1 : Form
  {
    // Delegado para acceder a la propiedad Items de lsHilos
    private delegate void SetItemListDelegate(string prItems);
    // Identificador (0, 1, 2,...) del siguiente Contador que se cree
    private int idHilo;
    // Variable miembro compartida por todos los hilos
    public int varX;

    public Form1()
    {
      InitializeComponent();
    }

    private void btIniciarHilo_Click(object sender, EventArgs e)
    {
      // Construir un objeto nuevo de la clase Contador
      Contador nuevoContador = new Contador(this, idHilo);
      idHilo += 1;
      // Crear un hilo contador que ejecute el método TareaHilo
      Thread hiloContador = new Thread(nuevoContador.TareaHilo);
      // Establecer el hilo como un subproceso en segundo plano para
      // que sea automáticamente abortado cuando el hilo principal
      // sea detenido
      hiloContador.IsBackground = true;
      // Iniciar el hilo contador
      hiloContador.Start();
    }

    public void SetItem_lsHilos(string item)
    {
      // Delegado para acceder a la propiedad Items de la lsHilos
      if (lsHilos.InvokeRequired)
      {
        SetItemListDelegate delegado = new SetItemListDelegate(SetItem_lsHilos);
        lsHilos.Invoke(delegado, new object[] { item });
      }
      else
        lsHilos.Items.Add(item);
    }
  }

  // Clase contador. Define un objeto "hilo contador".
  // Su método TareaHilo muestra la cuenta en la lista lsHilos.
  public class Contador
  {
    // Objeto Form al que pertenece la variable compartida varX
    private Form1 m_Form;
    // Identificador del hilo
    private int m_idHilo;

    public Contador(Form1 formulario, int id_hilo)
    {
      m_Form = formulario;
      m_idHilo = id_hilo;
    }

    // Contador de segundos. Se visualiza en el control lsHilos.
    public void TareaHilo()
    {
      string item;
      try
      {
        do
        {
          // Cerrojo para que la variable compartida varX sea
          // accedida por un solo hilo cada vez. Cuando un hilo
          // echa el cerrojo (ejecuta la sección crítica), los
          // demás esperan hasta que se quite el cerrojo.
          lock (m_Form) // m_Form es el objeto en el que
          {             // se va a adquirir el bloqueo
            // 1. Lectura del dato
            int i = m_Form.varX;

            // 2. Proceso
            // Se produce un cambio de contexto
            Thread.Sleep(DateTime.Now.Millisecond % 100);
            i++;

            // 3. Escribir el resultado
            m_Form.varX = i;

            // Mostrar el valor de varX en la lista de Form1
            item = "Hilo " + m_idHilo + ": " + m_Form.varX;
            m_Form.SetItem_lsHilos(item);
          }
        }
        while (true);
      }
      catch (Exception ex)
      {
        // Error inesperado
        Debug.WriteLine("Error inesperado en el hilo " + m_idHilo);
        Debug.WriteLine(ex.Message);
      }
    }
  }
}