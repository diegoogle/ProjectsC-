using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
  [Serializable()]
  public class Libro
  {
    private string sTitulo;
    private string sAutor;
    private string sEditorial;
    private string sPrestado;

    public Libro()
    {
    }

    public Libro(string título, string autor, string editorial, string prestado)
    {
      sTitulo = título;
      sAutor = autor;
      sEditorial = editorial;
      sPrestado = prestado;
    }

    public string ObtenerTitulo()
    {
      return sTitulo;
    }

    public void AsignarTitulo(string título)
    {
      sTitulo = título;
    }

    public string ObtenerAutor()
    {
      return sAutor;
    }

    public void AsignarAutor(string autor)
    {
      sAutor = autor;
    }

    public string ObtenerEditorial()
    {
      return sEditorial;
    }

    public void AsignarEditorial(string editorial)
    {
      sEditorial = editorial;
    }

    public string ObtenerPrestado()
    {
      return sPrestado;
    }

    public void AsignarPrestado(string prestado)
    {
      sPrestado = prestado;
    }

    public override string ToString()
    {
      return sTitulo;
    }
  }
}
