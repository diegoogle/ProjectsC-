using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace TextBoxEx
{
  public class TextBoxEx : TextBox
  {
    private Color _ColorControlEnfocado = Color.LightCyan;
    private Color _ColorControlDesenfocado = Color.White;
    private bool _AplicarColorFoco = false;

    public TextBoxEx()
    {
      this.Enter += new System.EventHandler(this.TextBoxEx_Enter);
      this.Leave += new System.EventHandler(this.TextBoxEx_Leave);
    }

    [Category("Apariencia"),
     Description("Almacena el color que mostrará el control " +
                 "cuando reciba el foco, sólo si la propiedad " +
                 "AplicarColorFoco vale true")]
    public Color ColorControlEnfocado
    {
      get { return _ColorControlEnfocado; }
      set { _ColorControlEnfocado = value; }
    }

    [Category("Apariencia"),
     Description("Almacena el color que mostrará el control " +
                 "cuando pierda el foco, sólo si la propiedad " +
                 "AplicarColorFoco vale true")]
    public Color ColorControlDesenfocado
    {
      get { return _ColorControlDesenfocado; }
      set { _ColorControlDesenfocado = value; }
    }

    [Category("Apariencia"),
     Description("Cuando su valor es true, habilita las " +
                  "propiedades ColorControlEnfocado y ColorControlDesenfocado")]
    public bool AplicarColorFoco
    {
      get { return _AplicarColorFoco; }
      set { _AplicarColorFoco = value; }
    }

    private void TextBoxEx_Enter(object sender, EventArgs e)
    {
      if (!AplicarColorFoco) return;
      BackColor = ColorControlEnfocado;
    }

    private void TextBoxEx_Leave(object sender, EventArgs e)
    {
      if (!AplicarColorFoco) return;
      BackColor = ColorControlDesenfocado;
    }
  }
}
