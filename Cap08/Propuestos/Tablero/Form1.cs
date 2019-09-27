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
    private Graphics g; // Objeto gr�fico permanente
    private Pen l�pizNegroN2;

    private int x1;
    private int y1;
    private int x2;
    private int y2;
    private Rectangle rect; // rect�ngulos
    private Rectangle rectInvalido;
    private bool dibujando; // true si se est� dibujando; en otro caso false

    public Form1()
    {
      InitializeComponent();
    }

    private Graphics ObtenerObjetoGraphics()
    {
      // Devuelve un objeto gr�fico permanente
      Bitmap mapaBits = new Bitmap(this.Width, this.Height);
      Panel.BackgroundImage = mapaBits;
      Graphics g = Graphics.FromImage(mapaBits);
      return g;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Iniciar atributos de la aplicaci�n.
      // Este m�todo tambi�n es llamado por la orden Nuevo.
      Panel.BackColor = Color.White; // fondo blanco
      g = ObtenerObjetoGraphics(); // objeto gr�fico permanente
      l�pizNegroN2 = new Pen(Color.Black, 2); // l�piz negro de grosor 2
      dibujando = false; // no se est� dibujando
      btManoAlzada.Checked = true; // bot�n mano alzada pulsado
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Panel_MouseDown(object sender, MouseEventArgs e)
    {
      // Se puls� el bot�n del rat�n
      x1 = e.X;
      y1 = e.Y; // punto de inicio del dibujo
      rectInvalido = new Rectangle(x1 - 3, y1 - 3, 20, 20); // rect�ngulo a invalidar
    }

    private void Panel_MouseMove(object sender, MouseEventArgs e)
    {
      // Se mueve el rat�n con el bot�n izquierdo pulsado
      if (e.Button == MouseButtons.Left)
      {
        dibujando = true;
        // Actualizar barra de estado
        etX.Text = "X: " + e.X.ToString();
        etY.Text = "Y: " + e.Y.ToString();
        // Punto final
        x2 = e.X;
        y2 = e.Y;
        // Rect�ngulo de la forma a dibujar
        rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
        // Llama a Panel_Paint para dibujar. Primero se invalida el �rea
        // no permanente de dibujo para borrar la forma anteriormente dibujada
        // y despu�s se dibuja con los �ltimos datos obtenidos.
        Panel.Invalidate(rectInvalido);
      }
    }

    private void Panel_Paint(object sender, PaintEventArgs e)
    {
      // Se dibuja sobre el objeto gr�fico no permanente para poder
      // variar la forma, excepto cuando se dibuja a mano alzada.
      // La forma final se dibuja sobre el objeto gr�fico permanente
      // cuando se suelta el bot�n del rat�n.
      if (!dibujando) return;

      if (btManoAlzada.Checked)
      {
        g.DrawLine(l�pizNegroN2, x1, y1, x2, y2);
        x1 = x2;
        y1 = y2;
      }

      if (btLinea.Checked)
        e.Graphics.DrawLine(l�pizNegroN2, x1, y1, x2, y2);

      if (btRectangulo.Checked)
        e.Graphics.DrawRectangle(l�pizNegroN2, rect);

      if (btElipse.Checked)
        e.Graphics.DrawEllipse(l�pizNegroN2, rect);

      rectInvalido = new Rectangle(rect.X - 3, rect.Y - 3, rect.Width + 20, rect.Height + 20); // rect�ngulo anterior
    }

    private void Panel_MouseUp(object sender, MouseEventArgs e)
    {
      // Se solt� el bot�n del rat�n
      if (!dibujando) return;

      if (btLinea.Checked)
        g.DrawLine(l�pizNegroN2, x1, y1, x2, y2);

      if (btRectangulo.Checked)
        g.DrawRectangle(l�pizNegroN2, rect);

      if (btElipse.Checked)
        g.DrawEllipse(l�pizNegroN2, rect);

      dibujando = false;
      Panel.Invalidate();
    }

    private void Bot�n_Click(object sender, EventArgs e)
    {
      // Se hizo clic sobre un bot�n de la barra de herramientas
      ToolStripButton bot�n;
      for (int bt = 0; bt <= barraDeHerramientas.Items.Count - 1; bt++)
      {
        bot�n = (ToolStripButton)barraDeHerramientas.Items[bt];
        bot�n.Checked = false;
      }
      bot�n = (ToolStripButton)sender;
      bot�n.Checked = true;
    }

    private void DibujarForma_Click(object sender, EventArgs e)
    {
      // Se hizo clic sobre una orden del men� dibujar
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
      // Si utiliz�ramos StreamReader y ReadToEnd() las letras
      // acentuadas se pierden.
      try
      {
        // Crear un flujo desde el fichero texto.txt
        fe = new FileStream("..\\..\\tablero.txt",
                            FileMode.Open, FileAccess.Read);
        char[] cBuffer = new char[(int)fe.Length];
        byte[] bBuffer = new byte[(int)fe.Length];
        // Leer del fichero una l�nea de texto
        fe.Read(bBuffer, 0, (int)fe.Length);
        // Crear un objeto string con el texto le�do
        Array.Copy(bBuffer, cBuffer, bBuffer.Length);
        String str = new String(cBuffer, 0, (int)fe.Length);
        // Mostrar el texto le�do
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