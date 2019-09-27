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
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      menuFuente.Text = ctEditor.Font.SystemFontName;
      menuFuente.Items.AddRange(new object[] {
        "Courier New", "Arial", ctEditor.Font.SystemFontName });
      menuTam.Text = ctEditor.Font.Size.ToString();
      menuTam.Items.AddRange(new object[] {
        "16", "24", ctEditor.Font.Size.ToString() });
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

    private void menuFuente_SelectedIndexChanged(object sender, EventArgs e)
    {
      ctEditor.Font = new Font(menuFuente.SelectedItem.ToString(), ctEditor.Font.Size, ctEditor.Font.Style);
    }

    private void menuTam_SelectedIndexChanged(object sender, EventArgs e)
    {
      ctEditor.Font = new Font(ctEditor.Font.SystemFontName, float.Parse(menuTam.SelectedItem.ToString()), ctEditor.Font.Style);
    }

    private void menuContexEdicion_Opening(object sender, CancelEventArgs e)
    {
      bool textoSeleccionado = (ctEditor.SelectedText.Length != 0);
      ContextEdicionCopiar.Enabled = textoSeleccionado;
      ContextEdicionCortar.Enabled = textoSeleccionado;
    }
  }
}
