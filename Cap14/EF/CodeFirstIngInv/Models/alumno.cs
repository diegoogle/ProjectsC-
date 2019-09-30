using System;
using System.Collections.Generic;

namespace CodeFirstIngInv.Models
{
  public partial class alumno
  {
    public alumno()
    {
      this.alums_asigs = new List<alums_asigs>();
    }

    public int id_alumno { get; set; }
    public string nombre { get; set; }
    public virtual ICollection<alums_asigs> alums_asigs { get; set; }
  }
}
