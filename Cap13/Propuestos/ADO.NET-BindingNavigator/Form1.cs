using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADO.NET
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void telefonosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.telefonosBindingSource.EndEdit();
      this.telefonosTableAdapter.Update(this.dsTelefonos.telefonos);

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dsTelefonos.telefonos' table. You can move, or remove it, as needed.
      this.telefonosTableAdapter.Fill(this.dsTelefonos.telefonos);

    }

    private void btbarBuscar_Click(object sender, EventArgs e)
    {
      string buscar = "";
      DlgBuscar dlgBuscar = new DlgBuscar();
      if (dlgBuscar.ShowDialog() == DialogResult.OK)
        buscar = dlgBuscar.ctBuscar.Text;
      if (buscar.Length != 0) Buscar(buscar);
    }

    private void Buscar(string str)
    {
      DataTable miTabla = dsTelefonos.telefonos;
      DataRowCollection cfilas = miTabla.Rows;
      DataRow[] filaBuscada; // matriz de filas
      string NL = Environment.NewLine;
      // Buscar en la columna Nombre de cada fila
      string criterio = "Nombre Like '*" + str + "*'";

      // Utilizar el método Select para encontrar todas las filas que
      // pasen el filtro y almacenarlas en la matriz filaBuscada
      filaBuscada = miTabla.Select(criterio);
      if (filaBuscada.GetUpperBound(0) == -1)
      {
        MessageBox.Show("No se encontraron registros coincidentes", "Buscar");
        return;
      }

      // Seleccionar de las filas encontradas la que buscamos
      int i, j;
      for (i = 0; i <= filaBuscada.GetUpperBound(0); i++)
      {
        if (MessageBox.Show("¿Es este el nombre buscado?" + NL + filaBuscada[i][0] + NL,
                            "Buscar", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          // Si: mostrar en el formulario la fila seleccionada
          for (j = 0; j <= cfilas.Count - 1; j++)
            if (cfilas[j].Equals(filaBuscada[i]))
              telefonosBindingSource.Position = j;
          break;
        }
      }
    }
  }
}