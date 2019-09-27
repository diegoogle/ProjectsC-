using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EventosRaton
{
  public partial class Form1 : Form
  {
    int x1;
    int y1;
    int x2;
    int y2;
    bool botonPulsado;

    public Form1()
    {
      InitializeComponent();
    }

    private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        botonPulsado = true;
        // Coordenadas del cursor a dibujar
        x1 = e.X;
        y1 = 0;
        x2 = e.X;
        y2 = PictureBox1.Height;
        PictureBox1.Invalidate();
      }
    }

    private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      botonPulsado = false;
      // Borrar el cursor
      Rectangle rect = new Rectangle(e.X, 0, 1, PictureBox1.Height);
      PictureBox1.Invalidate(rect);
    }

    private void PictureBox1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      // Gráfico
      g.DrawLine(Pens.Black, 0, PictureBox1.Height / 2, PictureBox1.Width, PictureBox1.Height / 2);
      // Si el botón del ratón está pulsado, dibujar el cursor
      if (botonPulsado)
        g.DrawLine(Pens.Red, x1, y1, x2, y2);
    }
  }
}