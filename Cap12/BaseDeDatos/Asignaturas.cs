using System.ComponentModel;

namespace BaseDeDatos
{
  public class Asignaturas
  {
    private string _tipo; // Obligatoria, Optativa
    public string Tipo
    {
      get { return _tipo; }
      set
      {
        _tipo = value;
      }
    }

    private BindingList<Asignatura> _listaAsignaturas;
    public BindingList<Asignatura> ListaAsignaturas
    {
      get { return _listaAsignaturas; }
      set
      {
        _listaAsignaturas = value;
      }
    }

    public Asignaturas()
    {
      Tipo = "";
      ListaAsignaturas = new BindingList<Asignatura>();
      ListaAsignaturas.Add(new Asignatura(-1, "¿Asignatura?", 0.0F));
    }

    public Asignaturas(string tipo, BindingList<Asignatura> lista)
    {
      Tipo = tipo;
      ListaAsignaturas = lista;
    }
  }
}
