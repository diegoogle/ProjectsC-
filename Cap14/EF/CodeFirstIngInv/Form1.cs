using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirstIngInv.Models;

namespace CodeFirstIngInv
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      using (var bd = new BDNotasAlumnosContext())
      {
        var alumsAsigs =
          from al_as in bd.alums_asigs
          group new
          {
            nom_asig = al_as.asignatura.nombre,
            nota_asig = al_as.nota
          } by al_as.alumno.nombre;

        foreach (var grupo in alumsAsigs)
        {
          Label alum = new Label();
          alum.Width = flpLista.Width - 28;
          alum.Text = grupo.Key + ":";
          flpLista.Controls.Add(alum);
          foreach (var elem in grupo)
          {
            Label asigNota = new Label();
            asigNota.Width = flpLista.Width - 28;
            asigNota.Text = elem.nom_asig + ", " + elem.nota_asig;
            flpLista.Controls.Add(asigNota);
          }
        }
      }
    }
  }
}
