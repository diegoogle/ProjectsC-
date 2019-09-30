using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IniciarBaseDedatos
/// </summary>
public class IniciarBaseDeDatos : DropCreateDatabaseIfModelChanges<ContextoTutorias>
{
  protected override void Seed(ContextoTutorias contexto)
  {
    ObtenerProfesores().ForEach(prof => contexto.profesores.Add(prof));
  }

  private static List<profesor> ObtenerProfesores()
  {
    var profs = new List<profesor>
    {
      new profesor
      {
          id_profesor = 1,
          nombre = "Fco. Javier Ceballos Sierra"
      },
      new profesor
      {
          id_profesor = 2,
          nombre = "Inmaculada Rodríguez Santiago"
      },
      new profesor
      {
          id_profesor = 3,
          nombre = "Concha Batanero Ochaita"
      },
      new profesor
      {
          id_profesor = 4,
          nombre = "María del Mar Lendínez"
      },
      new profesor
      {
          id_profesor = 5,
          nombre = "Martín Knoblauch Revuelta"
      }
    };
    return profs;
  }
}