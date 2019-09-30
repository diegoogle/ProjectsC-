using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de bd_telefonos3EntitiesEx
/// </summary>
public static class bd_telefonos3EntitiesEx
{
  public static ObjectContext ObtenerObjectContext(this DbContext contex)
  {
    return (contex as IObjectContextAdapter).ObjectContext;
  }

  public static void Detach(this DbContext contex, object entity)
  {
    ObtenerObjectContext(contex).Detach(entity);
  }
}
