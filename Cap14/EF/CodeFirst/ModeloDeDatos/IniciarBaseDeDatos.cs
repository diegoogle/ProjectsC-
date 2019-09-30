using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst.ModeloDeDatos
{
  class IniciarBaseDeDatos : DropCreateDatabaseIfModelChanges<ContextoNotasAlumnos>
  {
    protected override void Seed(ContextoNotasAlumnos contexto)
    {
      ObtenerAlumnos().ForEach(al => contexto.alumnos.Add(al));
      ObtenerAsignaturas().ForEach(asig => contexto.asignaturas.Add(asig));
      ObtenerNotas().ForEach(n => contexto.alums_asigs.Add(n));
    }

    private static List<alumno> ObtenerAlumnos()
    {
      var alums = new List<alumno>
      {
        new alumno
        {
            id_alumno = 1,
            nombre = "Alumno 01"
        },
        new alumno
        {
            id_alumno = 2,
            nombre = "Alumno 02"
        },
      };
      return alums;
    }


    private static List<asignatura> ObtenerAsignaturas()
    {
      var asigs = new List<asignatura>
      {
        new asignatura
        {
            id_asignatura = 1,
            nombre = "Asignatura 1"
        },
        new asignatura
        {
            id_asignatura = 2,
            nombre = "Asignatura 2"
        },
        new asignatura
        {
            id_asignatura = 3,
            nombre = "Asignatura 3"
        },
      };
      return asigs;
    }


    private static List<alum_asig> ObtenerNotas()
    {
      var notas = new List<alum_asig>
      {
        new alum_asig
        {
            id_alumno = 1,
            id_asignatura = 1,
            nota = 6.5F
        },
        new alum_asig
        {
            id_alumno = 1,
            id_asignatura = 2,
            nota = 8.0F
        },
        new alum_asig
        {
            id_alumno = 2,
            id_asignatura = 1,
            nota = 7.5F
        },
        new alum_asig
        {
            id_alumno = 2,
            id_asignatura = 3,
            nota = 4.0F
        },
      };
      return notas;
    }
  }
}
