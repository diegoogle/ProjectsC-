using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace VisorImags
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ArchivoCerrar_Click(object sender, EventArgs e)
    {
      ciImagen.Image = null;
    }

    private void ArchivoAbrir_Click(object sender, EventArgs e)
    {
      OpenFileDialog DlgAbrir = new OpenFileDialog();

      DlgAbrir.InitialDirectory = Directory.GetCurrentDirectory();
      DlgAbrir.Filter = "Ficheros BMP|*.bmp" +
                        "|Ficheros GIF|*.gif" +
                        "|Ficheros JPG o JPEG|*.jpg;*.jpeg" +
                        "|Ficheros PNG|*.png" +
                        "|Ficheros EXIF|*.exif" +
                        "|Ficheros TIFF|*.tiff";
      DlgAbrir.FilterIndex = 3;

      // Mostrar el diálogo Abrir
      if (DlgAbrir.ShowDialog() == DialogResult.OK)
      {
        ciImagen.Image = Image.FromFile(DlgAbrir.FileName);
        etMensaje.Text = DlgAbrir.FileName.Substring(DlgAbrir.FileName.LastIndexOf('\\') + 1);
      }
    }

    private void ArchivoGuardarComo_Click(object sender, EventArgs e)
    {
      SaveFileDialog DlgGuardar = new SaveFileDialog();

      DlgGuardar.InitialDirectory = Directory.GetCurrentDirectory();
      DlgGuardar.Filter = "Ficheros BMP|*.bmp" +
                          "|Ficheros GIF|*.gif" +
                          "|Ficheros JPG o JPEG|*.jpg;*.jpeg" +
                          "|Ficheros PNG|*.png" +
                          "|Ficheros EXIF|*.exif" +
                          "|Ficheros TIFF|*.tiff";
      DlgGuardar.FilterIndex = 3;

      if (DlgGuardar.ShowDialog() == DialogResult.OK)
      {
        // Guardar la imagen el fichero
        ImageFormat formato = ImageFormat.Jpeg;
        switch (DlgGuardar.FilterIndex)
        {
          case 1:
            formato = ImageFormat.Bmp;
            break;
          case 2:
            formato = ImageFormat.Gif;
            break;
          case 3:
            formato = ImageFormat.Jpeg;
            break;
          case 4:
            formato = ImageFormat.Png;
            break;
          case 5:
            formato = ImageFormat.Exif;
            break;
          case 6:
            formato = ImageFormat.Tiff;
            break;
        }
        ciImagen.Image.Save(DlgGuardar.FileName, formato);
      }
    }

    private void OpcionesTamAjustado_Click(object sender, EventArgs e)
    {
      if (ciImagen.Image == null) return;
      ciImagen.Size = Panel1.Size;
      ciImagen.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void OpcionesTamReal_Click(object sender, EventArgs e)
    {
      if (ciImagen.Image == null) return;
      ciImagen.SizeMode = PictureBoxSizeMode.AutoSize;
    }

    private void OpcionesAcercar_Click(object sender, EventArgs e)
    {
      if (ciImagen.Image == null) return;
      // Relación ancho/alto de la imagen
      double k = (double)ciImagen.Image.Width / ciImagen.Image.Height;
      // Para una imagen proporcional debe cumplirse que:
      // ciImagen.Width / ciImagen.Height sea igual a k
      int nuevoAncho = Convert.ToInt32(ciImagen.Width * 1.25);
      ciImagen.Width = nuevoAncho;
      ciImagen.Height = Convert.ToInt32(nuevoAncho / k);
      ciImagen.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void OpcionesAlejar_Click(object sender, EventArgs e)
    {
      if (ciImagen.Image == null) return;
      // Relación ancho/alto de la imagen
      double k = (double)ciImagen.Image.Width / ciImagen.Image.Height;
      // Para una imagen proporcional debe cumplirse que:
      // ciImagen.Width / ciImagen.Height sea igual a k
      int nuevoAncho = Convert.ToInt32(ciImagen.Width / 1.25);
      ciImagen.Width = nuevoAncho;
      ciImagen.Height = Convert.ToInt32(nuevoAncho / k);
      ciImagen.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void OpcionesGirar90_Click(object sender, EventArgs e)
    {
      if (ciImagen.Image == null) return;
      ciImagen.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
      ciImagen.Invalidate();
    }

    private void OpcionesCopiar_Click(object sender, EventArgs e)
    {
      if (ciImagen.Image == null) return;
      Clipboard.SetImage(ciImagen.Image);
    }

    private void AyudaAcercaDe_Click(object sender, EventArgs e)
    {
      //String mensaje = "Visor de imágenes. Versión 1.1" +
      //                 Environment.NewLine +
      //                 "Copyright (c) Fco. Javier Ceballos, 2007";
      //MessageBox.Show(mensaje, "Acerca de Visor de imágenes");
      (new AcercaDe()).ShowDialog();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Width = 800;
      Height = 600;
    }

    private void OpcionesEscalaDeGrises_Click(object sender, EventArgs e)
    {
      Image imagen = ciImagen.Image;

      using (Graphics gfx = Graphics.FromImage(imagen))
      {
        // Matriz para realizar una transformación a escala de grises
        // manteniendo los valores de luminancia.
        ColorMatrix cm = new ColorMatrix(new float[][]
        {
          new float[]{0.3f, 0.3f, 0.3f, 0, 0},
          new float[]{0.59f, 0.59f, 0.59f, 0, 0},
          new float[]{0.11f, 0.11f, 0.11f, 0, 0},
          new float[]{0, 0, 0, 1, 0},
          new float[]{0, 0, 0, 0, 1}
        });
        ImageAttributes ia = new ImageAttributes();
        ia.SetColorMatrix(cm);
        // Utilizar el método DrawImage de gfx para volver a dibujar la
        // imagen utilizando los atributos especificados por ia
        gfx.DrawImage(imagen,
                      new Rectangle(0, 0, imagen.Width, imagen.Height),
                      0, 0, imagen.Width, imagen.Height,
                      GraphicsUnit.Pixel, ia);
      }
      ciImagen.Refresh();
    }
  }
}