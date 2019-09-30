using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de profesor
/// </summary>
namespace ModeloDeEnlace.ModeloDeDatos
{
  [Table("profesores")]
  public class profesor
  {
    // Propiedades correspondientes a las columnas de la tabla asociada
    [Key]
    public int id_profesor { get; set; }
    [Required]
    public string nombre { get; set; }
    [Required]
    public string apellidos { get; set; }
  }
}
