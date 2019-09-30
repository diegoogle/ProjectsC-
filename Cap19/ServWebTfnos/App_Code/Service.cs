using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
  public void Añadir_telefono(string nom, string dir,
                              string tel, string obs)
  {
    // Añadir un registro de la base de datos (BD)
    // Conexión
    // localhost\\sqlexpress?
    string cadenaDeConexión = "server=localhost\\sqlexpress;" +
               "database=bd_telefonos;Trusted_Connection=yes";
    SqlConnection conexión = new SqlConnection(cadenaDeConexión);

    // Orden SQL
    string sOrdenSQL =
      "INSERT INTO telefonos(nombre, direccion, telefono, observaciones) " +
      "VALUES(@NOMBRE, @DIRECCION, @TELEFONO, @OBSERVACIONES)";

    SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);
    ordenSQL.Parameters.AddWithValue("@NOMBRE", nom);
    ordenSQL.Parameters.AddWithValue("@DIRECCION", dir);
    ordenSQL.Parameters.AddWithValue("@TELEFONO", tel);
    ordenSQL.Parameters.AddWithValue("@OBSERVACIONES", obs);

    // Abrir una conexión con BD, ejecutar la orden SQL
    // y cerrar la conexión
    ordenSQL.Connection.Open();
    ordenSQL.ExecuteNonQuery();
    ordenSQL.Connection.Close();
  }

  public void Borrar_telefono(string tel)
  {
    // Borrar un registro de la base de datos (BD)
    // Conexión
    string cadenaDeConexión = "server=localhost\\sqlexpress;" +
               "database=bd_telefonos;Trusted_Connection=yes";
    SqlConnection conexión = new SqlConnection(cadenaDeConexión);

    // Orden SQL
    string sOrdenSQL = "DELETE FROM telefonos " +
                       "WHERE telefono = @TELEFONO";

    SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);
    ordenSQL.Parameters.AddWithValue("@TELEFONO", tel);
    // Abrir una conexión con BD, ejecutar la orden SQL y
    // cerrar la conexión
    ordenSQL.Connection.Open();
    ordenSQL.ExecuteNonQuery();
    ordenSQL.Connection.Close();
  }
}
