using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
  public partial class Form1 : Form
  {
    private int posUltimoCarEscrito;

    public Form1()
    {
      InitializeComponent();
    }

    private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      posUltimoCarEscrito = 0;
    }

    private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      // Imprimir el contenido del RichTextBox. Tomar nota del último carácter escrito.
      posUltimoCarEscrito = RichTextBoxPrintCtrl1.Print(posUltimoCarEscrito, RichTextBoxPrintCtrl1.TextLength, e);

      // Si hay más páginas, imprimirlas
      if (posUltimoCarEscrito < RichTextBoxPrintCtrl1.TextLength)
      {
        e.HasMorePages = true;
      }
      else
      {
        e.HasMorePages = false;
      }
    }

    private void btnPageSetup_Click(System.Object sender, System.EventArgs e)
    {
      PageSetupDialog1.ShowDialog();
    }

    private void btnPrint_Click(System.Object sender, System.EventArgs e)
    {
      if (PrintDialog1.ShowDialog() == DialogResult.OK)
      {
        PrintDocument1.Print();
      }
    }

    private void btnPrintPreview_Click(System.Object sender, System.EventArgs e)
    {
      PrintPreviewDialog1.ShowDialog();
    }
  }
}