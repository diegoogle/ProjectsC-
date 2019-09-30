using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
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
      etMsj.Text = "";
      // Colección columna-valor para el método Insert
      ListDictionary nuevaFila = new ListDictionary();
      // Valores de la fila
      nuevaFila.Add("id_alumno", DropDownList1.SelectedValue);
      nuevaFila.Add("id_asignatura", DropDownList2.SelectedValue);
      nuevaFila.Add("nota", 0.0F);
      // Insertar la fila en alums_asigs
      EntityDataSource3.Insert(nuevaFila);
      etMsj.Text = "Matrícula realizada.";
    }
    catch (Exception exc)
    {
      string msjError = "Ya está matriculado/a en esta asignatura " +
                        "(clave duplicada)";
      etMsj.Text = msjError;
    }
    //try
    //{
    //  etMsj.Text = "";
    //  // Insertar la fila en alums_asigs
    //  EntityDataSource3.Insert();
    //  etMsj.Text = "Matrícula realizada.";
    //}
    //catch (Exception exc)
    //{
    //  string msjError = "Ya está matriculado en esta asignatura " +
    //                    "(clave duplicada)";
    //  etMsj.Text = msjError;
    //}
  }

  protected void EntityDataSource3_Inserting(object sender, EntityDataSourceChangingEventArgs e)
  {
    //// Nueva entidad alums_asigs
    //var nuevo = e.Entity as alum_asig;
    //nuevo.id_alumno = Convert.ToInt32(DropDownList1.SelectedValue);
    //nuevo.id_asignatura = Convert.ToInt32(DropDownList2.SelectedValue);
    //nuevo.nota = 0.0F;
    //// Establecer las relaciones con idAlum e idAsig
    //int idAlum = Convert.ToInt32(DropDownList1.SelectedValue);
    //int idAsig = Convert.ToInt32(DropDownList2.SelectedValue);
    //// Establecer referencias
    //object alum;
    //e.Context.TryGetObjectByKey(new System.Data.EntityKey(
    //    "bd_notasAlumnosEntities.alumnos", "id_alumno", idAlum), out alum);
    //nuevo.alumno = (alumno)alum;
    //object asig;
    //e.Context.TryGetObjectByKey(new System.Data.EntityKey(
    //    "bd_notasAlumnosEntities.asignaturas", "id_asignatura", idAsig), out asig);
    //nuevo.asignatura = (asignatura)asig;
  }
}
