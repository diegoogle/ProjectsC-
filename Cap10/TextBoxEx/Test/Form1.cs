using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btCalcular_Click(object sender, EventArgs e)
    {
      try
      {
        TextBoxEx3.Text = Convert.ToString(Convert.ToDouble(TextBoxEx1.Text) -
                                           Convert.ToDouble(TextBoxEx2.Text));
      }
      catch (Exception)
      {
        MessageBox.Show("Debe introducir cantidades válidas");
      }
    }
  }
}
