using System;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;

namespace BaseDeDatos
{
  public class bbdd
  {
    static bbdd()
    {
      ObtenerAlumnos();
    }

    private static ListAlumnos _alumnos;
    public static ListAlumnos Alumnos
    {
      get { return _alumnos; }
    }

    // Crear la base de datos
    private static ListAlumnos ObtenerAlumnos()
    {
      _alumnos = new ListAlumnos();
      BindingList<Asignaturas> coAsignaturas;
      BindingList<Asignatura> asignaturas;
      Random rnd = new Random();
      for (int i = 1; i < 10; ++i)
      {
        int idAl = i + i * 10 + i * 100; // 111, 222,...
        string nomAl = "Alumno " + Convert.ToChar(64 + i);
        string dirAl = "Dirección 0" + i;
        string estAl = ObtenerEstudios[rnd.Next(9)].Text;
        bool becaAl = i % 3 == 0 ? true : false;
        coAsignaturas = new BindingList<Asignaturas>();
        // Obligatorias
        asignaturas = new BindingList<Asignatura>();
        for (int a = 0; a < rnd.Next(3, 6); ++a)
        {
          int idAsOb = (i - 1 + a) % 9;
          string asig = ObtenerAsigsOB[idAsOb].Text; // Asignatura ob?,...
          float nota = (float)(((int)(rnd.NextDouble() * 100)) / 10.0F);
          asignaturas.Add(new Asignatura((int)ObtenerAsigsOB[idAsOb].Tag, asig, nota));
        }
        coAsignaturas.Add(new Asignaturas("Obligatorias", asignaturas));
        // Optativas
        asignaturas = new BindingList<Asignatura>();
        for (int a = 0; a < rnd.Next(2, 4); ++a)
        {
          int idAsOp = (i - 1 + a) % 9;
          System.Diagnostics.Debug.WriteLine(idAsOp);
          string asig = ObtenerAsigsOP[idAsOp].Text; // Asignatura op?,...
          float nota = (float)(((int)(rnd.NextDouble() * 100)) / 10.0F);
          asignaturas.Add(new Asignatura((int)ObtenerAsigsOP[idAsOp].Tag, asig, nota));
        }
        coAsignaturas.Add(new Asignaturas("Optativas", asignaturas));
        _alumnos.Add(new Alumno(idAl, nomAl, dirAl, estAl, becaAl, coAsignaturas));
      }
      return _alumnos;
    }

    public static Alumno ObtenerAlumnoPorId(int idAl)
    {
      foreach (Alumno al in Alumnos)
        if (al.IdAlumno == idAl)
          return al;
      return null;
    }

    public static ToolStripMenuItem[] ObtenerEstudios
    {
      get
      {
        ToolStripMenuItem[] ests = new ToolStripMenuItem[9];
        for (int i = 0; i < 9; ++i)
          ests[i] = new ToolStripMenuItem("Estudios 0" + (i + 1));
        return ests;
      }
    }

    public static ToolStripMenuItem[] ObtenerTiposAsigs
    {
      get
      {
        ToolStripMenuItem[] tipo = new ToolStripMenuItem[2];
        tipo[0] = new ToolStripMenuItem("Obligatorias");
        tipo[1] = new ToolStripMenuItem("Optativas");
        return tipo;
      }
    }

    public static ToolStripMenuItem[] ObtenerAsigsOB
    {
      get
      {
        ToolStripMenuItem[] asOB = new ToolStripMenuItem[9];
        for (int i = 0; i < 9; ++i)
        {
          asOB[i] = new ToolStripMenuItem("Asignatura ob" + (i + 11));
          asOB[i].Tag = i + 11; // ID asignatura
        }
        return asOB;
      }
    }

    public static ToolStripMenuItem[] ObtenerAsigsOP
    {
      get
      {
        ToolStripMenuItem[] asOP = new ToolStripMenuItem[9];
        for (int i = 0; i < 9; ++i)
        {
          asOP[i] = new ToolStripMenuItem("Asignatura op" + (i + 61));
          asOP[i].Tag = i + 61; // ID asignatura
        }
        return asOP;
      }
    }
  }
}
