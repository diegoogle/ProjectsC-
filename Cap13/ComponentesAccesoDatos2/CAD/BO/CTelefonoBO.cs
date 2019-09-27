using System.ComponentModel;

namespace ComponentesAccesoDatos
{
  public delegate void ItemEditEventHandler(IEditableObject sender);
  
  class CTelefonoBO : INotifyPropertyChanged, IEditableObject
  {
    private string _nombre;
    public string Nombre
    {
      get { return _nombre; }
      set
      {
        _nombre = value;
        OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
      }
    }

    private string _direccion;
    public string Direccion
    {
      get { return _direccion; }
      set
      {
        _direccion = value;
        OnPropertyChanged(new PropertyChangedEventArgs("Direccion"));
      }
    }

    private string _telefono;
    public string Telefono
    {
      get { return _telefono; }
      set
      {
        _telefono = value;
        OnPropertyChanged(new PropertyChangedEventArgs("Telefono"));
      }
    }

    private string _observaciones;
    public string Observaciones
    {
      get { return _observaciones; }
      set
      {
        _observaciones = value;
        OnPropertyChanged(new PropertyChangedEventArgs("Observaciones"));
      }
    }

    public CTelefonoBO() {}
    public CTelefonoBO(string nom, string dir, string tel, string obs = null)
    {
      Nombre = nom; Direccion = dir; Telefono = tel; Observaciones = obs;
    }

    private bool _modificado;
    public bool Modificado
    {
      get { return _modificado; }
      set { _modificado = value; }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(PropertyChangedEventArgs e)
    {
      if (PropertyChanged != null)
      {
        _modificado = true;
        PropertyChanged(this, e); // generar evento
      }
    }

    // Eventos ItemBeginEdit e ItemEndEdit
    public event ItemEditEventHandler ItemBeginEdit;
    public event ItemEditEventHandler ItemEndEdit;

    // Copia para cuando se cancele la operación de edición
    private CTelefonoBO copia;
    private bool enEdicion = false;

    // Miembros de la interfaz IEditableObject
    void IEditableObject.BeginEdit()
    {
      if (enEdicion) return;
      enEdicion = true;

      copia = this.MemberwiseClone() as CTelefonoBO;

      if (ItemBeginEdit != null)
      {
        ItemBeginEdit(this); // generar evento
      }
    }

    void IEditableObject.CancelEdit()
    {
      if (!enEdicion) return;
      enEdicion = false;
      this.Nombre = copia.Nombre;
      this.Direccion = copia.Direccion;
      this.Telefono = copia.Telefono;
      this.Observaciones = copia.Observaciones;
      this.Modificado = copia.Modificado;
    }

    void IEditableObject.EndEdit()
    {
      if (!enEdicion) return;
      enEdicion = false;
      copia = null;

      if (ItemEndEdit != null)
      {
        ItemEndEdit(this); // generar evento
      }
    }
  }
}
