using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TablaTfnos.BBDD;

namespace TablaTfnos
{
  public partial class Form1 : Form
  {
    private BindingListPersonas listFilas = null;

    public Form1()
    {
      InitializeComponent();
      TablaTfnos.AutoGenerateColumns = false;
      listFilas = bbdd.ObtenerDatos();
      TablaTfnos.DataSource = listFilas;
    }

    private void TablaTfnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      // Si fila nueva, volver para introducir los datos en la tabla.
      if (e.RowIndex > listFilas.Count - 1) return;
      // Construir la tabla con los datos de la colección.
      switch (this.TablaTfnos.Columns[e.ColumnIndex].Name)
      {
        case "colFoto":
          if (e.Value != null) // valor de la celda
            try
            {
              e.Value = Image.FromFile(listFilas[e.RowIndex].foto);
            }
            catch (System.IO.FileNotFoundException exc)
            {
              e.Value = null;
            }
          break;
      }
    }

    private void TablaTfnos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      object valorCelda = TablaTfnos.CurrentCell.Value;
      if (valorCelda != null) MessageBox.Show(valorCelda.ToString());
    }
  }
}
