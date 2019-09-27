using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApWinForms
{
  static class Program
  {
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      Application.ApplicationExit += new EventHandler(OnApplicationExit);
      Application.ThreadException += OnThreadException;
      if (PrimeraInstancia)
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
      }
      else
      {
        MessageBox.Show("La aplicación ya se está ejecutando");
        Application.Exit();
      }
    }

    private static void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
      System.Diagnostics.Debug.WriteLine(e.Exception.Message);
      // Tratamiento de la excepción
      Application.Exit();
    }

    private static bool PrimeraInstancia
    {
      get
      {
        // Verificar si ya existe una instancia de la aplicación
        System.Threading.Mutex exmut;
        string nombre_exmut = "ApWinForms";
        bool nueva;
        exmut = new System.Threading.Mutex(true, nombre_exmut, out nueva);
        return nueva;
      }
    }

    private static void OnApplicationExit(object sender, EventArgs e)
    {
      System.Diagnostics.Debug.WriteLine("OnApplicationExit");
    }
  }
}
