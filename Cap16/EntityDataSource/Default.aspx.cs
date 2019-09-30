using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    etError.Text = "";
  }

  protected void btConsultarNota_Click(object sender, EventArgs e)
  {
    // Obtener datos de los controles del formulario
    int idAlum = Convert.ToInt32(ctDni.Text);
    int idAsig = Convert.ToInt32(lsdAsignatura.SelectedItem.Value);
    // Crear el contexto de objetos
    bd_notasAlumnosEntities contexObj = new bd_notasAlumnosEntities();
    // Consulta para obtener el nombre de idAlum y su nota en idAsig
    var consulta = from alum in contexObj.alumnos
                   from al_as in alum.alums_asigs
                   where al_as.id_alumno == idAlum &&
                         al_as.id_asignatura == idAsig
                   select new { alum.nombre, al_as.nota };
    try
    {
      // Ejecutar la consulta y obtener los datos
      if (consulta.Count() != 0)
      {
        foreach (var alum in consulta)
        {
          // Mostrar en la página el nombre y la nota
          etNombre.Text = "Nombre:  " + alum.nombre;
          etNota.Text = "Nota:  " + alum.nota;
          etError.Text = "";
        }
      }
      else
      {
        // El alumno buscado no se encontró
        etNombre.Text = "";
        etNota.Text = "";
        etError.Text = "Error: no está en acta";
      }
    }
    catch (Exception exc)
    {
      etError.Text = "Error: " + exc.Message;
    }
  }
}