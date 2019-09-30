using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.ModeloDeDatos
{
  [Table("alums_asigs")]
  public class alum_asig
  {
    // Propiedades correspondientes a las columnas de la tabla asociada
    public int id { get; set; }
    public int id_alumno { get; set; }
    public int id_asignatura { get; set; }
    public float nota { get; set; }
    // Propiedades de navegación
    public virtual alumno alumno { get; set; }
    public virtual asignatura asignatura { get; set; }
  }
}
