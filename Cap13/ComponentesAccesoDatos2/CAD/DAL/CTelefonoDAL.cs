using System;
using System.Data.SqlClient;
using System.Data;

namespace ComponentesAccesoDatos
{
  class CTelefonoDAL
  {
    private string strConexion;

    public CTelefonoDAL()
    {
      // Obtener la cadena de conexión
      strConexion = "Data Source=.\\sqlexpress;" +
        "Initial Catalog=bd_telefonos; Integrated Security=True";
    }

    public CTelefonoDAL(string strCon)
    {
      // Establecer la cadena de conexión especificada
      strConexion = strCon;
    }

    public CTelefonoBO ObtenerFilaTfnos(string tfno)
    {
      try
      {
        using (SqlConnection Conexion = new SqlConnection(strConexion))
        {
          SqlCommand OrdenSql = new SqlCommand("stproObtenerFilaTfnos", Conexion);
          OrdenSql.CommandType = CommandType.StoredProcedure;
          // Parámetros
          OrdenSql.Parameters.AddWithValue("@telefono", tfno);
          // Abrir la base de datos
          Conexion.Open();
          SqlDataReader lector = OrdenSql.ExecuteReader();
          if (lector.Read())
          {
            CTelefonoBO fila = new CTelefonoBO(
              (string)lector["nombre"], (string)lector["direccion"],
              (string)lector["telefono"], (string)lector["observaciones"]);
            return fila;
          }
          return null;
        }
      }
      catch (SqlException err)
      {
        throw new ApplicationException("Error SELECT telefonos por ID");
      }
    }

    public ColCTelefonos ObtenerFilasTfnos()
    {
      try
      {
        using (SqlConnection Conexion = new SqlConnection(strConexion))
        {
          SqlCommand OrdenSql = new SqlCommand("stproObtenerFilasTfnos", Conexion);
          OrdenSql.CommandType = CommandType.StoredProcedure;
          // Crear una colección para todos los teléfonos
          ColCTelefonos colTelefonos = new ColCTelefonos();
          // Abrir la base de datos
          Conexion.Open();
          SqlDataReader lector = OrdenSql.ExecuteReader();
          while (lector.Read())
          {
            CTelefonoBO fila = new CTelefonoBO(
              (string)lector["nombre"], (string)lector["direccion"],
              (string)lector["telefono"], (string)lector["observaciones"]);
            colTelefonos.Add(fila);
          }
          return colTelefonos;
        }
      }
      catch (SqlException err)
      {
        throw new ApplicationException("Error SELECT telefonos");
      }
    }

    public string InsertarFilaTfnos(CTelefonoBO bo)
    {
      try
      {
        using (SqlConnection Conexion = new SqlConnection(strConexion))
        {
          SqlCommand OrdenSql = new SqlCommand("stproInsertarFilaTfnos", Conexion);
          OrdenSql.CommandType = CommandType.StoredProcedure;
          // Parámetros
          OrdenSql.Parameters.AddWithValue("@nombre", bo.Nombre);
          OrdenSql.Parameters.AddWithValue("@direccion", bo.Direccion);
          OrdenSql.Parameters.AddWithValue("@telefono", bo.Telefono);
          OrdenSql.Parameters.AddWithValue("@observaciones", bo.Observaciones);
          // Abrir la base de datos
          Conexion.Open();
          OrdenSql.ExecuteNonQuery();
          return (string)OrdenSql.Parameters["@telefono"].Value;
        }
      }
      catch (SqlException err)
      {
        throw new ApplicationException("Error INSERT telefonos");
      }
    }

    public void BorrarFilaTfnos(string tfno)
    {
      try
      {
        using (SqlConnection Conexion = new SqlConnection(strConexion))
        {
          SqlCommand OrdenSql = new SqlCommand("stproBorrarFilaTfnos", Conexion);
          OrdenSql.CommandType = CommandType.StoredProcedure;
          // Parámetros
          OrdenSql.Parameters.AddWithValue("@telefono", tfno);
          // Abrir la base de datos
          Conexion.Open();
          OrdenSql.ExecuteNonQuery();
        }
      }
      catch (SqlException err)
      {
        throw new ApplicationException("Error DELETE telefonos");
      }
    }

    public void ActualizarNomDirTfnObs(CTelefonoBO bo, string tfnoAntiguo)
    {
      try
      {
        using (SqlConnection Conexion = new SqlConnection(strConexion))
        {
          SqlCommand OrdenSql =
            new SqlCommand("stproActualizarNomDirTfnObs", Conexion);
          OrdenSql.CommandType = CommandType.StoredProcedure;
          // Parámetros
          OrdenSql.Parameters.AddWithValue("@nombre", bo.Nombre);
          OrdenSql.Parameters.AddWithValue("@direccion", bo.Direccion);
          OrdenSql.Parameters.AddWithValue("@tfnoAntiguo", tfnoAntiguo);
          OrdenSql.Parameters.AddWithValue("@tfnoNuevo", bo.Telefono);
          OrdenSql.Parameters.AddWithValue("@observaciones",
            bo.Observaciones);
          // Abrir la base de datos
          Conexion.Open();
          OrdenSql.ExecuteNonQuery();
        }
      }
      catch (SqlException err)
      {
        throw new ApplicationException("Error INSERT telefonos");
      }
    }

    public void ActualizarNomDirObs(CTelefonoBO bo)
    {
      try
      {
        using (SqlConnection Conexion = new SqlConnection(strConexion))
        {
          SqlCommand OrdenSql = new SqlCommand("stproActualizarNomDirObs", Conexion);
          OrdenSql.CommandType = CommandType.StoredProcedure;
          // Parámetros
          OrdenSql.Parameters.AddWithValue("@nombre", bo.Nombre);
          OrdenSql.Parameters.AddWithValue("@direccion", bo.Direccion);
          OrdenSql.Parameters.AddWithValue("@telefono", bo.Telefono);
          OrdenSql.Parameters.AddWithValue("@observaciones", bo.Observaciones);
          // Abrir la base de datos
          Conexion.Open();
          OrdenSql.ExecuteNonQuery();
        }
      }
      catch (SqlException err)
      {
        throw new ApplicationException("Error INSERT telefonos");
      }
    }
  }
}
