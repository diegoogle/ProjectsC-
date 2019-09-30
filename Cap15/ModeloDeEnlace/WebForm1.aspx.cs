using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using ModeloDeEnlace.ModeloDeDatos;

namespace ModeloDeEnlace
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (IsPostBack) return;
      using (var bd = new ContextoTutorias())
      {
        Database.SetInitializer<ContextoTutorias>(new IniciarBaseDeDatos());
      }
    }

    public IQueryable<profesor> ObtenerProfesores()
    {
      ContextoTutorias bd = new ContextoTutorias();
      var consulta = bd.profesores;
      return consulta;
    }

    // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
    public void ModificarProfesores(int id_profesor)
    {
      using (ContextoTutorias bd = new ContextoTutorias())
      {
        profesor objProfesor = null;
        // Cargar el elemento
        objProfesor = bd.profesores.Find(id_profesor);
        if (objProfesor == null)
        {
          // No se encontró el elemento
          ModelState.AddModelError("", String.Format("No se encontró el elemento con id. {0}", id_profesor));
          return;
        }
        TryUpdateModel(objProfesor);
        if (ModelState.IsValid)
        {
          // Guardar los cambios
          bd.SaveChanges();
        }
      }
    }

    // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
    public void BorrarProfesores(int id_profesor)
    {
      using (ContextoTutorias bd = new ContextoTutorias())
      {
        var objProfesor = new profesor { id_profesor = id_profesor };
        bd.Entry(objProfesor).State = System.Data.EntityState.Deleted;
        try
        {
          bd.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {
          ModelState.AddModelError("", String.Format("No se encontró el elemento con id. {0}", id_profesor));
        }
      }
    }

    public void InsertarProfesor()
    {
      using (ContextoTutorias bd = new ContextoTutorias())
      {
        var objProfesor = new profesor();
        TryUpdateModel(objProfesor);
        if (ModelState.IsValid)
        {
          // Guardar los cambios
          bd.profesores.Add(objProfesor);
          bd.SaveChanges();
          // Recargar el GridView
          gvProfes.DataBind();
        }
      }
    }
  }
}