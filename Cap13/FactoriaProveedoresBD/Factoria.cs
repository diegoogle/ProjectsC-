using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Configuration;
using System.Data;

public class Factoria
{
  public static DbConnection CrearDbConnection(string proveedor, string cadenaCon)
  {
    DbConnection con = null;

    // Crear DbProviderFactory y DbConnection
    if (cadenaCon != null)
    {
      try
      {
        DbProviderFactory factoria = DbProviderFactories.GetFactory(proveedor);
        con = factoria.CreateConnection();
        con.ConnectionString = cadenaCon;
      }
      catch (Exception ex)
      {
        con = null;
        Console.WriteLine(ex.Message);
      }
    }
    return con;
  }

  public static DbCommand CrearDbCommand(DbConnection con, string ordenSQL)
  {
    DbCommand ordenBd = null;
    if (con != null)
    {
      try
      {
        ordenBd = con.CreateCommand();
        ordenBd.CommandText = ordenSQL;
        ordenBd.CommandType = CommandType.Text;
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error: {0}", ex.Message);
      }
    }
    else
    {
      Console.WriteLine("Error: DbConnection es null");
    }
    return ordenBd;
  }

  public static DbDataAdapter CrearDbDataAdapter(string proveedor, DbCommand ordenSe)
  {
    DbDataAdapter adaptador = null;
    try
    {
      // Crear DbProviderFactory y DbConnection.
      DbProviderFactory factoria = DbProviderFactories.GetFactory(proveedor);
      // Crear el objeto DbDataAdapter
      adaptador = factoria.CreateDataAdapter();
      adaptador.SelectCommand = ordenSe;
      DbCommandBuilder cb = factoria.CreateCommandBuilder();
      // Objeto DbDataAdapter para el que se generan
      // automáticamente instrucciones SQL
      cb.DataAdapter = adaptador;
      adaptador.InsertCommand = cb.GetInsertCommand();
      adaptador.DeleteCommand = cb.GetDeleteCommand();
      adaptador.UpdateCommand = cb.GetUpdateCommand();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
    return adaptador;
  }
}
