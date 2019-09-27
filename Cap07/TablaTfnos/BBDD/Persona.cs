using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TablaTfnos.BBDD
{
  public class Persona
  {
    public string foto { get; set; }
    public string nombre { get; set; }
    public string direccion { get; set; }
    public string telefono { get; set; }
    public bool casado { get; set; }

    public Persona()
    {
      foto = null;
      nombre = "¿Nombre?";
      direccion = "¿Dirección?";
      telefono = "¿Telefono?";
      casado = false;
    }

    public Persona(string fot, string nom, string dir, string tel, bool cas)
    {
      foto = fot;
      nombre = nom;
      direccion = dir;
      telefono = tel;
      casado = cas;
    }
  }
}
