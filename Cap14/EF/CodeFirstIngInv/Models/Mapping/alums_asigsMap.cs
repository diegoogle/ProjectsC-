using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstIngInv.Models.Mapping
{
    public class alums_asigsMap : EntityTypeConfiguration<alums_asigs>
    {
        public alums_asigsMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("alums_asigs");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.id_alumno).HasColumnName("id_alumno");
            this.Property(t => t.id_asignatura).HasColumnName("id_asignatura");
            this.Property(t => t.nota).HasColumnName("nota");

            // Relationships
            this.HasRequired(t => t.alumno)
                .WithMany(t => t.alums_asigs)
                .HasForeignKey(d => d.id_alumno);
            this.HasRequired(t => t.asignatura)
                .WithMany(t => t.alums_asigs)
                .HasForeignKey(d => d.id_asignatura);

        }
    }
}
