using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApWindowsMDI
{
  public partial class FormPadre : Form
  {
    public FormPadre()
    {
      InitializeComponent();
    }

    private void ArchivoNuevo_Click(object sender, EventArgs e)
    {
      FormHijo NuevoFormHijo;
      // Crear un nuevo formulario hijo
      NuevoFormHijo = new FormHijo();
      // Título del formulario hijo
      NuevoFormHijo.Text = "Form " + MdiChildren.Length.ToString();
      // Establecer el formulario padre del hijo
      NuevoFormHijo.MdiParent = this;
      // Mostrar el formulario hijo
      NuevoFormHijo.Show();
    }

    private void ArchivoCerrar_Click(object sender, EventArgs e)
    {
      FormHijo FormHijoActivo = (FormHijo)ActiveMdiChild;
      if (FormHijoActivo != null) FormHijoActivo.Close();
    }

    private void VentanaCascada_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.Cascade);
    }

    private void VentanaHorizontal_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void VentanaVertical_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileVertical);
    }
  }
}
