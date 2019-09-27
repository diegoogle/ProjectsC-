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

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Crear la conexión
      string strConexion = "Data Source=.\\sqlexpress;" +
        "Initial Catalog=bd_telefonos; Integrated Security=True";
      ConexionConBD = new SqlConnection(strConexion);
    }

    private void btMostrarDatos_Click(object sender, EventArgs e)
    {
      using (ConexionConBD)
      {
        // Crear una consulta
        string Consulta = "SELECT nombre, telefono FROM telefonos";
        OrdenSql = new SqlCommand(Consulta, ConexionConBD);
        // Abrir la conexión con la base de datos
        ConexionConBD.Open();
        // ExecuteReader hace la consulta y devuelve un SqlDataReader
        Lector = OrdenSql.ExecuteReader();
        // Llamar siempre a Read antes de acceder a los datos
        while (Lector.Read()) // siguiente registro
        {
          lsTfnos.Items.Add(Lector["nombre"] + " " +
                            Lector["telefono"]);
        }
        // Llamar siempre a Close una vez finalizada la lectura
        Lector.Close();
      }
      btMostrarDatos.Enabled = false;
    }
  }
}
