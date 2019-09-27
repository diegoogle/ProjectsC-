using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Drawing.Printing;

namespace RichTextBoxPrintCtrl
{
  public partial class RichTextBoxPrintCtrl : RichTextBox
  {
    public RichTextBoxPrintCtrl()
    {
      InitializeComponent();
    }

    // Convertir las unidades usadas por .NET Framework (1/100 pulgadas)
    // y las unidades usadas por las llamadas de la API Win32 ((twips) 1/1440 pulgadas)
    private const double unaPulgada = 14.4;

    private struct RECT
    {
      public int Left;
      public int Top;
      public int Right;
      public int Bottom;
    }

    private struct RANGODECARS
    {
      public int posCarMin; // Primer carácter del rango (0 para el principio del doc)
      public int posCarMax; // Último carácter del rango (-1 para el final del doc)
    }

    private struct FORMATRANGO
    {
      public IntPtr hdc; // Contexto de dispositivo (DC) actual para dibujar
      public IntPtr hdcDestino; // DC destino para el texto formateado
      public RECT rc; // Región del DC para dibujar (en twips)
      public RECT rcPag; // Región de todo el DC (tamaño de la página) (en twips)
      public RANGODECARS rango; // Rango del texto a dibujar (ver la declaración de arriba)
    }

    private const int WM_USER = 0x400;
    private const int EM_FORMATRANGE = WM_USER + 57;

    [DllImport("USER32", EntryPoint = "SendMessageA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

    // Procesar el contenido del RichtextBox para imprimirlo
    // Devolver el último carácter escrito + 1 (la impresión en la siguiente página comienza desde esta posición)
    public int Print(int carDesde, int carHasta, PrintPageEventArgs e)
    {

      // Fijar desde qué carácter se comienza y en qué carácter se finaliza
      RANGODECARS cRango;
      cRango.posCarMin = carDesde;
      cRango.posCarMax = carHasta;

      // Calcular el área de impresión
      RECT recParaImprimir;
      recParaImprimir.Top = System.Convert.ToInt32(e.MarginBounds.Top * unaPulgada);
      recParaImprimir.Bottom = System.Convert.ToInt32(e.MarginBounds.Bottom * unaPulgada);
      recParaImprimir.Left = System.Convert.ToInt32(e.MarginBounds.Left * unaPulgada);
      recParaImprimir.Right = System.Convert.ToInt32(e.MarginBounds.Right * unaPulgada);

      // Calcular el tamaño de la página
      RECT recPagina;
      recPagina.Top = System.Convert.ToInt32(e.PageBounds.Top * unaPulgada);
      recPagina.Bottom = System.Convert.ToInt32(e.PageBounds.Bottom * unaPulgada);
      recPagina.Left = System.Convert.ToInt32(e.PageBounds.Left * unaPulgada);
      recPagina.Right = System.Convert.ToInt32(e.PageBounds.Right * unaPulgada);

      IntPtr hdc = e.Graphics.GetHdc();

      FORMATRANGO fmtRango;
      fmtRango.rango = cRango; // Indicar el rango de caracteres
      fmtRango.hdc = hdc; // Usar el mismo DC para cuantificar y procesar el texto
      fmtRango.hdcDestino = hdc; // Apunta al hDC de la impresora
      fmtRango.rc = recParaImprimir; // Indicar el área de impresión
      fmtRango.rcPag = recPagina; // Indicar el tamaño total de la página

      IntPtr res = IntPtr.Zero;

      IntPtr wparam = IntPtr.Zero;
      wparam = new IntPtr(1);

      // Mueve el puntero a la estructura FORMATRANGO en memoria
      IntPtr lparam = IntPtr.Zero;
      lparam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRango));
      Marshal.StructureToPtr(fmtRango, lparam, false);

      // Enviar los datos procesados para imprimir
      res = SendMessage(Handle, EM_FORMATRANGE, wparam, lparam);

      // Liberar el bloque de meoria asignado
      Marshal.FreeCoTaskMem(lparam);

      // Liberar el manejador del DC obtenido en una llamada anterior
      e.Graphics.ReleaseHdc(hdc);

      // Devolver la posición + 1 del último carácter impreso
      return res.ToInt32();
    }
  }
}