using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EditorMDI
{
  public partial class FormDocumento2 : Form, IForm
  {
    public ToolStrip bhForm()
    {
      return this.BarraDeHerramientas;
    }

    public FormDocumento2()
    {
      InitializeComponent();
    }

    private void ArchivoGuardar_Click(object sender, EventArgs e)
    {
      // Formulario padre
      FormMDI formPadre = (FormMDI)this.MdiParent;

      // Formulario hijo activo
      FormDocumento2 FormHijo = this;
      if (FormHijo == null) return;

      // Si el texto cambió...
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
          // Mostrar el diálogo Guardar
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
        // Mostrar el nombre del fichero en la barra de título
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
      FormDocumento2 FormHijo = this;
      if (FormHijo == null) return;

      // Mostrar el diálogo Guardar
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
        // Mostrar el nombre del fichero en la barra de título
        FormHijo.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
        // Mostrar la ruta del fichero en la barra de estado
        formPadre.etbarestPpal.Text = ruta;
        // Fichero no modificado
        FormHijo.rtbText.Modified = false;
      }
    }

    private void EdicionCortar_Click(object sender, EventArgs e)
    {
      FormDocumento2 FormHijo = this;
      // Verificar si hay texto seleccionado
      if (FormHijo.rtbText.SelectedText != "")
      {
        // Cortar el texto seleccionado y ponerlo en la papelera
        FormHijo.rtbText.Cut();
      }
    }

    private void EdicionCopiar_Click(object sender, EventArgs e)
    {
      FormDocumento2 FormHijo = this;
      // Verificar si hay texto seleccionado
      if (FormHijo.rtbText.SelectedText != "")
      {
        // Copiar el texto seleccionado y ponerlo en la papelera
        FormHijo.rtbText.Copy();
      }
    }

    private void EdicionPegar_Click(object sender, EventArgs e)
    {
      FormDocumento2 FormHijo = this;
      // Verificar si hay texto en la papelera para pegar
      if ((Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) == true)
      {
        // Verificar si hay texto seleccionado
        if (FormHijo.rtbText.SelectionLength > 0)
        {
          // Preguntar al usuario si quiere sobreescribir el texto seleccionado
          if (MessageBox.Show("¿Quiere sobreescribir la selección?", "Pegar", MessageBoxButtons.YesNo) == DialogResult.No)
          {
            // Mover el punto de inserción después de la selección y pegar
            FormHijo.rtbText.SelectionStart = FormHijo.rtbText.SelectionStart + FormHijo.rtbText.SelectionLength;
          }
        }
        // Pegar el contenido de la papelera
        FormHijo.rtbText.Paste();
      }
    }

    private void FormDocumento2_FormClosing(object sender, FormClosingEventArgs e)
    {
      // Formulario hijo activo
      FormDocumento2 FormHijo = this;
      if (FormHijo == null) return;

      // Si el texto cambió...
      if (FormHijo.rtbText.Modified)
      {
        //Preguntar al usuario si quiere guardar el documento
        DialogResult respuesta;
        respuesta = MessageBox.Show("¿Desea guardar los cambios efectuados en " +
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