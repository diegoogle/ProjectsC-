using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EditorMDI
{
  public partial class FormDocumento : Form, IForm
  {
    private string[] l�nea;
    private int totalLineasImpresas;

    public ToolStrip bhForm()
    {
      return this.BarraDeHerramientas;
    }

    public FormDocumento()
    {
      InitializeComponent();
    }

    private void ArchivoGuardar_Click(object sender, EventArgs e)
    {
      // Formulario padre
      FormMDI formPadre = (FormMDI)this.MdiParent;

      // Formulario hijo activo
      FormDocumento FormHijo = this;
      if (FormHijo == null) return;

      // Si el texto cambi�...
      if (FormHijo.rtbText.Modified)
      {
        // Obtener la ruta actual del fichero
        string ruta = formPadre.etbarestPpal.Text;
        // Obtener el formato actual del fichero
        RichTextBoxStreamType formato = RichTextBoxStreamType.PlainText;
        if (ruta.EndsWith("rtf"))
          formato = RichTextBoxStreamType.RichText;

        if (FormHijo.Text.StartsWith("Documento"))
        {
          // Mostrar el di�logo Guardar
          SaveFileDialog DlgGuardar = new SaveFileDialog();
          DlgGuardar.Filter =
            "ficheros txt (*.txt)|*.txt|ficheros rtf (*.rtf)|*.rtf";

          if (DlgGuardar.ShowDialog() == DialogResult.OK)
          {
            // Obtener el nombre del fichero
            ruta = DlgGuardar.FileName;
            // Obtener el formato del fichero
            if (DlgGuardar.FilterIndex == 1)
              formato = RichTextBoxStreamType.PlainText;
            else if (DlgGuardar.FilterIndex == 2)
              formato = RichTextBoxStreamType.RichText;
          }
        }

        // Guardar el fichero
        FormHijo.rtbText.SaveFile(ruta, formato);
        // Mostrar el nombre del fichero en la barra de t�tulo
        FormHijo.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
        // Mostrar la ruta del fichero en la barra de estado
        formPadre.etbarestPpal.Text = ruta;
        // Fichero no modificado
        FormHijo.rtbText.Modified = false;
      }
    }

    private void ArchivoGuardarcomo_Click(object sender, EventArgs e)
    {
      // Formulario padre
      FormMDI formPadre = (FormMDI)this.MdiParent;

      // Formulario hijo activo
      FormDocumento FormHijo = this;
      if (FormHijo == null) return;

      // Mostrar el di�logo Guardar
      SaveFileDialog DlgGuardar = new SaveFileDialog();
      DlgGuardar.Filter =
        "ficheros txt (*.txt)|*.txt|ficheros rtf (*.rtf)|*.rtf";

      if (DlgGuardar.ShowDialog() == DialogResult.OK)
      {
        // Obtener el nombre del fichero
        string ruta = DlgGuardar.FileName;
        // Obtener el formato del fichero
        RichTextBoxStreamType formato = RichTextBoxStreamType.PlainText;
        if (DlgGuardar.FilterIndex == 2)
          formato = RichTextBoxStreamType.RichText;

        // Guardar el fichero
        FormHijo.rtbText.SaveFile(ruta, formato);
        // Mostrar el nombre del fichero en la barra de t�tulo
        FormHijo.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
        // Mostrar la ruta del fichero en la barra de estado
        formPadre.etbarestPpal.Text = ruta;
        // Fichero no modificado
        FormHijo.rtbText.Modified = false;
      }
    }

    private void ArchivoImprimir_Click(object sender, EventArgs e)
    {
      // Formulario padre
      FormMDI formPadre = (FormMDI)this.MdiParent;

      // Formulario hijo activo
      FormDocumento FormHijo = this;
      if (FormHijo == null) return;

      // Se supone que durante el dise�o se asign� a la propiedad Document
      // de PrintDialog1 el objeto PrintDocument utilizado para imprimir.

      // Permitir al usuario elegir el rango de p�ginas a imprimir.
      PrintDialog1.AllowSomePages = true;
      if (PrintDialog1.ShowDialog() == DialogResult.OK)
      {
        // Si se puls� el bot�n "Aceptar" (OK), entonces imprimir.
        string texto = FormHijo.rtbText.Text;
        char[] seps = { '\n', '\r' }; // LF y CR
        l�nea = texto.Split(seps); //l�neas de texto que hay que imprimir
        totalLineasImpresas = 0;
        PrintDocument1.Print(); //invoca a ImprimirDoc_PrintPage
      }
    }

    private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      // Formulario padre
      FormMDI formPadre = (FormMDI)this.MdiParent;

      // Formulario hijo activo
      FormDocumento FormHijo = this;

      // Insertar aqu� el c�digo para procesar la p�gina.

      float lineasPorPag;
      float pos_Y;
      float margenIzq = e.MarginBounds.Left;
      float margenSup = e.MarginBounds.Top;

      // Calcular el n�mero de l�neas por p�gina
      Font fuente = FormHijo.rtbText.Font;
      float altoFuente = fuente.GetHeight(e.Graphics);
      lineasPorPag = e.MarginBounds.Height / altoFuente;

      // Contador de las l�neas impresas en una p�gina
      int lineasImpresasPorPag = 0;
      // Imprimir cada una de las l�neas
      while (totalLineasImpresas < l�nea.Length && lineasImpresasPorPag < lineasPorPag)
      {
        pos_Y = margenSup + (lineasImpresasPorPag * altoFuente);
        e.Graphics.DrawString(l�nea[totalLineasImpresas], fuente, Brushes.Black, margenIzq, pos_Y, new StringFormat());
        lineasImpresasPorPag += 1;
        totalLineasImpresas += 1;
      }

      // Si quedan l�neas por imprimir, siguiente p�gina
      if (totalLineasImpresas < l�nea.Length)
        e.HasMorePages = true; // se invoca de nuevo a ImprimirDoc_PrintPage
      else
        e.HasMorePages = false; // finaliza la impresi�n
    }

    private void EdicionCortar_Click(object sender, EventArgs e)
    {
      FormDocumento FormHijo = this;
      // Verificar si hay texto seleccionado
      if (FormHijo.rtbText.SelectedText != "")
      {
        // Cortar el texto seleccionado y ponerlo en la papelera
        FormHijo.rtbText.Cut();
      }
    }

    private void EdicionCopiar_Click(object sender, EventArgs e)
    {
      FormDocumento FormHijo = this;
      // Verificar si hay texto seleccionado
      if (FormHijo.rtbText.SelectedText != "")
      {
        // Copiar el texto seleccionado y ponerlo en la papelera
        FormHijo.rtbText.Copy();
      }
    }

    private void EdicionPegar_Click(object sender, EventArgs e)
    {
      FormDocumento FormHijo = this;
      // Verificar si hay texto en la papelera para pegar
      if ((Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) == true)
      {
        // Verificar si hay texto seleccionado
        if (FormHijo.rtbText.SelectionLength > 0)
        {
          // Preguntar al usuario si quiere sobreescribir el texto seleccionado
          if (MessageBox.Show("�Quiere sobreescribir la selecci�n?", "Pegar", MessageBoxButtons.YesNo) == DialogResult.No)
          {
            // Mover el punto de inserci�n despu�s de la selecci�n y pegar
            FormHijo.rtbText.SelectionStart = FormHijo.rtbText.SelectionStart + FormHijo.rtbText.SelectionLength;
          }
        }
        // Pegar el contenido de la papelera
        FormHijo.rtbText.Paste();
      }
    }

    private void EdicionDeshacer_Click(object sender, EventArgs e)
    {
      FormDocumento FormHijo = this;
      // Verificar si la �ltima operaci�n puede deshacerse
      if (FormHijo.rtbText.CanUndo == true)
      {
        // Deshacer la �ltima operaci�n
        FormHijo.rtbText.Undo();
      }
    }

    private void EdicionRehacer_Click(object sender, EventArgs e)
    {
      FormDocumento FormHijo = this;
      // Verificar si la �ltima operaci�n puede rehacerse
      if (FormHijo.rtbText.CanRedo == true)
      {
        // Rehacer la �ltima operaci�n
        FormHijo.rtbText.Redo();
      }
    }

    private void rtbText_SelectionChanged(object sender, EventArgs e)
    {
      // Checked = true --> bot�n pulsado.
      // Checked = false --> bot�n no pulsado.
      // Negrita, cursiva, subrayado
      btbarNegrita.Checked = rtbText.SelectionFont.Bold;
      btbarCursiva.Checked = rtbText.SelectionFont.Italic;
      btbarSubrayado.Checked = rtbText.SelectionFont.Underline;
      // Alineaci�n del texto
      if (rtbText.SelectionAlignment == HorizontalAlignment.Left)
        btbarAlinIzda.Checked = true;
      else
        btbarAlinIzda.Checked = false;
      if (rtbText.SelectionAlignment == HorizontalAlignment.Center)
        btbarAlinCentrada.Checked = true;
      else
        btbarAlinCentrada.Checked = false;
      if (rtbText.SelectionAlignment == HorizontalAlignment.Right)
        btbarAlinDcha.Checked = true;
      else
        btbarAlinDcha.Checked = false;
    }

    private void btbarNegrita_Click(object sender, EventArgs e)
    {
      // Si la selecci�n est� en negrita la ponemos en normal y viceversa
      Font fuente = rtbText.SelectionFont; // fuente actual
      if (fuente.Bold)
        fuente = new Font(fuente.FontFamily, fuente.Size, FontStyle.Regular);
      else
        fuente = new Font(fuente.FontFamily, fuente.Size, FontStyle.Bold);
      // Asignar la fuente con el nuevo estilo
      rtbText.SelectionFont = fuente;
      // Asignar true (bot�n pulsado) o false (bot�n no pulsado)
      btbarNegrita.Checked = fuente.Bold;
    }

    private void btbarCursiva_Click(object sender, EventArgs e)
    {
      // Si la selecci�n est� en cursiva la ponemos en normal y viceversa
      Font fuente = rtbText.SelectionFont;
      if (fuente.Italic)
        fuente = new Font(fuente.FontFamily, fuente.Size, FontStyle.Regular);
      else
        fuente = new Font(fuente.FontFamily, fuente.Size, FontStyle.Italic);
      rtbText.SelectionFont = fuente;
      btbarCursiva.Checked = fuente.Italic;
    }

    private void btbarSubrayado_Click(object sender, EventArgs e)
    {
      // Si la selecci�n est� subrayada la ponemos sin subrayar y viceversa
      Font fuente = rtbText.SelectionFont;
      if (fuente.Underline)
      {
        fuente = new Font(fuente.FontFamily, fuente.Size, FontStyle.Regular);
      }
      else
      {
        fuente = new Font(fuente.FontFamily, fuente.Size, FontStyle.Underline);
      }
      rtbText.SelectionFont = fuente;
      btbarSubrayado.Checked = fuente.Underline;
    }

    private void btbarAlinIzda_Click(object sender, EventArgs e)
    {
      rtbText.SelectionAlignment = HorizontalAlignment.Left;
      btbarAlinIzda.Checked = true;
      btbarAlinCentrada.Checked = false;
      btbarAlinDcha.Checked = false;
    }

    private void btbarAlinCentrada_Click(object sender, EventArgs e)
    {
      rtbText.SelectionAlignment = HorizontalAlignment.Center;
      btbarAlinIzda.Checked = false;
      btbarAlinCentrada.Checked = true;
      btbarAlinDcha.Checked = false;
    }

    private void btbarAlinDcha_Click(object sender, EventArgs e)
    {
      rtbText.SelectionAlignment = HorizontalAlignment.Right;
      btbarAlinIzda.Checked = false;
      btbarAlinCentrada.Checked = false;
      btbarAlinDcha.Checked = true;
    }

    private void FormDocumento_FormClosing(object sender, FormClosingEventArgs e)
    {
      // Formulario hijo activo
      FormDocumento FormHijo = this;
      if (FormHijo == null) return;

      // Si el texto cambi�...
      if (FormHijo.rtbText.Modified)
      {
        //Preguntar al usuario si quiere guardar el documento
        DialogResult respuesta;
        respuesta = MessageBox.Show("�Desea guardar los cambios efectuados en " +
                    this.Text + "?", "Editor MDI", MessageBoxButtons.YesNoCancel);
        if (respuesta == DialogResult.Yes)
          btbarGuardar.PerformClick();
        else if (respuesta == DialogResult.No)
          e.Cancel = false;
        else // cancelar
          e.Cancel = true; // evento cancelado
      }
    }
  }
}