using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.ModeloDeDatos
{
  [Table("asignaturas")]
  public class asignatura
  {
    public asignatura()
    {
      this.alums_asigs = new HashSet<alum_asig>();
    }
    // Propiedades correspondientes a las columnas de la tabla asociada
    [Key]
    public int id_asignatura { get; set; }
    public string nombre { get; set; }
    // Propiedades de navegación
    public virtual ICollection<alum_asig> alums_asigs { get; set; }
  }
}
