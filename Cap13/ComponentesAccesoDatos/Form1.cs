using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesAccesoDatos
{
  public partial class Form1 : Form
  {
    private CTelefonoBLL bd = new CTelefonoBLL();
    private ColCTelefonos coTfnos;
    private string tfnoAntesDeModificar;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        // Origen de datos
        coTfnos = bd.ObtenerFilasTfnos();
        colCTelefonosBindingSource.DataSource = coTfnos;
      }
      catch (System.Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void dgTelefonos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
      DataGridView dg = sender as DataGridView;
      if (dg.Rows.Count == 0) return;
      bd.BorrarFilaTfnos(e.Row.Cells[1].Value.ToString());
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      for (int i = 0; i < coTfnos.Count; i++)
      {
        if (coTfnos[i].Modificado)
        {
          // Insertar
          if (bd.ObtenerFilaTfnos(coTfnos[i].Telefono) == null)
            bd.InsertarFilaTfnos(coTfnos[i]);
          // Actualizar
          else
            bd.ActualizarNomDirObs(coTfnos[i]);
        }
      }
    }

    private void dgTelefonos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
      DataGridView dg = sender as DataGridView;
      if (dg.CurrentCell.Value == null) return;
      if (e.ColumnIndex == 1)
        tfnoAntesDeModificar = dg.CurrentCell.Value.ToString();
    }

    private void dgTelefonos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dg = sender as DataGridView;
      if (tfnoAntesDeModificar == null) return;
      if (tfnoAntesDeModificar != dg.CurrentCell.Value.ToString())
      {
        if (bd.ObtenerFilaTfnos(tfnoAntesDeModificar) != null)
          bd.BorrarFilaTfnos(tfnoAntesDeModificar);
      }
      tfnoAntesDeModificar = null;
    }
  }
}
