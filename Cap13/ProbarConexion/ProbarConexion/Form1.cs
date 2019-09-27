using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProbarConexion
{
  public partial class Form1 : Form
  {
    SqlConnection con = null;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Crear la conexión
      string strConexion = "Data Source=.\\sqlexpress;" +
        "Initial Catalog=bd_telefonos; Integrated Security=True";
      con = new SqlConnection(strConexion);
    }

    private void btMostrarDatos_Click(object sender, EventArgs e)
    {
      try
      {
        // Probar a abrir la conexión
        con.Open();
        tbVersion.Text = "Versión del servidor: " + con.ServerVersion;
        tbEstadoConexion.Text = "La conexion está: ";
        tbEstadoConexion.Text += con.State.ToString();
        tbEstadoConexion.Text += "\nSe accede a la base de datos";
      }
      catch (Exception ex)
      {
        // Manipular la excepción
        tbEstadoConexion.Text = "Error al acceder a la base de datos. "
                                + ex.Message;
      }
      finally
      {
        // Asegurarse de que la conexión queda cerrada.
        // Aunque la conexión estuviera cerrada,
        // llamar a Close() no produce un error.
        con.Close();
        tbEstadoConexion.Text += "\nAhora la conexion está: " +
                                 con.State.ToString();
      }
    }
  }
}
