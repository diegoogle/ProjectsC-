using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstIngInv.Models.Mapping
{
    public class alumnoMap : EntityTypeConfiguration<alumno>
    {
        public alumnoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_alumno);

            // Properties
            // Table & Column Mappings
            this.ToTable("alumnos");
            this.Property(t => t.id_alumno).HasColumnName("id_alumno");
            this.Property(t => t.nombre).HasColumnName("nombre");
        }
    }
}
