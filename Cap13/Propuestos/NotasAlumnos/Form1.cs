using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotasAlumnos
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dsAlumnos.Clear();
      sqldaAlumnos.Fill(dsAlumnos);
    }

    private void listaDesAlumnos_SelectedIndexChanged(object sender, EventArgs e)
    {
      dsAsignaturasNotas.Clear();
      sqlSelectCommand2.Parameters["@IDAlumno"].Value = Convert.ToInt32(listaDesAlumnos.SelectedValue);
      sqldaAsignaturasNotas.Fill(dsAsignaturasNotas);
    }

    private void listaAsignaturasNotas_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listaAsignaturasNotas.SelectedIndex == -1) return;
      MessageBox.Show("Nota: " + listaAsignaturasNotas.SelectedValue);
    }
  }
}
