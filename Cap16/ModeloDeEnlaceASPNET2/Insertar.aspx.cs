using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Insertar : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    etMsj.Text = "";
  }

  protected void btMatricular_Click(object sender, EventArgs e)
  {
    try
    {
      int idAlum = Convert.ToInt32(lsdAlumnos.SelectedValue);
      int idAsig = Convert.ToInt32(lsdAsignaturas.SelectedValue);
      Matricular(idAlum, idAsig);
      etMsj.Text = "Matrícula realizada.";
    }
    catch (Exception exc)
    {
      string msjError = "Ya está matriculado/a en esta asignatura " +
                        "(clave duplicada)";
      etMsj.Text = msjError;
    }
  }

  public void Matricular(int idAlum, int idAsig)
  {
    using (bd_notasAlumnosContexto bd = new bd_notasAlumnosContexto())
    {
      // Alumno a matricular
      alumno alum = bd.alumnos.Find(idAlum);
      // Asignatura de la que se va a matricular
      asignatura asig = bd.asignaturas.Find(idAsig);

      if (alum == null || asig == null)
      {
        throw new Exception();
      }

      // Crear un nuevo objeto alum_asig
      alum_asig al_as = new alum_asig()
      {
        id_alumno = idAlum,
        id_asignatura = idAsig,
        nota = 0.0F
      };

      // Establecer las relaciones
      al_as.alumno = alum;     // N:1
      al_as.asignatura = asig; // N:1
      // Añadir el nuevo objeto al conjunto de entidades alums_asigs
      bd.alums_asigs.Add(al_as);

      // Enviar los cambios a la base de datos
      bd.SaveChanges();
    }
  }
  protected void DropDownList_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
  {
    e.DataMethodsObject = new GestionAlumsAsigs();
  }
}
