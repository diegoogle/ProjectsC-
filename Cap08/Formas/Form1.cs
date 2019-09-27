using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Formas
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btLineasRect_Click(object sender, EventArgs e)
    {
      Graphics g = PictureBox1.CreateGraphics();
      Pen l�piz = new Pen(Color.Black, 3);
      g.DrawLine(l�piz, 10, 10, 240, 100);

      Rectangle rect = new Rectangle(10, 120, 230, 90);
      g.DrawRectangle(l�piz, rect);
    }

    private void btElipsesArcos_Click(object sender, EventArgs e)
    {
      Graphics g = PictureBox1.CreateGraphics();
      Pen l�piz = new Pen(Color.Black);
      l�piz.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
      g.DrawRectangle(l�piz, 10, 10, 230, 90);
      l�piz = new Pen(Color.Black, 3);
      g.DrawEllipse(l�piz, 10, 10, 230, 90);

      Rectangle rect = new Rectangle(10, 120, 230, 90);
      l�piz = new Pen(Color.Black, 3);
      l�piz.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
      g.DrawEllipse(l�piz, rect);
      l�piz = new Pen(Color.Red, 3);
      g.DrawArc(l�piz, rect, 30, 180);
    }

    private void btTarta_Click(object sender, EventArgs e)
    {
      Graphics g = PictureBox1.CreateGraphics();
      Pen l�piz = new Pen(Color.Black, 3);
      Rectangle rect = new Rectangle(10, 60, 230, 90);
      g.DrawPie(l�piz, rect, 30, 150);
    }

    private void btPoligonos_Click(object sender, EventArgs e)
    {
      Graphics g = PictureBox1.CreateGraphics();
      GraphicsPath trazado = new GraphicsPath();
      Pen l�piz = new Pen(Color.Black, 3);

      PointF[] tri�ngulo = { new Point(20, 80), new Point(110, 10), new Point(230, 90) };
      g.DrawPolygon(l�piz, tri�ngulo);

      PointF[] pent�gono = { new Point(20, 150), new Point(130, 120), new Point(230, 155), new Point(190, 200), new Point(45, 195) };
      g.DrawPolygon(l�piz, pent�gono);
    }

    private void btCurvas_Click(object sender, EventArgs e)
    {
      // Superficie de dibujo
      Graphics g = PictureBox1.CreateGraphics();

      // Crear l�pices
      Pen l�pizRojo = new Pen(Color.Red, 3);
      Pen l�pizVerde = new Pen(Color.Green, 3);
      // Puntos que definen la curva flexible cardinal
      Point[] puntos = { new Point(25, 25), new Point(50, 15), new Point(100, 5), new Point(120, 25), new Point(150, 50), new Point(220, 200), new Point(120, 120) };
      // Dibujar l�neas entre los puntos
      g.DrawLines(l�pizRojo, puntos);
      // Dibujar la curva
      g.DrawCurve(l�pizVerde, puntos);

      // Crear l�piz
      Pen l�pizNegro = new Pen(Color.Black, 3);
      // Puntos que definen la curva flexible de B�zier
      Point p1 = new Point(30, 120);
      Point p2 = new Point(150, 200);
      Point c1 = new Point(75, 10);
      Point c2 = new Point(50, 210);
      // Dibujar la curva
      g.DrawBezier(l�pizNegro, p1, c1, c2, p2);
    }

    private void btTrazados_Click(object sender, EventArgs e)
    {
      Graphics g = PictureBox1.CreateGraphics();
      GraphicsPath trazado = new GraphicsPath();
      Rectangle rect = new Rectangle(10, 10, 200, 100);
      trazado.AddArc(rect, 45, 135);
      trazado.AddLine(80, 100, 160, 200);
      trazado.CloseFigure();
      g.DrawPath(Pens.Blue, trazado);
    }

    private void btRegiones_Click(object sender, EventArgs e)
    {
      // Superficie de dibujo
      Graphics g = PictureBox1.CreateGraphics();
      // L�piz
      Pen l�piz = new Pen(Color.Black, 3);
      // Centro de la superficie de dibujo
      int xCentro = PictureBox1.Width / 2;
      int yCentro = PictureBox1.Height / 2;
      // Transformaciones: eje Y positivo hacia arriba y
      // origen (0,0) en el centro
      g.Transform = new Matrix(1, 0, 0, -1, xCentro, yCentro);
      // Rect�ngulos para tres elipses
      Rectangle rect0 = new Rectangle(-50, 0, 100, 100);
      Rectangle rect1 = new Rectangle(-7, -75, 100, 100);
      Rectangle rect2 = new Rectangle(-93, -75, 100, 100);
      // A�adimos tres elipses a un trazado
      GraphicsPath trazado = new GraphicsPath();
      trazado.AddEllipse(rect0);
      trazado.AddEllipse(rect1);
      trazado.AddEllipse(rect2);
      // Pintar el trazado
      g.FillPath(Brushes.Yellow, trazado);
      // Crear una regi�n con el trazado
      Region regi�n = new Region(trazado);

      //GraphicsPath trazado0 = new GraphicsPath();
      //trazado0.AddEllipse(rect0);
      //GraphicsPath trazado1 = new GraphicsPath();
      //trazado1.AddEllipse(rect1);
      //GraphicsPath trazado2 = new GraphicsPath();
      //trazado2.AddEllipse(rect2);
      //Region regi�n = new Region(trazado0);
      //regi�n.Xor(trazado1);
      //regi�n.Xor(trazado2);
      //g.FillRegion(Brushes.Yellow, regi�n);

      // Definir la regi�n de recorte:
      // regi�n de recorte actual intersecci�n objeto regi�n
      g.SetClip(regi�n, CombineMode.Intersect);
      // Dibujar radios desde el origen, de dos en dos grados
      float PI = 3.1415926F;
      float radio = Math.Min(xCentro, yCentro);
      float a;
      float x;
      float y;
      for (a = 0; a <= 2 * PI; a += PI / 90)
      {
        x = System.Convert.ToSingle(radio * Math.Cos(a));
        y = System.Convert.ToSingle(radio * Math.Sin(a));
        g.DrawLine(Pens.Red, 0, 0, x, y);
      }
    }

    private void btLimpiar_Click(object sender, EventArgs e)
    {
      // Limpiar la superficie de dibujo
      Graphics g = PictureBox1.CreateGraphics();
      g.Clear(Color.White);
    }
  }
}