using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaestroDetalle
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dsTitulos.Clear();
      sqldaTitulos.Fill(dsTitulos);
    }

    private void titulosDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        dsTemas.Clear();
        DataRowView fila = titulosBindingSource[e.RowIndex] as DataRowView;
        if (fila.IsNew) return;
        int id = (int)fila["id_tema"];
        sqldaTemas.SelectCommand.Parameters["@IDTema"].Value = id;
        sqldaTemas.Fill(dsTemas, "temas");
      }
      catch (Exception exc)
      {
        // Puede ser que ya hay un DataReader abierto asociado a este Command
        System.Diagnostics.Debug.WriteLine("Error: " + exc.Message);
      }
    }
  }
}
