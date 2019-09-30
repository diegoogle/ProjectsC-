using System;
using System.Collections.Generic;

namespace CodeFirstIngInv.Models
{
  public partial class alums_asigs
  {
    public int id { get; set; }
    public int id_alumno { get; set; }
    public int id_asignatura { get; set; }
    public float nota { get; set; }
    public virtual alumno alumno { get; set; }
    public virtual asignatura asignatura { get; set; }
  }
}
