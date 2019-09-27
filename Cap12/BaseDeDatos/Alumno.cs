using System.ComponentModel;
using System;

namespace BaseDeDatos
{
  public class Alumno : INotifyPropertyChanged
  {
    private int _idAlumno;
    public int IdAlumno
    {
      get { return _idAlumno; }
      set
      {
        if (bbdd.ObtenerAlumnoPorId(value) != null)
          throw new Exception("IdAlumno duplicado");
        _idAlumno = value;
        OnPropertyChanged(new PropertyChangedEventArgs("IdAlumno"));
      }
    }

    private string _nomAlumno;
    public string NomAlumno
    {
      get { return _nomAlumno; }
      set
      {
        _nomAlumno = value;
        OnPropertyChanged(new PropertyChangedEventArgs("NomAlumno"));
      }
    }

    private string _dirAlumno;
    public string DirAlumno
    {
      get { return _dirAlumno; }
      set
      {
        _dirAlumno = value;
        OnPropertyChanged(new PropertyChangedEventArgs("DirAlumno"));
      }
    }

    private string _estAlumno;
    public string EstAlumno
    {
      get { return _estAlumno; }
      set
      {
        _estAlumno = value;
        OnPropertyChanged(new PropertyChangedEventArgs("EstAlumno"));
      }
    }

    private bool _becaAlumno;
    public bool BecaAlumno
    {
      get { return _becaAlumno; }
      set
      {
        _becaAlumno = value;
        OnPropertyChanged(new PropertyChangedEventArgs("BecaAlumno"));
      }
    }

    private BindingList<Asignaturas> _listaCoAsignaturas;
    public BindingList<Asignaturas> ListaCoAsignaturas
    {
      get { return _listaCoAsignaturas; }
      set
      {
        _listaCoAsignaturas = value;
        OnPropertyChanged(new PropertyChangedEventArgs("ListaCoAsignaturas"));
      }
    }

    private BindingList<Asignatura> _listaAsigsObs;
    public BindingList<Asignatura> ListaAsigsObs
    {
      get
      {
        _listaAsigsObs = ObtenerAsigsObsOps("Obligatorias");
        return _listaAsigsObs;
      }
      set
      {
        _listaAsigsObs = value;
        OnPropertyChanged(new PropertyChangedEventArgs("ListaAsigsObs"));
      }
    }

    private BindingList<Asignatura> _listaAsigsOps;
    public BindingList<Asignatura> ListaAsigsOps
    {
      get
      {
        _listaAsigsOps = ObtenerAsigsObsOps("Optativas");
        return _listaAsigsOps;
      }
      set
      {
        _listaAsigsOps = value;
        OnPropertyChanged(new PropertyChangedEventArgs("ListaAsigsOps"));
      }
    }

    private BindingList<Asignatura> ObtenerAsigsObsOps(string tipo)
    {
      if (_listaCoAsignaturas != null)
        foreach (Asignaturas asigs in _listaCoAsignaturas)
          if (asigs.Tipo == tipo)
            return asigs.ListaAsignaturas;
      return null;
    }

    public Asignatura ObtenerAsignatura(int idAsig)
    {
      BindingList<Asignatura> colAsigs;
      // Obligatorias
      colAsigs = ListaAsigsObs;
      if (colAsigs != null)
        foreach (Asignatura asig in colAsigs)
          if (asig.IdAsignatura == idAsig) return asig;
      // Optativas
      colAsigs = ListaAsigsOps;
      if (colAsigs != null)
        foreach (Asignatura asig in colAsigs)
          if (asig.IdAsignatura == idAsig) return asig;
      return null;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(PropertyChangedEventArgs e)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, e); // generar evento
    }

    public override string ToString()
    {
      return NomAlumno;
    }

    public Alumno()
    {
      IdAlumno = 0;
      NomAlumno = "¿Nombre?";
      DirAlumno = "¿Dirección?";
      EstAlumno = "¿Estudios?";
      BecaAlumno = false;
      ListaCoAsignaturas = new BindingList<Asignaturas>();
      BindingList<Asignatura> asignaturas;
      // Obligatorias
      asignaturas = new BindingList<Asignatura>();
      asignaturas.Add(new Asignatura(-1, "¿Asignatura ob?", 0.0F));
      ListaCoAsignaturas.Add(new Asignaturas("Obligatorias", asignaturas));
      // Optativas
      asignaturas = new BindingList<Asignatura>();
      asignaturas.Add(new Asignatura(-1, "¿Asignatura op?", 0.0F));
      ListaCoAsignaturas.Add(new Asignaturas("Optativas", asignaturas));
    }

    public Alumno(int id, string nom, string dir, string est, bool beca, BindingList<Asignaturas> lista)
    {
      IdAlumno = id;
      NomAlumno = nom;
      DirAlumno = dir;
      EstAlumno = est;
      BecaAlumno = beca;
      ListaCoAsignaturas = lista;
    }
  }
}
