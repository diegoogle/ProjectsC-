using System.ComponentModel;

namespace BindingList
{
  class CTelefono : INotifyPropertyChanged
  {
    private string _nombre = "Un nombre";
    private decimal _telefono = 0;

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

    public decimal Telefono
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
