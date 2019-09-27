using System.ComponentModel;

namespace EnlaceDatosManual
{
  class CTelefono : INotifyPropertyChanged
  {
    private string _nombre = "Un nombre";
    private string _telefono = "000000000";

    public event PropertyChangedEventHandler PropertyChanged;

    private void NotificarCambio(string nombreProp)
    {
      if (this.PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(nombreProp));
    }

    public string Nombre
    {
      get { return _nombre; }
      set
      {
        _nombre = value;
        NotificarCambio("Nombre");
      }
    }

    public string Telefono
    {
      get { return _telefono; }
      set
      {
        _telefono = value;
        NotificarCambio("Telefono");
      }
    }
  }
}
