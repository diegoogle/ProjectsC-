using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ListView
{
  public class Tfno : TreeNode
  {
    internal string nombre;
    internal string dirección;
    internal long teléfono;
    internal bool casado;

    // Constructor: crea un nuevo objeto Tfno con los parámetros:
    // nombre, dirección, teléfono, casado
    public Tfno(string nom, string dir, long tfno, bool cas)
    {
      nombre = nom;
      dirección = dir;
      teléfono = tfno;
      casado = cas;
    }

    // Constructor: crea un nuevo objeto Tfno con los parámetros:
    // nombre, dirección, teléfono, casado, etiqueta, índice imagen
    // nodo no seleccionado, índice imagen nodo seleccionado
    public Tfno(string nom, string dir, long tfno, bool cas, string etiq, int img0, int img1)
      : base(etiq, img0, img1)
    {
      nombre = nom;
      dirección = dir;
      teléfono = tfno;
      casado = cas;
    }

    public override string ToString()
    {
      return nombre;
    }

    public string datosTfno()
    {
      string NL = Environment.NewLine;
      string estado;
      if (casado)
      {
        estado = "casado/a";
      }
      else
      {
        estado = "soltero/a";
      }
      return nombre + NL + dirección + NL + teléfono + NL + estado + NL;
    }
  }
}
