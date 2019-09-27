using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogicaAccesoDatos
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
      this.tableAdapterManager.UpdateAll(this.dsTelefonos);

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dsTelefonos.telefonos' Puede moverla o quitarla según sea necesario.
      this.telefonosTableAdapter.Fill(this.dsTelefonos.telefonos);

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (dsTelefonos.HasChanges())
      {
        telefonosTableAdapter.Update(dsTelefonos.telefonos);
      }
    }
  }
}
