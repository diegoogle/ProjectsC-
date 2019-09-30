using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    // Objeto conexión con la base de datos
    SqlConnection ConexionConBD = new SqlConnection();
    // Cadena de conexión (véase Web.config)
    ConexionConBD.ConnectionString = ConfigurationManager.
      ConnectionStrings["bd_notasAlumnosConnectionString"].
      ConnectionString;
    // Objeto orden SQL
    SqlCommand OrdenSQL = null;
    // Objeto lector de datos SQL
    SqlDataReader Lector = null;

    try
    {
      // Consulta para buscar el nombre y la nota del alumno "ctDni".
      string Consulta = "SELECT alumnos.nombre, alums_asigs.nota " +
        "FROM alumnos, asignaturas, alums_asigs " +
        "WHERE alumnos.id_alumno=" + Convert.ToInt32(ctDni.Text) +
        " AND asignaturas.id_asignatura=" +
              lsdAsignatura.SelectedItem.Value +
        " AND alumnos.id_alumno=alums_asigs.id_alumno" +
        " AND asignaturas.id_asignatura=alums_asigs.id_asignatura";

      OrdenSQL = new SqlCommand(Consulta, ConexionConBD);
      ConexionConBD.Open(); // abrir una conexión con la BD
      // Obtener los datos
      Lector = OrdenSQL.ExecuteReader();
      if (Lector.Read())
      {
        // Mostrar en la página el nombre y la nota
        etNombre.Text = "Nombre:  " + Lector["nombre"];
        etNota.Text = "Nota:  " + Lector["nota"];
        etError.Text = "";
      }
      else
      {
        // El alumno buscado no se encontró
        etNombre.Text = "";
        etNota.Text = "";
        etError.Text = "Error: no está en acta";
      }

      // Llamar siempre a Close una vez finalizada la lectura
      Lector.Close();
      Lector = null;
    }
    catch (System.IO.IOException exc)
    {
      etError.Text = "Error: " + exc.Message;
    }
    finally
    {
      // En cualquier caso, cerrar la conexión
      if (Lector != null) Lector.Close();
      if (ConexionConBD != null) ConexionConBD.Close();
    }
  }
}
