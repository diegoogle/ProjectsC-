using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ApWinForms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      try
      {
        // Restaurar el estado desde los atributos del objeto
        // de la clase Settings referenciado por Default
        Rectangle restoreBounds =
          Properties.Settings.Default.MainRestoreBounds;
        Left = restoreBounds.Left;
        Top = restoreBounds.Top;
        Width = restoreBounds.Width;
        Height = restoreBounds.Height;
        WindowState = Properties.Settings.Default.MainWindowState;

        // Recursos
        this.Text = Properties.Resources.TituloAplicacion;
        // Atributos globales
        object[] atributos = Assembly.GetExecutingAssembly().
            GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        string titulo = ((AssemblyTitleAttribute)atributos[0]).Title;
      }
      catch
      {
        System.Diagnostics.Debug.WriteLine("Error: no se pudo restaurar el estado del formulario principal.");
      }
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      System.Diagnostics.Debug.WriteLine("Evento Shown");
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
      System.Diagnostics.Debug.WriteLine("Evento Activated");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      System.Diagnostics.Debug.WriteLine("Evento Load");
    }

    private void Form1_Deactivate(object sender, EventArgs e)
    {
      System.Diagnostics.Debug.WriteLine("Evento Deactivate");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      // Guardar el estado desde los atributos
      if (this.WindowState == FormWindowState.Normal)
        Properties.Settings.Default.MainRestoreBounds = this.DesktopBounds;
      else
        Properties.Settings.Default.MainRestoreBounds = RestoreBounds;
      Properties.Settings.Default.MainWindowState = WindowState;
      Properties.Settings.Default.Save();
    }
  }
}
