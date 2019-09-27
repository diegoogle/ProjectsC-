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
    private bool clicBtLineasRect;
    private bool clicbtElipsesArcos;
    private bool clicbtTarta;
    private bool clicbtPoligonos;
    private bool clicbtCurvas;
    private bool clicbtTrazados;
    private bool clicBtRegiones;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      clicBtLineasRect = false;
      clicbtElipsesArcos = false;
      clicbtTarta = false;
      clicbtPoligonos = false;
      clicbtCurvas = false;
      clicbtTrazados = false;
      clicBtRegiones = false;
    }

    private void btLineasRect_Click(object sender, EventArgs e)
    {
      clicBtLineasRect = true;
      PictureBox1.Invalidate();
    }

    private void btElipsesArcos_Click(object sender, EventArgs e)
    {
      clicbtElipsesArcos = true;
      PictureBox1.Invalidate();
    }

    private void btTarta_Click(object sender, EventArgs e)
    {
      clicbtTarta = true;
      PictureBox1.Invalidate();
    }

    private void btPoligonos_Click(object sender, EventArgs e)
    {
      clicbtPoligonos = true;
      PictureBox1.Invalidate();
    }

    private void btCurvas_Click(object sender, EventArgs e)
    {
      clicbtCurvas = true;
      PictureBox1.Invalidate();
    }

    private void btTrazados_Click(object sender, EventArgs e)
    {
      clicbtTrazados = true;
      PictureBox1.Invalidate();
    }

    private void btRegiones_Click(object sender, EventArgs e)
    {
      clicBtRegiones = true;
      PictureBox1.Invalidate();
    }

    private void btLimpiar_Click(object sender, EventArgs e)
    {
      // Limpiar la superficie de dibujo
      Graphics g = PictureBox1.CreateGraphics();
      g.Clear(Color.White);
      // Variables a False
      clicBtLineasRect = false;
      clicbtElipsesArcos = false;
      clicbtTarta = false;
      clicbtPoligonos = false;
      clicbtCurvas = false;
      clicbtTrazados = false;
      clicBtRegiones = false;
    }

    private void PictureBox1_Paint(object sender, PaintEventArgs e)
    {
      // Superficie de dibujo
      Graphics g = e.Graphics;

      // L�neas y rect�ngulos
      if (clicBtLineasRect)
      {
        Pen l�piz = new Pen(Color.Black, 3);
        g.DrawLine(l�piz, 10, 10, 240, 100);
        Rectangle rect = new Rectangle(10, 120, 230, 90);
        g.DrawRectangle(l�piz, rect);
      }

      // Elipses y arcos
      if (clicbtElipsesArcos)
      {
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

      // Tartas
      if (clicbtTarta)
      {
        Pen l�piz = new Pen(Color.Black, 3);
        Rectangle rect = new Rectangle(10, 60, 230, 90);
        g.DrawPie(l�piz, rect, 30, 150);
      }

      // Pol�gonos
      if (clicbtPoligonos)
      {
        GraphicsPath trazado = new GraphicsPath();
        Pen l�piz = new Pen(Color.Black, 3);

        PointF[] tri�ngulo = new PointF[] { new Point(20, 80), new Point(110, 10), new Point(230, 90) };
        g.DrawPolygon(l�piz, tri�ngulo);

        PointF[] pent�gono = new PointF[] { new Point(20, 150), new Point(130, 120), new Point(230, 155), new Point(190, 200), new Point(45, 195) };
        g.DrawPolygon(l�piz, pent�gono);
      }

      // Curvas
      if (clicbtCurvas)
      {
        // Crear l�pices
        Pen l�pizRojo = new Pen(Color.Red, 3);
        Pen l�pizVerde = new Pen(Color.Green, 3);
        // Puntos que definen la curva flexible cardinal
        Point[] puntos = new Point[] { new Point(25, 25), new Point(50, 15), new Point(100, 5), new Point(120, 25), new Point(150, 50), new Point(220, 200), new Point(120, 120) };
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

      // Trazados
      if (clicbtTrazados)
      {
        GraphicsPath trazado = new GraphicsPath();
        Rectangle rect = new Rectangle(10, 10, 200, 100);
        trazado.AddArc(rect, 45, 135);
        trazado.AddLine(80, 100, 160, 200);
        trazado.CloseFigure();
        g.DrawPath(Pens.Blue, trazado);
      }

      // Regiones
      if (clicBtRegiones)
      {
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
        // Restablecer los valores originales
        g.ResetTransform();
        g.ResetClip();
      }
    }
  }
}