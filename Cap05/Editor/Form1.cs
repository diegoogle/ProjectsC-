using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
  public partial class Form1 : Form
  {
    private Font fuentePr;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      fuentePr = ctEditor.Font;
    }

    private void ArchivoSalir_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void EdicionCortar_Click(object sender, EventArgs e)
    {
      ctEditor.Cut();
    }

    private void EdicionCopiar_Click(object sender, EventArgs e)
    {
      ctEditor.Copy();
    }

    private void EdicionPegar_Click(object sender, EventArgs e)
    {
      ctEditor.Paste();
    }

    private void OpFuCourierNew_Click(object sender, EventArgs e)
    {
      Font f = ctEditor.Font;
      ctEditor.Font = new Font("Courier New", f.Size, f.Style);
      OpFuCourierNew.Checked = true;
      OpFuArial.Checked = false;
      OpFuPredeterminada.Checked = false;
    }

    private void OpFuArial_Click(object sender, EventArgs e)
    {
      Font f = ctEditor.Font;
      ctEditor.Font = new Font("Arial", f.Size, f.Style);
      OpFuCourierNew.Checked = false;
      OpFuArial.Checked = true;
      OpFuPredeterminada.Checked = false;
    }

    private void OpFuPredeterminada_Click(object sender, EventArgs e)
    {
      Font f = ctEditor.Font;
      ctEditor.Font = new Font(fuentePr.SystemFontName, f.Size, f.Style);
      OpFuCourierNew.Checked = false;
      OpFuArial.Checked = false;
      OpFuPredeterminada.Checked = true;
    }

    private void OpTam16_Click(object sender, EventArgs e)
    {
      Font f = ctEditor.Font;
      ctEditor.Font = new Font(f.SystemFontName, 16.0F, f.Style);
      OpTam16.Checked = true;
      OpTam24.Checked = false;
      OpTamPredeterminado.Checked = false;
    }

    private void OpTam24_Click(object sender, EventArgs e)
    {
      Font f = ctEditor.Font;
      ctEditor.Font = new Font(f.SystemFontName, 24.0F, f.Style);
      OpTam16.Checked = false;
      OpTam24.Checked = true;
      OpTamPredeterminado.Checked = false;
    }

    private void OpTamPredeterminado_Click(object sender, EventArgs e)
    {
      Font f = ctEditor.Font;
      ctEditor.Font = new Font(f.SystemFontName, fuentePr.Size, f.Style);
      OpTam16.Checked = false;
      OpTam24.Checked = false;
      OpTamPredeterminado.Checked = true;
    }

    private void menuEdicion_DropDownOpening(object sender, EventArgs e)
    {
      bool textoSeleccionado = (ctEditor.SelectedText.Length != 0);
      EdicionCopiar.Enabled = textoSeleccionado;
      EdicionCortar.Enabled = textoSeleccionado;
    }

    private void EdicionDeshacer_Click(object sender, EventArgs e)
    {
      if (ctEditor.CanUndo) ctEditor.Undo();
    }
  }
}
