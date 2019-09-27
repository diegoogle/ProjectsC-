using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponentesADO.NET
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dataSet11.Clear();
      sqlDataAdapter1.Fill(dataSet11);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (dataSet11.HasChanges())
      {
        sqlDataAdapter1.Update(dataSet11);
        MessageBox.Show("Origen de datos actualizado");
      }
    }
  }
}
