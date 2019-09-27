/* En este ejercicio ciFuncion_MouseMove y ciFuncion_MouseUp invocarán al método Invalidate
 * pasándole como argumento el rectángulo de la superficie de dibujo que hay que repintar.
 * Esta región está definida por la propiedad ClipRectangle de la clase Graphics y es
 * reconocida automáticamente por los métodos de esta clase.
 * Puede verificar que se repinta el rectángulo invalidado cambiando los lápices de color.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Funciones
{
  public partial class Form1 : Form
  {
    private Matrix matriz;
    private SmoothingMode calidad;

    private float Xmin, Xmax;
    private float Ymax, Ymin;
    private int x1;
    private int y1;
    private int x2;
    private int y2;
    private int x1a; // x1 anterior
    private bool botonPulsado;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      etFuncion.Text = "7 + 23 * Sin(0.8 * X) * Sin(10 / X)";
      calidad = SmoothingMode.Default;
      inicio();
    }

    private void btDibujar_Click(object sender, EventArgs e)
    {
      inicio();
      Dibujar();
    }

    public float ValorFuncion(double X)
    {
      //return (float)Sin(X);
      return Convert.ToSingle(7 + 23 * Math.Sin(0.8 * X) * Math.Sin(10 / X));
    }

    private void Dibujar()
    {
      ciFuncion.Invalidate(); // invoca a ciFuncion_Paint
    }

    private void inicio()
    {
      Xmin = Convert.ToSingle(ctXMin.Text);
      Xmax = Convert.ToSingle(ctXMax.Text);
      if (Xmin >= Xmax)
      {
        MessageBox.Show("X máx tiene que ser mayor que X mín");
        return;
      }
      float val;
      Ymin = ValorFuncion(Xmin);
      Ymax = ValorFuncion(Xmin);

      // Calcular el valor de la función para cada píxel en el eje X
      // y obtener el valor máximo y mínimo
      float t;
      for (t = Xmin; t <= Xmax; t += (Xmax - Xmin) / (ciFuncion.Width - 3))
      {
        val = ValorFuncion(t);
        if (float.IsInfinity(val) || float.IsNaN(val))
        {
          MessageBox.Show("No se puede dibujar la función en este rango");
          return;
        }
        Ymax = Math.Max(val, Ymax);
        Ymin = Math.Min(val, Ymin);
      }
      // matriz vale inicialmente: 1 0 0 1 0 0
      matriz = new Matrix();
      // Scale modifica los valores primero y cuarto
      matriz.Scale(((ciFuncion.Width - 3) / (Xmax - Xmin)), -(ciFuncion.Height - 3) / (Ymax - Ymin));
      // Translate modifica los valores quinto y sexto
      matriz.Translate(-Xmin, -Ymax);
    }

    private void ciFuncion_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.Clear(ciFuncion.BackColor);

      // Trazados para los ejes
      GraphicsPath EjeX = new GraphicsPath();
      GraphicsPath EjeY = new GraphicsPath();
      EjeX.AddLine(new PointF(Xmin, 0), new PointF(Xmax, 0));
      EjeY.AddLine(new PointF(0, Ymax), new PointF(0, Ymin));

      // Trazado para la función
      float XAnterior, YAnterior;
      float X, Y;
      // Cada segmento en el trazado va desde (XAnterior, YAnterior) a (X, Y)
      GraphicsPath Función = new GraphicsPath();
      Pen lápiz = new Pen(Color.Black, 1);
      // Punto inicial
      XAnterior = Xmin;
      YAnterior = ValorFuncion(Xmin);
      // Segmentos que forman el trazado de la función
      float t;
      for (t = Xmin; t <= Xmax; t += (Xmax - Xmin) / (ciFuncion.Width - 3))
      {
        X = t;
        Y = ValorFuncion(t);
        Función.AddLine(XAnterior, YAnterior, X, Y);
        XAnterior = X;
        YAnterior = Y;
      }
      // Establecer la calidad con la que se dibujará
      g.SmoothingMode = calidad;
      // La siguiente línea se puede eliminar. Permite verificar visualmente
      // la parte del gráfico que cambia
      if (botonPulsado) lápiz.Color = Color.Gray;
      // Dibujar todo aplicando transformaciones locales
      EjeX.Transform(matriz);
      g.DrawPath(lápiz, EjeX); // Eje X
      EjeY.Transform(matriz);
      g.DrawPath(lápiz, EjeY); // Eje Y
      lápiz.Color = Color.Blue;
      // La siguiente línea se puede eliminar. Permite verificar visualmente
      // la parte del gráfico que cambia
      if (botonPulsado) lápiz.Color = Color.Violet;
      Función.Transform(matriz); // Función
      g.DrawPath(lápiz, Función);

      // Si el botón del ratón está pulsado, dibujar el cursor
      if (botonPulsado)
      {
        g.DrawLine(Pens.Red, x1, y1, x2, y2);
        // Convertir píxeles a coordenadas lógicas
        float x1log = converCFisicasACLogicas(x1);
        // Mostrar las coordenadas en las cajas de texto
        ctCoordX.Text = string.Format("{0:F2}", x1log);
        ctCoordY.Text = string.Format("{0:F2}", ValorFuncion(x1log));
      }
    }

    // Cuando se hace clic en un botón de opción cambian dos: se generan
    // dos eventos CheckedChanged
    private void boCalidadNormal_CheckedChanged(object sender, EventArgs e)
    {
      if (!Visible) return;
      RadioButton bo = (RadioButton)sender;
      if (bo.Checked)
      {
        calidad = SmoothingMode.Default;
        ciFuncion.Invalidate();
      }
    }

    private void boCalidadAlta_CheckedChanged(object sender, EventArgs e)
    {
      if (!Visible) return;
      RadioButton bo = (RadioButton)sender;
      if (bo.Checked)
      {
        calidad = SmoothingMode.HighQuality;
        ciFuncion.Invalidate();
      }
    }

    private void ciFuncion_SizeChanged(object sender, EventArgs e)
    {
      ciFuncion.Invalidate();
    }

    private void ciFuncion_MouseDown(object sender, MouseEventArgs e)
    {
      x1a = e.X; // x1 anterior
    }

    private void ciFuncion_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        botonPulsado = true;
        // Coordenadas del cursor a dibujar
        x1 = e.X;
        y1 = 0;
        x2 = e.X;
        y2 = ciFuncion.Height;
        // Rectángulo que deseamos invalidar para repintar
        int x = Math.Min(e.X, x1a);
        int ancho = Math.Abs(e.X - x1a) + 1;
        Rectangle rect = new Rectangle(x, y1, ancho, y2);
        ciFuncion.Invalidate(rect);
        x1a = x1; // x1 anterior
      }
    }

    private void ciFuncion_MouseUp(object sender, MouseEventArgs e)
    {
      botonPulsado = false;
      // Borrar el cursor
      Rectangle rect = new Rectangle(e.X, 0, 1, ciFuncion.Height);
      ciFuncion.Invalidate(rect);
      ctCoordX.Text = "";
      ctCoordY.Text = "";
    }

    private float converCFisicasACLogicas(int x)
    {
      float Xmin = Convert.ToSingle(ctXMin.Text);
      float Xmax = Convert.ToSingle(ctXMax.Text);
      return Xmin + x * (Xmax - Xmin) / (ciFuncion.Width - 3);
    }
  }
}