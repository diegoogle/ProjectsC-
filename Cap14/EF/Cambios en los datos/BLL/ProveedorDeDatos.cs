using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using BDNotasAlumnos;
using Equin.ApplicationFramework;

namespace ApEntidades
{
  public class ProveedorDeDatos
  {
    public BindingListView<alumno> ObtenerAlumnos()
    {
      using (bd_notasAlumnosEntities
             contextoDeObjs = new bd_notasAlumnosEntities())
      {
        BindingListView<alumno> vista;
        vista = new BindingListView<alumno>(contextoDeObjs.alumnos.ToList());
        return vista;
      }
    }

    public BindingListView<asignatura> ObtenerAsignaturas(int idAlumno)
    {
      using (bd_notasAlumnosEntities
             contextoDeObjs = new bd_notasAlumnosEntities())
      {
        var asigs =
          from al_as in contextoDeObjs.alums_asigs
          where al_as.id_alumno == idAlumno
          select al_as.asignatura;
        BindingListView<asignatura> vista;
        vista = new BindingListView<asignatura>(asigs.ToList());
        return vista;
      }
    }

    public BindingListView<alum_asig> ObtenerAlumAsig(int idAlumno, int idAsignatura)
    {
      using (bd_notasAlumnosEntities
             contextoDeObjs = new bd_notasAlumnosEntities())
      {
        var alumAsig =
          from al_as in contextoDeObjs.alums_asigs
          where al_as.id_alumno == idAlumno && al_as.id_asignatura == idAsignatura
          select al_as;
        BindingListView<alum_asig> vista;
        vista = new BindingListView<alum_asig>(alumAsig.ToList());
        return vista;
      }
    }

    public float ObtenerNota(int idAlumno, int idAsignatura)
    {
      using (bd_notasAlumnosEntities
             contextoDeObjs = new bd_notasAlumnosEntities())
      {
        var alumAsigs =
          from al_as in contextoDeObjs.alums_asigs
          where al_as.id_alumno == idAlumno && al_as.id_asignatura == idAsignatura
          select al_as.nota;
        return alumAsigs.First();
      }
    }

    public void ModificarNota(int idAlum, int idAsig, float notaAlum)
    {
      using (bd_notasAlumnosEntities
             contextoDeObjs = new bd_notasAlumnosEntities())
      {
        // Consulta para obtener la fila a modificar
        var consulta =
            from al_as in contextoDeObjs.alums_asigs
            where al_as.id_alumno == idAlum &&
                  al_as.id_asignatura == idAsig
            select al_as;

        if (consulta.Count() == 0)
        {
          MessageBox.Show("La consulta no contiene elementos");
          return;
        }

        // Ejecutar la consulta y cambiar los valores
        // de las columnas implicadas
        foreach (alum_asig al_as in consulta)
          al_as.nota = notaAlum;

        // Enviar los cambios a la base de datos
        try
        {
          contextoDeObjs.SaveChanges();
          MessageBox.Show("Cambios realizados");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.InnerException.Message);
        }
      }
    }

    public void AñadirAlumno(int idAlum, string nomAlum)
    {
      using (bd_notasAlumnosEntities contextoDeObjs =
             new bd_notasAlumnosEntities())
      {
        // Crear un nuevo objeto alumno
        alumno alum = new alumno()
        {
          id_alumno = idAlum,
          nombre = nomAlum
        };

        // Añadirlo al conjunto de entidades alumnos
        contextoDeObjs.alumnos.Add(alum);
        // O bien:
        //contextoDeObjs.Entry(alum).State = EntityState.Added;

        // Enviar los cambios a la base de datos
        try
        {
          contextoDeObjs.SaveChanges();
          MessageBox.Show("Cambios realizados");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.InnerException.Message);
        }
      }
    }

    public void AñadirAsignatura(int idAsig, string nomAsig)
    {
      using (bd_notasAlumnosEntities contextoDeObjs =
             new bd_notasAlumnosEntities())
      {
        // Crear una nueva asignatura
        asignatura asig = new asignatura()
        {
          id_asignatura = idAsig,
          nombre = nomAsig
        };

        // Añadirla al conjunto de entidades asignaturas
        contextoDeObjs.asignaturas.Add(asig);

        // Enviar los cambios a la base de datos
        try
        {
          contextoDeObjs.SaveChanges();
          MessageBox.Show("Cambios realizados");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.InnerException.Message);
        }
      }
    }

    public void AñadirAlumnoAsignatura(int idAlum, int idAsig)
    {
      using (bd_notasAlumnosEntities contextoDeObjs =
              new bd_notasAlumnosEntities())
      {
        // Consulta para obtener el alumno a matricular
        var consulta1 = from alum in contextoDeObjs.alumnos
                        where alum.id_alumno == idAlum
                        select alum;

        // Consulta para obtener la asignatura de la que se va a matricular
        var consulta2 = from asig in contextoDeObjs.asignaturas
                        where asig.id_asignatura == idAsig
                        select asig;

        if (consulta1.Count() == 0 || consulta2.Count() == 0)
        {
          MessageBox.Show("El alumno o la asignatura no existen");
          return;
        }
        alumno alumno = consulta1.First();
        asignatura asignatura = consulta2.First();

        // Crear un nuevo objeto alum_asig
        alum_asig al_as = new alum_asig()
        {
          id_alumno = idAlum,
          id_asignatura = idAsig,
          nota = 0.0F
        };

        // Establecer las relaciones
        al_as.alumno = alumno; // N:1
        al_as.asignatura = asignatura; // N:1
        // O bien:
        alumno.alums_asigs.Add(al_as);     // 1:N
        asignatura.alums_asigs.Add(al_as); // 1:N

        // Añadir el nuevo objeto al conjunto de entidades alums_asigs
        contextoDeObjs.alums_asigs.Add(al_as);

        // Enviar los cambios a la base de datos
        try
        {
          contextoDeObjs.SaveChanges();
          MessageBox.Show("Cambios realizados");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.InnerException.Message);
        }
      }
    }

    public void BorrarAlumno(int idAlum)
    {
      using (bd_notasAlumnosEntities contextoDeObjs =
             new bd_notasAlumnosEntities())
      {
        // Consulta para obtener los objetos secundarios de idAlum
        var consulta1 =
          from alum in contextoDeObjs.alums_asigs
          where alum.id_alumno == idAlum
          select alum;

        if (consulta1.Count() != 0)
        {
          foreach (var al_as in consulta1)
          {
            // Borrar los objetos secundarios
            contextoDeObjs.alums_asigs.Remove(al_as);
            // O bien:
            //contextoDeObjs.Set<alum_asig>().Remove(al_as);
            // O bien:
            //contextoDeObjs.Entry(al_as).State = EntityState.Deleted;
          }
        }

        // Consulta para obtener el objeto primario idAlum
        var consulta2 =
          from alum in contextoDeObjs.alumnos
          where alum.id_alumno == idAlum
          select alum;

        if (consulta2.Count() != 0)
        {
          foreach (var alum in consulta2)
          {
            // Borrar el objeto primario
            contextoDeObjs.alumnos.Remove(alum);
          }
        }

        if (consulta1.Count() == 0 && consulta2.Count() == 0)
        {
          MessageBox.Show("La consulta no contiene elementos");
          return;
        }
        // Enviar los cambios a la base de datos
        try
        {
          contextoDeObjs.SaveChanges();
          MessageBox.Show("Cambios realizados");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.InnerException.Message);
        }
      }
    }

    public void BorrarAsignatura(int idAsig)
    {
      using (bd_notasAlumnosEntities contextoDeObjs =
             new bd_notasAlumnosEntities())
      {
        // Consulta para obtener los objetos secundarios de idAsig
        var consulta1 =
          from asig in contextoDeObjs.alums_asigs
          where asig.id_asignatura == idAsig
          select asig;

        if (consulta1.Count() != 0)
        {
          foreach (var al_as in consulta1)
          {
            // Borrar los objetos secundarios
            contextoDeObjs.alums_asigs.Remove(al_as);
          }
        }

        // Consulta para obtener el objeto primario idAsig
        var consulta2 =
          from asig in contextoDeObjs.asignaturas
          where asig.id_asignatura == idAsig
          select asig;

        if (consulta2.Count() != 0)
        {
          foreach (var asig in consulta2)
          {
            // Borrar el objeto primario
            contextoDeObjs.asignaturas.Remove(asig);
          }
        }

        if (consulta1.Count() == 0 && consulta2.Count() == 0)
        {
          MessageBox.Show("La consulta no contiene elementos");
          return;
        }

        // Enviar los cambios a la base de datos
        try
        {
          contextoDeObjs.SaveChanges();
          MessageBox.Show("Cambios realizados");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.InnerException.Message);
        }
      }
    }

    public void TestConcurrencia(int idAlum, int idAsig)
    {
      using (bd_notasAlumnosEntities
             contexto1DeObjs = new bd_notasAlumnosEntities(),
             contexto2DeObjs = new bd_notasAlumnosEntities())
      {
        // SESIÓN 1: contexto1DeObjs
        // Consulta para obtener la fila a modificar
        var consulta1 =
            from al_as in contexto1DeObjs.alums_asigs
            where al_as.id_alumno == idAlum &&
                  al_as.id_asignatura == idAsig
            select al_as;

        // Ejecutar la consulta y cambiar la nota
        consulta1.First().nota = consulta1.First().nota + 0.5F;

        // SESIÓN 2: contexto2DeObjs
        // Obtener los datos: mismo alumno y misma asignatura
        // pero diferente nota

        // Consulta para obtener la fila a modificar
        var consulta2 =
            from al_as in contexto2DeObjs.alums_asigs
            where al_as.id_alumno == idAlum &&
                  al_as.id_asignatura == idAsig
            select al_as;

        // Ejecutar la consulta y cambiar la nota
        consulta2.First().nota = consulta2.First().nota + 0.75F;

        // SESIÓN 1: enviar los cambios a la base de datos
        bool errorSaveChanges;
        do
        {
          errorSaveChanges = false;
          try
          {
            contexto1DeObjs.SaveChanges();
          }
          catch (DbUpdateConcurrencyException ex)
          {
            errorSaveChanges = true;
            // Actualizar los valores de la entidad que falló
            // al salvar los cambios
            var objDbEntityEntry = ex.Entries.Single();
            objDbEntityEntry.Reload();

            // Actualizar los valores originales desde la base de datos
            //objDbEntityEntry.OriginalValues.SetValues(
            //                       objDbEntityEntry.GetDatabaseValues());
          }
        }
        while (errorSaveChanges);

        // SESIÓN 2: enviar los cambios a la base de datos
        do
        {
          errorSaveChanges = false;
          try
          {
            contexto2DeObjs.SaveChanges();
          }
          catch (DbUpdateConcurrencyException ex)
          {
            errorSaveChanges = true;
            // Actualizar los valores de la entidad que falló
            // al salvar los cambios
            var objDbEntityEntry = ex.Entries.Single();
            objDbEntityEntry.Reload();

            // Actualizar los valores originales desde la base de datos
            //objDbEntityEntry.OriginalValues.SetValues(
            //                       objDbEntityEntry.GetDatabaseValues());
          }
        }
        while (errorSaveChanges);
      }
    }

    public void TestEstadoEntidades(int idAlum, int idAsig)
    {
      using (bd_notasAlumnosEntities
             contextoDeObjs = new bd_notasAlumnosEntities())
      {
        // Consulta para obtener la fila a modificar
        var consulta1 =
            from al_as in contextoDeObjs.alums_asigs
            where al_as.id_alumno == idAlum &&
                  al_as.id_asignatura == idAsig
            select al_as;

        // Ejecutar la consulta y cambiar la nota
        consulta1.First().nota = consulta1.First().nota + 0.5F;
        // Entidades modificadas
        var entidadesModificadas =
          from objDbEntityEntry in contextoDeObjs.ChangeTracker.Entries()
          where objDbEntityEntry.State == EntityState.Modified
          select objDbEntityEntry;
        // Valores originales y actuales
        foreach (var objDbEE in entidadesModificadas)
        {
          string info =
            "Tipo del objeto de seguimiento: " + objDbEE.ToString() +
            "\nID alumno: " + (objDbEE.Entity as alum_asig).id_alumno +
            "\nID asignatura: " + (objDbEE.Entity as alum_asig).id_asignatura +
            "\nValores originales -> actuales:\n";
          DbPropertyValues actuales = objDbEE.CurrentValues;
          DbPropertyValues originales = objDbEE.OriginalValues;
          int c = actuales.PropertyNames.Count();
          for (int i = 0; i < c; i++)
          {
            string prop = actuales.PropertyNames.ElementAt(i);
            info += "\t" + originales.GetValue<object>(prop) + " -> " +
                    actuales.GetValue<object>(prop) + "\n";
          }
          MessageBox.Show(info);
        }
        // Salvar los cambios en la base de datos
        try
        {
          contextoDeObjs.SaveChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
    }
  }
}
