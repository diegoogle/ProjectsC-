using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

/// <summary>
/// Descripción breve de GestionAlumsAsigs
/// </summary>
public class GestionAlumsAsigs
{
  public IQueryable<alum_asig> ObtenerNotas()
  {
    bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
    var consulta = bd.alums_asigs;
    return consulta;
  }

  public void ModificarNota(int id_alumno, int id_asignatura, ModelMethodContext mmc)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      alum_asig objAlAs = null;
      // Cargar el elemento
      objAlAs = bd.alums_asigs.Find(id_alumno, id_asignatura);
      if (objAlAs == null) return;
      mmc.TryUpdateModel(objAlAs);
      if (mmc.ModelState.IsValid)
      {
        // Guardar los cambios
        bd.SaveChanges();
      }
    }
  }

  public void BorrarNota(int id_alumno, int id_asignatura)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      var objAlAs = new alum_asig
      {
        id_alumno = id_alumno,
        id_asignatura = id_asignatura
      };
      bd.Entry(objAlAs).State = System.Data.EntityState.Deleted;
      bd.SaveChanges(); // Si error ==> Page_Error
    }
  }

  public IQueryable<alumno> ObtenerAlumnos()
  {
    bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
    var consulta = bd.alumnos;
    return consulta;
  }

  public void ModificarAlumno(int id_alumno, ModelMethodContext mmc)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      // Cargar el elemento
      alumno objAlum = bd.alumnos.Find(id_alumno);
      if (objAlum == null) return;
      mmc.TryUpdateModel(objAlum);
      if (mmc.ModelState.IsValid)
      {
        // Guardar los cambios
        bd.SaveChanges();
      }
    }
  }

  public void BorrarAlumno(int id_alumno)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      var objAsig = new alumno { id_alumno = id_alumno };
      bd.Entry(objAsig).State = System.Data.EntityState.Deleted;
      bd.SaveChanges(); // Si error ==> Page_Error
    }
  }

  public void InsertarAlumno(ModelMethodContext mmc)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      var objAlumno = new alumno();
      mmc.TryUpdateModel(objAlumno);
      if (mmc.ModelState.IsValid)
      {
        // Guardar los cambios
        bd.alumnos.Add(objAlumno);
        bd.SaveChanges();
      }
    }
  }

  public IQueryable<asignatura> ObtenerAsignaturas()
  {
    bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
    var consulta = bd.asignaturas;
    return consulta;
  }

  public void ModificarAsignatura(int id_asignatura, ModelMethodContext mmc)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      // Cargar el elemento
      asignatura objAsig = bd.asignaturas.Find(id_asignatura);
      if (objAsig == null) return;
      mmc.TryUpdateModel(objAsig);
      if (mmc.ModelState.IsValid)
      {
        // Guardar los cambios
        bd.SaveChanges();
      }
    }
  }

  public void BorrarAsignatura(int id_asignatura)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      var objAsig = new asignatura { id_asignatura = id_asignatura };
      bd.Entry(objAsig).State = System.Data.EntityState.Deleted;
      bd.SaveChanges(); // Si error ==> Page_Error
    }
  }

  public void InsertarAsignatura(ModelMethodContext mmc)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      var objAsignatura = new asignatura();
      mmc.TryUpdateModel(objAsignatura);
      if (mmc.ModelState.IsValid)
      {
        // Guardar los cambios
        bd.asignaturas.Add(objAsignatura);
        bd.SaveChanges();
      }
    }
  }

  public object ObtenerNota([Control("ctDni", "Text")] int? idAlum, [Control("lsdAsignatura", "SelectedValue")] int? idAsig)
  {
    if (!idAlum.HasValue || !idAsig.HasValue) return null;
    bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
    // Consulta para obtener el nombre de idAlum y su nota en idAsig
    var consulta = from alum in bd.alumnos
                   from al_as in alum.alums_asigs
                   where al_as.id_alumno == idAlum &&
                         al_as.id_asignatura == idAsig
                   select new { alum.nombre, al_as.nota };
    return consulta.ToList();
  }
}