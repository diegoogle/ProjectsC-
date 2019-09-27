using System;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data;

namespace AccesoConectado
{
  public partial class Form1 : Form
  {
    private DbConnection ConexionConBD = null;
    private DbCommand OrdenSql;
    private DbDataReader Lector;
    private string sProveedorBd;
    private string strConexion;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Obtener datos de configuración
      sProveedorBd = ConfigurationManager.ConnectionStrings["cc"].ProviderName;
      strConexion = ConfigurationManager.ConnectionStrings["cc"].ConnectionString;
      // Crear la conexión
      ConexionConBD = Factoria.CrearDbConnection(sProveedorBd, strConexion);
    }

    private void btMostrarDatos_Click(object sender, EventArgs e)
    {
      using (ConexionConBD)
      {
        // Crear una consulta
        string Consulta = "SELECT nombre, telefono FROM telefonos";
        OrdenSql = Factoria.CrearDbCommand(ConexionConBD, Consulta);
        // Abrir la conexión con la base de datos
        ConexionConBD.Open();

        //// ExecuteReader hace la consulta y devuelve un DbDataReader
        //Lector = OrdenSql.ExecuteReader();
        //// Llamar siempre a Read antes de acceder a los datos
        //while (Lector.Read()) // siguiente registro
        //{
        //  lsTfnos.Items.Add(Lector["nombre"] + " " +
        //                    Lector["telefono"]);
        //}
        //// Llamar siempre a Close una vez finalizada la lectura
        //Lector.Close();

        // Crear y configurar un objeto DbDataAdapter
        DbDataAdapter da = Factoria.CrearDbDataAdapter(sProveedorBd, OrdenSql);
        // Crear un DataSet y llenarlo con el resultado de la consulta
        DataSet ds = new DataSet();
        da.Fill(ds, "telefonos");
        lsTfnos.DisplayMember = "nombre";
        lsTfnos.ValueMember = "telefono";
        lsTfnos.DataSource = ds.Tables["telefonos"];
      }
      btMostrarDatos.Enabled = false;
    }

    private void lsTfnos_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lsTfnos.SelectedValue == null) return;
      MessageBox.Show(lsTfnos.SelectedValue.ToString());
    }
  }
}
