using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CodeFirstIngInv.Models.Mapping;

namespace CodeFirstIngInv.Models
{
  public partial class BDNotasAlumnosContext : DbContext
  {
    static BDNotasAlumnosContext()
    {
      Database.SetInitializer<BDNotasAlumnosContext>(null);
    }

    public BDNotasAlumnosContext()
      : base("Name=BDNotasAlumnosContext")
    {
    }

    public DbSet<alumno> alumnos { get; set; }
    public DbSet<alums_asigs> alums_asigs { get; set; }
    public DbSet<asignatura> asignaturas { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new alumnoMap());
      modelBuilder.Configurations.Add(new alums_asigsMap());
      modelBuilder.Configurations.Add(new asignaturaMap());
    }
  }
}
