using System;
using System.Collections.Generic;

namespace CodeFirstIngInv.Models
{
  public partial class asignatura
  {
    public asignatura()
    {
      this.alums_asigs = new List<alums_asigs>();
    }

    public int id_asignatura { get; set; }
    public string nombre { get; set; }
    public virtual ICollection<alums_asigs> alums_asigs { get; set; }
  }
}
