using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prestamo
{
  public partial class Prestamo : Form
  {
    private double credito;
    private int periodoMax, periodoMin;
    private double interesMin, interesMax;
    private double incremento;
    private int tiposIntrs;
    private int añosMeses;
    private bool tablaPagos;
    private double pagoMensual;

    public Prestamo()
    {
      InitializeComponent();
    }

    private void Prestamo_Load(object sender, EventArgs e)
    {
      StartPosition = FormStartPosition.CenterScreen;
      tiposIntrs = 18;
      añosMeses = 4;
      PrestamoEnAños.Enabled = false;
      cgDuracionPrestamo.Text = "Años del préstamo";
      ctCredito.Text = "6000";
      ctPeriodoMax.Text = "1";
      ctPeriodoMin.Text = "1";
      ctInteresMax.Text = "7,00";
      ctInteresMin.Text = "0,00";
      lsdIncremento.SelectedIndex = 2;
      IniciarTabla(tiposIntrs, añosMeses);
      tablaPagos = false;
    }

    private void OpcionesSalir_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void IniciarTabla(int filas, int cols)
    {
      int f, c;
      DataGridViewTextBoxColumn Columna;

      // Añadir columnas a la tabla
      for (c = 1; c <= cols; c++)
      {
        Columna = new DataGridViewTextBoxColumn();
        Columna.HeaderText = "Columna " + c;
        Columna.Width = 93;
        Columna.ReadOnly = true;
        Columna.SortMode = DataGridViewColumnSortMode.NotSortable;
        tablaPrestamo.Columns.Add(Columna);
      }
      // Añadir filas a la tabla
      string[] fila = new string[cols + 1];
      for (f = 1; f <= filas; f++)
        tablaPrestamo.Rows.Add(fila);
    }

    private void OpcionesInstruc_Click(object sender, EventArgs e)
    {
      string mensaje;
      string NL = Environment.NewLine;
      mensaje = "Introduzca el crédito, la duración del préstamo y el tipo" + NL;
      mensaje += "de interés. Pulse el botón [Pagos] para visualizar" + NL;
      mensaje += "los pagos mensuales en la rejilla." + NL + NL;
      mensaje += "Elija un pago mensual y pulse el botón [Amortización]" + NL;
      mensaje += "para visualizar el plan de amortización para el interés" + NL;
      mensaje += "y períodos correspondientes al pago elegido." + NL + NL;
      mensaje += "Para copiar datos en el portapapeles, seleccione las celdas" + NL;
      mensaje += "que desee y pulse las teclas Ctrl+c." + NL;
      MessageBox.Show(mensaje, "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void PrestamoEnAñosMeses_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem ordenMenu = (ToolStripMenuItem)sender;
      string tituloMarco = "";

      if (ordenMenu.Name == "PrestamoEnAños")
      {
        PrestamoEnAños.Enabled = false;
        PrestamoEnMeses.Enabled = true;
        tituloMarco = "Años del préstamo";
      }
      else if (ordenMenu.Name == "PrestamoEnMeses")
      {
        PrestamoEnAños.Enabled = true;
        PrestamoEnMeses.Enabled = false;
        tituloMarco = "Meses del préstamo";
      }

      cgDuracionPrestamo.Text = tituloMarco;
    }

    private void btCalculoPagos_Click(object sender, EventArgs e)
    {
      // Actualizar las variables con los valores de los controles
      try
      {
        credito = double.Parse(ctCredito.Text);
        periodoMin = int.Parse(ctPeriodoMin.Text);
        periodoMax = int.Parse(ctPeriodoMax.Text);
        interesMin = double.Parse(ctInteresMin.Text);
        interesMax = double.Parse(ctInteresMax.Text);
        incremento = double.Parse(lsdIncremento.Text);

        // Comprobar que los datos son válidos
        if (credito <= 0 || periodoMin <= 0 || periodoMax <= 0 || periodoMax < periodoMin || interesMin < 0 || interesMax < 0 || interesMax < interesMin)
          throw new FormatException();
      }
      catch (FormatException)
      {
        MessageBox.Show("Datos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      // Calcular el nº de tipos de interés y de períodos
      tiposIntrs = System.Convert.ToInt32(((interesMax - interesMin) / incremento) + 1);
      añosMeses = (periodoMax - periodoMin) + 1;

      // Tamaño mínimo de la tabla: los valores iniciales
      int filas = tiposIntrs;
      int cols = añosMeses;
      if (tiposIntrs < 18)
        filas = 18;
      if (añosMeses < 4)
        cols = 4;

      // Crear de nuevo la tabla
      tablaPrestamo.Columns.Clear();
      IniciarTabla(filas, cols);

      // Almacenar en la columna fija los tipos de interés
      string s;
      s = string.Format("{0,5:P2}", interesMin / 100);
      tablaPrestamo.Rows[0].HeaderCell.Value = s;
      for (int f = 1; f <= tiposIntrs - 1; f++)
      {
        s = string.Format("{0,5:P2}", (interesMin + incremento * f) / 100);
        tablaPrestamo.Rows[f].HeaderCell.Value = s;
      }

      // Almacenar en la fila fija las distintas duraciones del préstamo
      string periodo = " años";
      if (PrestamoEnAños.Enabled)
        periodo = " meses";
      for (int c = 0; c <= añosMeses - 1; c++)
        tablaPrestamo.Columns[c].HeaderText = (periodoMin + c) + periodo;

      // Los períodos ¿en qué vienen dados? ¿En años o en meses?
      int P = 0;
      if (!PrestamoEnAños.Enabled)
        P = 12; // son años
      else
        P = 1; // son meses

      // Calcular pagos
      double interes = 0.0;
      double pagoMensual = 0.0;
      int meses;
      for (int f = 0; f <= tiposIntrs - 1; f++)
      {
        // Obtener el tipo de interés de la fila actual
        string sinteres = tablaPrestamo.Rows[f].HeaderCell.Value.ToString();
        sinteres = sinteres.Substring(0, sinteres.IndexOf('%'));
        interes = double.Parse(sinteres) / 100 / 12;
        // Calcular los pagos para este tipo de interés
        for (int c = 0; c <= añosMeses - 1; c++)
        {
          // Obtener la duración del préstamo
          string smeses = tablaPrestamo.Columns[c].HeaderText;
          smeses = smeses.Substring(0, smeses.IndexOf(' '));
          meses = int.Parse(smeses) * P;
          // Calcular la cantidad a pagar mensualmente
          if (interes == 0.0)
            pagoMensual = credito / meses;
          else
            pagoMensual = credito * (interes / (1 - (1 / (Math.Pow(1.0 + interes, System.Convert.ToDouble(meses))))));
          // Ponerla en la tabla (se redondea a dos decimales)
          s = string.Format("{0,14:N2}", pagoMensual);
          tablaPrestamo.Rows[f].Cells[c].Value = s;
        }
      }
      tablaPagos = true;
    }

    private void tablaPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!tablaPagos) return;
      try
      {
        pagoMensual = double.Parse(tablaPrestamo.CurrentCell.Value.ToString());
        btCalculoAmort.Enabled = true;
      }
      catch (NullReferenceException)
      {
        btCalculoAmort.Enabled = false;
        MessageBox.Show("La celda no contiene datos válidos");
      }
    }

    private void btCalculoAmort_Click(object sender, EventArgs e)
    {
      // Posición de la celda seleccionada
      Point pos = tablaPrestamo.CurrentCellAddress;
      // Obtener el tipo de interés correspondiente a la celda seleccionada
      string sinteres = tablaPrestamo.Rows[pos.Y].HeaderCell.Value.ToString();
      sinteres = sinteres.Substring(0, sinteres.IndexOf('%'));
      double interes = double.Parse(sinteres) / 100 / 12;

      // Obtener el período correspondiente a la celda seleccionada
      int P = 0;
      if (!PrestamoEnAños.Enabled)
        P = 12; // son años
      else
        P = 1; // son meses

      string smeses = tablaPrestamo.Columns[pos.X].HeaderText;
      smeses = smeses.Substring(0, smeses.IndexOf(' '));
      int meses = int.Parse(smeses) * P;
      int filas = meses;
      int cols = 4;
      if (filas < 18)
        filas = 18;

      // Crear de nuevo la tabla
      tablaPrestamo.Columns.Clear();
      IniciarTabla(filas, cols);

      // Almacenar/mostrar en la columna fija los meses
      for (int mes = 0; mes <= meses - 1; mes++)
        tablaPrestamo.Rows[mes].HeaderCell.Value = string.Format("{0,5:D}", mes + 1);

      // Almacenar en la fila fija las distintas cabeceras
      string[] cab = new string[] { "Capital", "Intereses", "Capital pendiente", "Total intereses" };
      for (int col = 0; col <= 3; col++)
        tablaPrestamo.Columns[col].HeaderText = cab[col];

      // Calcular y mostrar la tabla de amortización.
      // La columna 0 de la tabla préstamo contiene el capital
      // pendiente y la 1 contiene el interés mensual a pagar
      double interesesMensuales = 0;
      double creditoPendiente = credito;
      double capitalMensualAmort = 0;
      double totalIntereses = 0;
      for (int mes = 0; mes <= meses - 1; mes++)
      {
        // Cálculo del interés a pagar en el mes actual
        interesesMensuales = creditoPendiente * interes;
        // Cálculo del capital en el mes actual
        capitalMensualAmort = pagoMensual - interesesMensuales;
        // Cálculo del capital pendiente de pagar
        creditoPendiente -= pagoMensual - interesesMensuales;
        // Cálculo de los intereses totales pagados
        totalIntereses += interesesMensuales;
        // Capital mensual amortizado
        tablaPrestamo.Rows[mes].Cells[0].Value = string.Format("{0,14:N2}", capitalMensualAmort);
        // Intereses mensuales amortizados
        tablaPrestamo.Rows[mes].Cells[1].Value = string.Format("{0,14:N2}", interesesMensuales);
        // Capital pendiente después de este pago
        tablaPrestamo.Rows[mes].Cells[2].Value = string.Format("{0,14:N2}", creditoPendiente);
        // Total intereses abonados después de este pago
        tablaPrestamo.Rows[mes].Cells[3].Value = string.Format("{0,14:N2}", totalIntereses);
      }
      btCalculoAmort.Enabled = false;
      tablaPagos = false;
    }

    private void AyudaAcercaDe_Click(object sender, EventArgs e)
    {
      string mensaje;
      string NL = Environment.NewLine;
      mensaje = "Aplicación Préstamo. Versión 1.0." + NL;
      mensaje += "Copyright (c) Fco. Javier Ceballos, 2010";
      MessageBox.Show(mensaje, "Acerca de Préstamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}