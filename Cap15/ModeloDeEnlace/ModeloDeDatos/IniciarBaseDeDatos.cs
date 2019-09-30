using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IniciarBaseDedatos
/// </summary>
namespace ModeloDeEnlace.ModeloDeDatos
{
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
            nombre = "Fco. Javier",
            apellidos = "Ceballos Sierra"
        },
        new profesor
        {
            id_profesor = 2,
            nombre = "Inmaculada",
            apellidos = "Rodríguez Santiago"
        },
        new profesor
        {
            id_profesor = 3,
            nombre = "Concha",
            apellidos = "Batanero Ochaita"
        },
        new profesor
        {
            id_profesor = 4,
            nombre = "María del Mar",
            apellidos = "Lendínez Chica"
        },
        new profesor
        {
            id_profesor = 5,
            nombre = "Martín",
            apellidos = "Knoblauch Revuelta"
        }
      };
      return profs;
    }
  }
}