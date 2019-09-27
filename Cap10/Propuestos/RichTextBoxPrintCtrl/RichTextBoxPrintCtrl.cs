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
      public int posCarMin; // Primer car�cter del rango (0 para el principio del doc)
      public int posCarMax; // �ltimo car�cter del rango (-1 para el final del doc)
    }

    private struct FORMATRANGO
    {
      public IntPtr hdc; // Contexto de dispositivo (DC) actual para dibujar
      public IntPtr hdcDestino; // DC destino para el texto formateado
      public RECT rc; // Regi�n del DC para dibujar (en twips)
      public RECT rcPag; // Regi�n de todo el DC (tama�o de la p�gina) (en twips)
      public RANGODECARS rango; // Rango del texto a dibujar (ver la declaraci�n de arriba)
    }

    private const int WM_USER = 0x400;
    private const int EM_FORMATRANGE = WM_USER + 57;

    [DllImport("USER32", EntryPoint = "SendMessageA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

    // Procesar el contenido del RichtextBox para imprimirlo
    // Devolver el �ltimo car�cter escrito + 1 (la impresi�n en la siguiente p�gina comienza desde esta posici�n)
    public int Print(int carDesde, int carHasta, PrintPageEventArgs e)
    {

      // Fijar desde qu� car�cter se comienza y en qu� car�cter se finaliza
      RANGODECARS cRango;
      cRango.posCarMin = carDesde;
      cRango.posCarMax = carHasta;

      // Calcular el �rea de impresi�n
      RECT recParaImprimir;
      recParaImprimir.Top = System.Convert.ToInt32(e.MarginBounds.Top * unaPulgada);
      recParaImprimir.Bottom = System.Convert.ToInt32(e.MarginBounds.Bottom * unaPulgada);
      recParaImprimir.Left = System.Convert.ToInt32(e.MarginBounds.Left * unaPulgada);
      recParaImprimir.Right = System.Convert.ToInt32(e.MarginBounds.Right * unaPulgada);

      // Calcular el tama�o de la p�gina
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
      fmtRango.rc = recParaImprimir; // Indicar el �rea de impresi�n
      fmtRango.rcPag = recPagina; // Indicar el tama�o total de la p�gina

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

      // Devolver la posici�n + 1 del �ltimo car�cter impreso
      return res.ToInt32();
    }
  }
}