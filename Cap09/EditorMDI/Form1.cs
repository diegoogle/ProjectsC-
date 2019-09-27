using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      // Crear un nuevo formulario hijo
      NuevoFormHijo = new FormDocumento();
      // Título del formulario hijo
      NuevoFormHijo.Text = "Documento " + MdiChildren.Length.ToString();
      // Establecer el formulario padre del hijo
      NuevoFormHijo.MdiParent = this;
      // Mostrar el formulario hijo
      NuevoFormHijo.Show();
    }

    private void ArchivoAbrir_Click(object sender, EventArgs e)
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
      BarraDeHerraMdiPadre.Visible = VerBarraDeHerramientas.Checked;
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
      ToolStripManager.RevertMerge(this.BarraDeHerraMdiPadre);
      // Ventana hija activa
      FormDocumento vHijaAc = (FormDocumento)this.ActiveMdiChild;
      // Realizar la fusión si hay una ventana hija activa
      if (vHijaAc != null)
        ToolStripManager.Merge(vHijaAc.BarraDeHerraMdiHila,
                               this.BarraDeHerraMdiPadre);
    }
  }
}
