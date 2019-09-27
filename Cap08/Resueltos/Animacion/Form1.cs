using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Animacion
{
  public partial class Form1 : Form
  {
    private int CteProporBola = 16; // Una fracción del área de cliente
    private int CteProporMov = 4; // Una fracción del tamaño de la bola
    private Bitmap mapaBits;
    private int posXBola;
    private int posYBola;
    private int radioXBola;
    private int radioYBola;
    private int MovXBola;
    private int MovYBola;
    private int anchoMapaBitsBola;
    private int altoMapaBitsBola;
    private int margenXMapaBits;
    private int margenYMapaBits;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CrearNuevaBola();
      // Iniciar el temporizador
      Timer1.Interval = 25;
      Timer1.Start();
    }

    private void PictureBox1_SizeChanged(object sender, EventArgs e)
    {
      CrearNuevaBola();
    }

    private void CrearNuevaBola()
    {
      // Superficie de dibujo
      Graphics g = PictureBox1.CreateGraphics();
      g.Clear(PictureBox1.BackColor);

      // Radio de la bola proporcional al tamaño de la superficie de dibujo
      double min = Math.Min(PictureBox1.ClientSize.Width / g.DpiX, PictureBox1.ClientSize.Height / g.DpiY);
      double radioBola = min / CteProporBola; // pulgadas

      // Ancho y alto de la bola en píxeles
      radioXBola = Convert.ToInt32(radioBola * g.DpiX);
      radioYBola = Convert.ToInt32(radioBola * g.DpiY);

      g.Dispose(); // liberar los recursos utilizados por g

      // Píxeles que se mueve la bola en las direcciones X e Y.
      // Cantidades proporcionales a su tamaño. Mínimo 1 píxel.
      MovXBola = Math.Max(1, radioXBola / CteProporMov);
      MovYBola = Math.Max(1, radioYBola / CteProporMov);

      // Margen alrededor de la bola, del mismo color que la superficie
      // de dibujo. Haciendo el margen igual al movimiento de la bola,
      // garantizamos que la siguiente imagen dibujada borre la anterior.
      margenXMapaBits = MovXBola;
      margenYMapaBits = MovYBola;

      // Tamaño del mapa de bits incluyendo el margen.
      anchoMapaBitsBola = 2 * (radioXBola + margenXMapaBits);
      altoMapaBitsBola = 2 * (radioYBola + margenYMapaBits);

      // Crear el mapa de bits.
      mapaBits = new Bitmap(anchoMapaBitsBola, altoMapaBitsBola);

      // Obtener el objeto Graphics expuesto por el Bitmap, limpiar
      // la superficie de dibujo, pintar la bola en el mapa de bits y
      // liberar los recursos utilizados por el objeto Graphics.
      g = Graphics.FromImage(mapaBits);
      g.Clear(PictureBox1.BackColor);
      g.FillEllipse(Brushes.Blue, new Rectangle(MovXBola, MovYBola, 2 * radioXBola, 2 * radioYBola));
      g.Dispose();

      // Posición inicial de la bola.
      posXBola = PictureBox1.ClientSize.Width / 2;
      posYBola = PictureBox1.ClientSize.Height / 2;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      // Obtener el objeto Graphics expuesto por PictureBox1
      Graphics g = PictureBox1.CreateGraphics();
      // Dibujar la bola en la superficie de dibujo
      g.DrawImage(mapaBits, posXBola - anchoMapaBitsBola / 2, posYBola - altoMapaBitsBola / 2, anchoMapaBitsBola, altoMapaBitsBola);
      // Liberar los recursos utilizados por el objeto Graphics
      g.Dispose();

      // Siguiente posición de la bola
      posXBola += MovXBola;
      posYBola += MovYBola;

      // Invertir la posición de la bola cuando esta toque en los
      // límites de la superficie de dibujo
      if (posXBola + radioXBola >= PictureBox1.ClientSize.Width || posXBola - radioXBola <= 0)
      {
        MovXBola = -MovXBola;
        Console.Beep(3000, 20);
      }
      if (posYBola + radioYBola >= PictureBox1.ClientSize.Height || posYBola - radioYBola <= 0)
      {
        MovYBola = -MovYBola;
        Console.Beep(4000, 20);
      }
    }
  }
}