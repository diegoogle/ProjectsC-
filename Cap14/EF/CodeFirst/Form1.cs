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
using CodeFirst.ModeloDeDatos;

namespace CodeFirst
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      using (var bd = new ContextoNotasAlumnos())
      {
        Database.SetInitializer<ContextoNotasAlumnos>(new IniciarBaseDeDatos());

        var alumsAsigs =
          from al_as in bd.alums_asigs
          group new
          {
            nom_asig = al_as.asignatura.nombre,
            nota_asig = al_as.nota
          } by al_as.alumno.nombre;

        foreach (var grupo in alumsAsigs)
        {
          System.Diagnostics.Debug.WriteLine(grupo.Key + ":");
          foreach (var elem in grupo)
            System.Diagnostics.Debug.WriteLine(elem.nom_asig + ", " + elem.nota_asig);
        }
      }
    }
  }
}
