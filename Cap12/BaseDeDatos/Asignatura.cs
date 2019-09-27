using System.ComponentModel;

namespace BaseDeDatos
{
  public class Asignatura : INotifyPropertyChanged
  {
    private int _idAsignatura;
    public int IdAsignatura
    {
      get { return _idAsignatura; }
      set
      {
        _idAsignatura = value;
        OnPropertyChanged(new PropertyChangedEventArgs("IdAsignatura"));
      }
    }

    private string _nomAsignatura;
    public string NomAsignatura
    {
      get { return _nomAsignatura; }
      set
      {
        _nomAsignatura = value;
        OnPropertyChanged(new PropertyChangedEventArgs("NomAsignatura"));
      }
    }

    private float _nota;
    public float Nota
    {
      get { return _nota; }
      set
      {
        _nota = value;
        OnPropertyChanged(new PropertyChangedEventArgs("Nota"));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(PropertyChangedEventArgs e)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, e); // generar evento
    }

    public override string ToString()
    {
      return NomAsignatura;
    }

    public Asignatura() : this(-1, "", -1) {}

    public Asignatura(int id, string nomAsig, float nt)
    {
      IdAsignatura = id;
      NomAsignatura = nomAsig;
      Nota = nt;
    }
  }
}
