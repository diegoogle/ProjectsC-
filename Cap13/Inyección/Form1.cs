using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccesoConectado
{
  public partial class Form1 : Form
  {
    private SqlConnection ConexionConBD = null;
    private SqlCommand OrdenSql;
    private SqlDataReader Lector;
    private string strConexion = null;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Crear la cadena de conexión
      strConexion = "Data Source=.\\sqlexpress;" +
        "Initial Catalog=bd_telefonos; Integrated Security=True";
    }

    private void btMostrarDatos_Click(object sender, EventArgs e)
    {
      using (ConexionConBD = new SqlConnection(strConexion))
      {
        // Crear una consulta
        //string Consulta = "SELECT nombre, telefono FROM telefonos " +
        //                  "WHERE telefono LIKE '" + ctSql.Text.Replace("'", "''") + "'";

        // Órdenes parametrizadas
        //string Consulta = "SELECT nombre, telefono FROM telefonos " +
        //                  "WHERE telefono LIKE @prefijo";
        //OrdenSql = new SqlCommand(Consulta, ConexionConBD);
        //OrdenSql.Parameters.AddWithValue("@prefijo", ctSql.Text);
        // Otra forma:
        //OrdenSql.Parameters.Add("@prefijo", SqlDbType.VarChar);
        //OrdenSql.Parameters["@prefijo"].Value = ctSql.Text;

        // Procedimiento almacenado
        OrdenSql = new SqlCommand("stproObtenerTfnos", ConexionConBD);
        OrdenSql.CommandType = CommandType.StoredProcedure;
        OrdenSql.Parameters.AddWithValue("@prefijo", ctSql.Text);

        // Abrir la conexión con la base de datos
        ConexionConBD.Open();
        // ExecuteReader hace la consulta y devuelve un SqlDataReader
        Lector = OrdenSql.ExecuteReader();
        // Limpiar la lista
        lsTfnos.Items.Clear();
        // Llamar siempre a Read antes de acceder a los datos
        while (Lector.Read()) // siguiente registro
        {
          lsTfnos.Items.Add(Lector["nombre"] + " " +
                            Lector["telefono"]);
        }
        // Llamar siempre a Close una vez finalizada la lectura
        Lector.Close();
      }
    }
  }
}
