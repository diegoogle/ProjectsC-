using System.Windows.Forms;
using EditorMDI;
using Microsoft.VisualBasic.ApplicationServices;

namespace EditorMDI
{
  class Aplicacion : WindowsFormsApplicationBase
  {
    public Aplicacion()
    {
      // Asegurar que sólo habrá una instancia de la aplicación. 
      // Se lanza la excepción OnStartupNextInstance.
      this.IsSingleInstance = true;
    }

    protected override void OnCreateSplashScreen()
    {
      base.OnCreateSplashScreen();
      // Pantalla de presentación
      this.SplashScreen = new PantallaDePresentacion();
      this.MinimumSplashScreenDisplayTime = 2000;
    }

    protected override void OnCreateMainForm()
    {
      base.OnCreateMainForm();
      this.MainForm = new FormMDI();
    }
  }
}
