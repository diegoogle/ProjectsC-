using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EditorMDI
{
  public partial class FormMDI : Form
  {
    public FormMDI()
    {
      InitializeComponent();
    }

    private void AyudaAcercaDe_Click(object sender, EventArgs e)
    {
      (new AcercaDe()).ShowDialog();
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ArchivoNuevo_Click(object sender, EventArgs e)
    {
      FormDocumento NuevoFormHijo;
      //Crear un nuevo formulario hijo
      NuevoFormHijo = new FormDocumento();
      //Título del formulario hijo
      NuevoFormHijo.Text = "Documento " + MdiChildren.Length.ToString();
      //Establecer el formulario padre del hijo
      NuevoFormHijo.MdiParent = this;
      //Mostrar el formulario hijo
      NuevoFormHijo.Show();
    }

    private void ArchivoNuevo2_Click(object sender, EventArgs e)
    {
      FormDocumento2 NuevoFormHijo;
      //Crear un nuevo formulario hijo
      NuevoFormHijo = new FormDocumento2();
      //Título del formulario hijo
      NuevoFormHijo.Text = "Documento " + MdiChildren.Length.ToString();
      //Establecer el formulario padre del hijo
      NuevoFormHijo.MdiParent = this;
      //Mostrar el formulario hijo
      NuevoFormHijo.Show();
    }

    private void ArchivoAbrir_Click(object sender, EventArgs e)
    {
      if (this.ActiveMdiChild == null)
      {
        MessageBox.Show("Cree primero un nuevo documento");
        return;
      }
      if (this.ActiveMdiChild.GetType().Equals(Type.GetType("EditorMDI.FormDocumento")))
      {
        // Formulario hijo activo
        FormDocumento FormHijo = (FormDocumento)ActiveMdiChild;

        // Si no hay ningún formulario hijo creado, crear uno
        // ejecutando el método ArchivoNuevo_Click
        if (FormHijo == null)
        {
          ArchivoNuevo.PerformClick();
          FormHijo = (FormDocumento)ActiveMdiChild;
        }
        ArchivoAbrirDoc(FormHijo);
      }
      if (this.ActiveMdiChild.GetType().Equals(Type.GetType("EditorMDI.FormDocumento2")))
      {
        // Formulario hijo activo
        FormDocumento2 FormHijo = (FormDocumento2)ActiveMdiChild;

        // Si no hay ningún formulario hijo creado, crear uno
        // ejecutando el método ArchivoNuevo_Click
        if (FormHijo == null)
        {
          ArchivoNuevo.PerformClick();
          FormHijo = (FormDocumento2)ActiveMdiChild;
        }
        ArchivoAbrirDoc2(FormHijo);
      }
    }

    private void ArchivoAbrirDoc(FormDocumento FormHijo)
    {
      // Mostrar el diálogo Abrir
      OpenFileDialog DlgAbrir = new OpenFileDialog();
      DlgAbrir.Filter = "ficheros txt (*.txt)|*.txt|ficheros rtf (*.rtf)|*.rtf";
      if (DlgAbrir.ShowDialog() == DialogResult.OK)
      {
        // Obtener el nombre del fichero
        string ruta = DlgAbrir.FileName;
        // Obtener el formato del fichero
        RichTextBoxStreamType formato = RichTextBoxStreamType.PlainText;
        if (DlgAbrir.FilterIndex == 2)
          formato = RichTextBoxStreamType.RichText;
        // Cargar el fichero
        FormHijo.rtbText.LoadFile(ruta, formato);
        // Mostrar el nombre del fichero en la barra de título
        FormHijo.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
        // Mostrar la ruta del fichero en la barra de estado
        this.etbarestPpal.Text = ruta;
        // Aún no ha sido modificado
        FormHijo.rtbText.Modified = false;
      }
    }

    private void ArchivoAbrirDoc2(FormDocumento2 FormHijo)
    {
      // PARA PRUEBAS SUPONEMOS EL MISMO TIPO DE DOCUMENTO: .txt y .rtf
      // Mostrar el diálogo Abrir
      OpenFileDialog DlgAbrir = new OpenFileDialog();
      DlgAbrir.Filter = "ficheros txt (*.txt)|*.txt|ficheros rtf (*.rtf)|*.rtf";
      if (DlgAbrir.ShowDialog() == DialogResult.OK)
      {
        // Obtener el nombre del fichero
        string ruta = DlgAbrir.FileName;
        // Obtener el formato del fichero
        RichTextBoxStreamType formato = RichTextBoxStreamType.PlainText;
        if (DlgAbrir.FilterIndex == 2)
          formato = RichTextBoxStreamType.RichText;
        // Cargar el fichero
        FormHijo.rtbText.LoadFile(ruta, formato);
        // Mostrar el nombre del fichero en la barra de título
        FormHijo.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
        // Mostrar la ruta del fichero en la barra de estado
        this.etbarestPpal.Text = ruta;
        // Aún no ha sido modificado
        FormHijo.rtbText.Modified = false;
      }
    }

    private void VerBarraDeHerramientas_Click(object sender, EventArgs e)
    {
      VerBarraDeHerramientas.Checked = !VerBarraDeHerramientas.Checked;
      BarraDeHerra.Visible = VerBarraDeHerramientas.Checked;
    }

    private void VerBarraDeEstado_Click(object sender, EventArgs e)
    {
      VerBarraDeEstado.Checked = !VerBarraDeEstado.Checked;
      BarraDeEstado.Visible = VerBarraDeEstado.Checked;
    }

    private void VentanaCascada_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.Cascade);
    }

    private void VentanaMosaicoHorizontal_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void VentanaMosaicoVertical_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileVertical);
    }

    private void VentanaOrganizar_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void FormMDI_MdiChildActivate(object sender, EventArgs e)
    {
      // Eliminar cualquier fusión previa
      ToolStripManager.RevertMerge(this.BarraDeHerra);
      // Barra de herramientas de la ventana hija activa
      ToolStrip bhHijaAc = null;
      IForm vHijaAc = null;
      if (this.ActiveMdiChild != null)
      {
        vHijaAc = (IForm)this.ActiveMdiChild;
        if (vHijaAc != null)
          bhHijaAc = vHijaAc.bhForm();
      }
      // Realizar la fusión si hay una ventana hija activa
      if (bhHijaAc != null)
      {
        ToolStripManager.Merge(bhHijaAc, this.BarraDeHerra);
      }
    }
  }
}