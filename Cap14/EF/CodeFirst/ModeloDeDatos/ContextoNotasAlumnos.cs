using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.ModeloDeDatos
{
  public class ContextoNotasAlumnos : DbContext
  {
    public ContextoNotasAlumnos()
      : base("name=ccBDNotasAlumnos")
    {
    }

    public DbSet<alumno> alumnos { get; set; }
    public DbSet<alum_asig> alums_asigs { get; set; }
    public DbSet<asignatura> asignaturas { get; set; }
  }
}
