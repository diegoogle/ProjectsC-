using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity.Infrastructure;

/// <summary>
/// Capa BLL (lógica de negocio)
/// </summary>
public class telefonosBll
{
  public telefonosBll() { }

  public telefono ObtenerTfnoBll(string tf)
  {
    using (bd_telefonos3Entities contexto =
           new bd_telefonos3Entities())
    {
      var consulta = from tfno in contexto.telefonos
                     where tfno.telefono1 == tf
                     select tfno;
      if (consulta.Count() == 0) return null;
      telefono registro = consulta.First();
      //contexto.Detach(registro); // no es necesario; contexto de corta duración
      return registro;
    }
  }

  public List<Detalles> ObtenerTfnosBll()
  {
    using (bd_telefonos3Entities contexto =
           new bd_telefonos3Entities())
    {
      var consulta = from persona in contexto.telefonos
                     select new
                     {
                       persona.apellido1,
                       persona.telefono1
                     };
      List<Detalles> lista = new List<Detalles>();
      foreach (var e in consulta)
      {
        lista.Add(new Detalles(e.apellido1, e.telefono1));
      }
      return lista;
    }
  }

  public void ActualizarTfnoBll(telefono entidad)
  {
    using (bd_telefonos3Entities contexto = new bd_telefonos3Entities())
    {
      try
      {
        telefono actual = contexto.telefonos.Find(entidad.idpersona);
        if (actual != null) // si existe en el contexto...
        {
          contexto.Detach(actual);
          // Detach: método extensor en bd_telefonos3EntitiesEx
          // El estado de "entidad" es Detached
          contexto.telefonos.Attach(entidad);
          // Ahora, el estado de "entidad" es Unchanged
          contexto.Entry(entidad).State = EntityState.Modified;
          contexto.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        System.Diagnostics.Debug.WriteLine(ex.InnerException.Message);
      }
    }
  }

  public void AgregarTfnoBll(telefono entidad)
  {
    using (bd_telefonos3Entities contexto =
            new bd_telefonos3Entities())
    {
      if (ExisteTelefono(entidad, contexto) != null)
        throw new InvalidOperationException("El teléfono existe");
      contexto.telefonos.Add(entidad);
      try
      {
        contexto.SaveChanges();
      }
      catch (Exception ex)
      {
        System.Diagnostics.Debug.WriteLine(ex.InnerException.Message);
      }
    }
  }

  public void BorrarTfnoBll(telefono entidad)
  {
    using (bd_telefonos3Entities contexto =
            new bd_telefonos3Entities())
    {
      try
      {
        if ((entidad = ExisteTelefono(entidad, contexto)) == null)
          throw new InvalidOperationException("El teléfono no existe");
        contexto.telefonos.Remove(entidad);
        contexto.SaveChanges();
      }
      catch (DbUpdateConcurrencyException ex)
      {
        throw new InvalidOperationException(
          "El elemento especificado no puede ser borrado");
      }
    }
  }

  private telefono ExisteTelefono(telefono entidad,
  bd_telefonos3Entities contexto)
  {
    try
    {
      var consulta = from tfno in contexto.telefonos
                     where tfno.telefono1 == entidad.telefono1
                     select tfno;
      telefono registro = consulta.First();
      return registro;
    }
    catch (Exception)
    {
      return null;
    }
  }
}
