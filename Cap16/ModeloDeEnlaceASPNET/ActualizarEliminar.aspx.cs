using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ActualizarEliminar : System.Web.UI.Page
{
    protected void Page_Error(object sender, EventArgs e)
    {
      Exception objError = Server.GetLastError().GetBaseException();

      string mensajeError = "<h3>Error: </h3><hr><br>" +
        objError.Message.ToString() +
        "<br><br><a href='ActualizarEliminar.aspx'>Volver</a>";
      Response.Write(mensajeError.ToString());
      Server.ClearError();
    }

    public IQueryable<alum_asig> ObtenerNotas()
    {
      bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
      var consulta = bd.alums_asigs;
      return consulta;
    }

    public void ModificarNota(int id_alumno, int id_asignatura)
    {
      using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
      {
        alum_asig objAlAs = null;
        // Cargar el elemento
        objAlAs = bd.alums_asigs.Find(id_alumno, id_asignatura);
        if (objAlAs == null) return;
        TryUpdateModel(objAlAs);
        if (ModelState.IsValid)
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
        var objAlAs = new alum_asig { id_alumno = id_alumno,
                                      id_asignatura = id_asignatura};
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

    public void ModificarAlumno(int id_alumno)
    {
      using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
      {
        // Cargar el elemento
        alumno objAlum = bd.alumnos.Find(id_alumno);
        if (objAlum == null) return;
        TryUpdateModel(objAlum);
        if (ModelState.IsValid)
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

    public IQueryable<asignatura> ObtenerAsignaturas()
    {
      bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto();
      var consulta = bd.asignaturas;
      return consulta;
    }

    public void ModificarAsignatura(int id_asignatura)
    {
      using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
      {
        // Cargar el elemento
        asignatura objAsig = bd.asignaturas.Find(id_asignatura);
        if (objAsig == null) return;
        TryUpdateModel(objAsig);
        if (ModelState.IsValid)
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
}