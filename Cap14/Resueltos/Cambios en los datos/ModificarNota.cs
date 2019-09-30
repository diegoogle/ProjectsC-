using System;
using System.Windows.Forms;

namespace ApEntidades
{
  public partial class ModificarNota : Form
  {
    public float Nota { get; set; }

    public ModificarNota(string nombreAlum, string nombreAsig, float nota)
    {
      InitializeComponent();
      ctAlum.Text = nombreAlum;
      ctAsig.Text = nombreAsig;
      Nota = nota;
    }

    private void btAceptar_Click(object sender, EventArgs e)
    {
      float nota = Nota;
      if (Single.TryParse(ctNota.Text, out nota) && nota >= 0 && nota <= 10)
        Nota = nota;
    }
  }
}
