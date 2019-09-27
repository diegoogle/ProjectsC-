using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDesconectado
{
  public partial class Form1 : Form
  {
    private SqlConnection ConexionConBD = null;
    private SqlCommand OrdenSql;

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

        // Crear y configurar un objeto SqlDataAdapter
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = OrdenSql;
        // Crear un DataSet y llenarlo con el resultado de la consulta
        DataSet ds = new DataSet();
        da.Fill(ds, "telefonos");
        // Configurar el ListBox para que muestre los datos
        lsTfnos.DisplayMember = "nombre";
        lsTfnos.ValueMember = "telefono";
        lsTfnos.DataSource = ds.Tables["telefonos"];
      }
      btMostrarDatos.Enabled = false;
    }

    private void lsTfnos_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lsTfnos.SelectedIndex < 0) return;
      MessageBox.Show(lsTfnos.SelectedValue.ToString());
    }
  }
}
