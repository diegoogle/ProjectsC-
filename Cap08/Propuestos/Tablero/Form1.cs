using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tablero
{
  public partial class Form1 : Form
  {
    private Graphics g; // Objeto gráfico permanente
    private Pen lápizNegroN2;

    private int x1;
    private int y1;
    private int x2;
    private int y2;
    private Rectangle rect; // rectángulos
    private Rectangle rectInvalido;
    private bool dibujando; // true si se está dibujando; en otro caso false

    public Form1()
    {
      InitializeComponent();
    }

    private Graphics ObtenerObjetoGraphics()
    {
      // Devuelve un objeto gráfico permanente
      Bitmap mapaBits = new Bitmap(this.Width, this.Height);
      Panel.BackgroundImage = mapaBits;
      Graphics g = Graphics.FromImage(mapaBits);
      return g;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Iniciar atributos de la aplicación.
      // Este método también es llamado por la orden Nuevo.
      Panel.BackColor = Color.White; // fondo blanco
      g = ObtenerObjetoGraphics(); // objeto gráfico permanente
      lápizNegroN2 = new Pen(Color.Black, 2); // lápiz negro de grosor 2
      dibujando = false; // no se está dibujando
      btManoAlzada.Checked = true; // botón mano alzada pulsado
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Panel_MouseDown(object sender, MouseEventArgs e)
    {
      // Se pulsó el botón del ratón
      x1 = e.X;
      y1 = e.Y; // punto de inicio del dibujo
      rectInvalido = new Rectangle(x1 - 3, y1 - 3, 20, 20); // rectángulo a invalidar
    }

    private void Panel_MouseMove(object sender, MouseEventArgs e)
    {
      // Se mueve el ratón con el botón izquierdo pulsado
      if (e.Button == MouseButtons.Left)
      {
        dibujando = true;
        // Actualizar barra de estado
        etX.Text = "X: " + e.X.ToString();
        etY.Text = "Y: " + e.Y.ToString();
        // Punto final
        x2 = e.X;
        y2 = e.Y;
        // Rectángulo de la forma a dibujar
        rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
        // Llama a Panel_Paint para dibujar. Primero se invalida el área
        // no permanente de dibujo para borrar la forma anteriormente dibujada
        // y después se dibuja con los últimos datos obtenidos.
        Panel.Invalidate(rectInvalido);
      }
    }

    private void Panel_Paint(object sender, PaintEventArgs e)
    {
      // Se dibuja sobre el objeto gráfico no permanente para poder
      // variar la forma, excepto cuando se dibuja a mano alzada.
      // La forma final se dibuja sobre el objeto gráfico permanente
      // cuando se suelta el botón del ratón.
      if (!dibujando) return;

      if (btManoAlzada.Checked)
      {
        g.DrawLine(lápizNegroN2, x1, y1, x2, y2);
        x1 = x2;
        y1 = y2;
      }

      if (btLinea.Checked)
        e.Graphics.DrawLine(lápizNegroN2, x1, y1, x2, y2);

      if (btRectangulo.Checked)
        e.Graphics.DrawRectangle(lápizNegroN2, rect);

      if (btElipse.Checked)
        e.Graphics.DrawEllipse(lápizNegroN2, rect);

      rectInvalido = new Rectangle(rect.X - 3, rect.Y - 3, rect.Width + 20, rect.Height + 20); // rectángulo anterior
    }

    private void Panel_MouseUp(object sender, MouseEventArgs e)
    {
      // Se soltó el botón del ratón
      if (!dibujando) return;

      if (btLinea.Checked)
        g.DrawLine(lápizNegroN2, x1, y1, x2, y2);

      if (btRectangulo.Checked)
        g.DrawRectangle(lápizNegroN2, rect);

      if (btElipse.Checked)
        g.DrawEllipse(lápizNegroN2, rect);

      dibujando = false;
      Panel.Invalidate();
    }

    private void Botón_Click(object sender, EventArgs e)
    {
      // Se hizo clic sobre un botón de la barra de herramientas
      ToolStripButton botón;
      for (int bt = 0; bt <= barraDeHerramientas.Items.Count - 1; bt++)
      {
        botón = (ToolStripButton)barraDeHerramientas.Items[bt];
        botón.Checked = false;
      }
      botón = (ToolStripButton)sender;
      botón.Checked = true;
    }

    private void DibujarForma_Click(object sender, EventArgs e)
    {
      // Se hizo clic sobre una orden del menú dibujar
      ToolStripMenuItem dibujarForma = (ToolStripMenuItem)sender;

      if (dibujarForma.Name.CompareTo("DibujarManoAlzada") == 0)
        btManoAlzada.PerformClick();

      if (dibujarForma.Name.CompareTo("DibujarLinea") == 0)
        btLinea.PerformClick();

      if (dibujarForma.Name.CompareTo("DibujarRectangulo") == 0)
        btRectangulo.PerformClick();

      if (dibujarForma.Name.CompareTo("DibujarElipse") == 0)
        btElipse.PerformClick();
    }

    private void AyudaInstrucciones_Click(object sender, EventArgs e)
    {
      FileStream fe = null;
      // Si utilizáramos StreamReader y ReadToEnd() las letras
      // acentuadas se pierden.
      try
      {
        // Crear un flujo desde el fichero texto.txt
        fe = new FileStream("..\\..\\tablero.txt",
                            FileMode.Open, FileAccess.Read);
        char[] cBuffer = new char[(int)fe.Length];
        byte[] bBuffer = new byte[(int)fe.Length];
        // Leer del fichero una línea de texto
        fe.Read(bBuffer, 0, (int)fe.Length);
        // Crear un objeto string con el texto leído
        Array.Copy(bBuffer, cBuffer, bBuffer.Length);
        String str = new String(cBuffer, 0, (int)fe.Length);
        // Mostrar el texto leído
        MessageBox.Show(str);
      }
      catch (IOException ex)
      {
        Console.WriteLine("Error: " + ex.Message);
      }
      finally
      {
        // Cerrar el fichero
        if (fe != null) fe.Close();
      }
    }

    private void AyudaAcercaDe_Click(object sender, EventArgs e)
    {
      (new AcercaDe()).ShowDialog();
    }
  }
}