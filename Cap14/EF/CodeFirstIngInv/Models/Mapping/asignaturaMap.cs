using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstIngInv.Models.Mapping
{
    public class asignaturaMap : EntityTypeConfiguration<asignatura>
    {
        public asignaturaMap()
        {
            // Primary Key
            this.HasKey(t => t.id_asignatura);

            // Properties
            // Table & Column Mappings
            this.ToTable("asignaturas");
            this.Property(t => t.id_asignatura).HasColumnName("id_asignatura");
            this.Property(t => t.nombre).HasColumnName("nombre");
        }
    }
}
