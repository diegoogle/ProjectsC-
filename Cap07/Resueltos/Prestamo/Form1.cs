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
    private int a�osMeses;
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
      a�osMeses = 4;
      PrestamoEnA�os.Enabled = false;
      cgDuracionPrestamo.Text = "A�os del pr�stamo";
      ctCredito.Text = "6000";
      ctPeriodoMax.Text = "1";
      ctPeriodoMin.Text = "1";
      ctInteresMax.Text = "7,00";
      ctInteresMin.Text = "0,00";
      lsdIncremento.SelectedIndex = 2;
      IniciarTabla(tiposIntrs, a�osMeses);
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

      // A�adir columnas a la tabla
      for (c = 1; c <= cols; c++)
      {
        Columna = new DataGridViewTextBoxColumn();
        Columna.HeaderText = "Columna " + c;
        Columna.Width = 93;
        Columna.ReadOnly = true;
        Columna.SortMode = DataGridViewColumnSortMode.NotSortable;
        tablaPrestamo.Columns.Add(Columna);
      }
      // A�adir filas a la tabla
      string[] fila = new string[cols + 1];
      for (f = 1; f <= filas; f++)
        tablaPrestamo.Rows.Add(fila);
    }

    private void OpcionesInstruc_Click(object sender, EventArgs e)
    {
      string mensaje;
      string NL = Environment.NewLine;
      mensaje = "Introduzca el cr�dito, la duraci�n del pr�stamo y el tipo" + NL;
      mensaje += "de inter�s. Pulse el bot�n [Pagos] para visualizar" + NL;
      mensaje += "los pagos mensuales en la rejilla." + NL + NL;
      mensaje += "Elija un pago mensual y pulse el bot�n [Amortizaci�n]" + NL;
      mensaje += "para visualizar el plan de amortizaci�n para el inter�s" + NL;
      mensaje += "y per�odos correspondientes al pago elegido." + NL + NL;
      mensaje += "Para copiar datos en el portapapeles, seleccione las celdas" + NL;
      mensaje += "que desee y pulse las teclas Ctrl+c." + NL;
      MessageBox.Show(mensaje, "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void PrestamoEnA�osMeses_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem ordenMenu = (ToolStripMenuItem)sender;
      string tituloMarco = "";

      if (ordenMenu.Name == "PrestamoEnA�os")
      {
        PrestamoEnA�os.Enabled = false;
        PrestamoEnMeses.Enabled = true;
        tituloMarco = "A�os del pr�stamo";
      }
      else if (ordenMenu.Name == "PrestamoEnMeses")
      {
        PrestamoEnA�os.Enabled = true;
        PrestamoEnMeses.Enabled = false;
        tituloMarco = "Meses del pr�stamo";
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

        // Comprobar que los datos son v�lidos
        if (credito <= 0 || periodoMin <= 0 || periodoMax <= 0 || periodoMax < periodoMin || interesMin < 0 || interesMax < 0 || interesMax < interesMin)
          throw new FormatException();
      }
      catch (FormatException)
      {
        MessageBox.Show("Datos no v�lidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      // Calcular el n� de tipos de inter�s y de per�odos
      tiposIntrs = System.Convert.ToInt32(((interesMax - interesMin) / incremento) + 1);
      a�osMeses = (periodoMax - periodoMin) + 1;

      // Tama�o m�nimo de la tabla: los valores iniciales
      int filas = tiposIntrs;
      int cols = a�osMeses;
      if (tiposIntrs < 18)
        filas = 18;
      if (a�osMeses < 4)
        cols = 4;

      // Crear de nuevo la tabla
      tablaPrestamo.Columns.Clear();
      IniciarTabla(filas, cols);

      // Almacenar en la columna fija los tipos de inter�s
      string s;
      s = string.Format("{0,5:P2}", interesMin / 100);
      tablaPrestamo.Rows[0].HeaderCell.Value = s;
      for (int f = 1; f <= tiposIntrs - 1; f++)
      {
        s = string.Format("{0,5:P2}", (interesMin + incremento * f) / 100);
        tablaPrestamo.Rows[f].HeaderCell.Value = s;
      }

      // Almacenar en la fila fija las distintas duraciones del pr�stamo
      string periodo = " a�os";
      if (PrestamoEnA�os.Enabled)
        periodo = " meses";
      for (int c = 0; c <= a�osMeses - 1; c++)
        tablaPrestamo.Columns[c].HeaderText = (periodoMin + c) + periodo;

      // Los per�odos �en qu� vienen dados? �En a�os o en meses?
      int P = 0;
      if (!PrestamoEnA�os.Enabled)
        P = 12; // son a�os
      else
        P = 1; // son meses

      // Calcular pagos
      double interes = 0.0;
      double pagoMensual = 0.0;
      int meses;
      for (int f = 0; f <= tiposIntrs - 1; f++)
      {
        // Obtener el tipo de inter�s de la fila actual
        string sinteres = tablaPrestamo.Rows[f].HeaderCell.Value.ToString();
        sinteres = sinteres.Substring(0, sinteres.IndexOf('%'));
        interes = double.Parse(sinteres) / 100 / 12;
        // Calcular los pagos para este tipo de inter�s
        for (int c = 0; c <= a�osMeses - 1; c++)
        {
          // Obtener la duraci�n del pr�stamo
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
        MessageBox.Show("La celda no contiene datos v�lidos");
      }
    }

    private void btCalculoAmort_Click(object sender, EventArgs e)
    {
      // Posici�n de la celda seleccionada
      Point pos = tablaPrestamo.CurrentCellAddress;
      // Obtener el tipo de inter�s correspondiente a la celda seleccionada
      string sinteres = tablaPrestamo.Rows[pos.Y].HeaderCell.Value.ToString();
      sinteres = sinteres.Substring(0, sinteres.IndexOf('%'));
      double interes = double.Parse(sinteres) / 100 / 12;

      // Obtener el per�odo correspondiente a la celda seleccionada
      int P = 0;
      if (!PrestamoEnA�os.Enabled)
        P = 12; // son a�os
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

      // Calcular y mostrar la tabla de amortizaci�n.
      // La columna 0 de la tabla pr�stamo contiene el capital
      // pendiente y la 1 contiene el inter�s mensual a pagar
      double interesesMensuales = 0;
      double creditoPendiente = credito;
      double capitalMensualAmort = 0;
      double totalIntereses = 0;
      for (int mes = 0; mes <= meses - 1; mes++)
      {
        // C�lculo del inter�s a pagar en el mes actual
        interesesMensuales = creditoPendiente * interes;
        // C�lculo del capital en el mes actual
        capitalMensualAmort = pagoMensual - interesesMensuales;
        // C�lculo del capital pendiente de pagar
        creditoPendiente -= pagoMensual - interesesMensuales;
        // C�lculo de los intereses totales pagados
        totalIntereses += interesesMensuales;
        // Capital mensual amortizado
        tablaPrestamo.Rows[mes].Cells[0].Value = string.Format("{0,14:N2}", capitalMensualAmort);
        // Intereses mensuales amortizados
        tablaPrestamo.Rows[mes].Cells[1].Value = string.Format("{0,14:N2}", interesesMensuales);
        // Capital pendiente despu�s de este pago
        tablaPrestamo.Rows[mes].Cells[2].Value = string.Format("{0,14:N2}", creditoPendiente);
        // Total intereses abonados despu�s de este pago
        tablaPrestamo.Rows[mes].Cells[3].Value = string.Format("{0,14:N2}", totalIntereses);
      }
      btCalculoAmort.Enabled = false;
      tablaPagos = false;
    }

    private void AyudaAcercaDe_Click(object sender, EventArgs e)
    {
      string mensaje;
      string NL = Environment.NewLine;
      mensaje = "Aplicaci�n Pr�stamo. Versi�n 1.0." + NL;
      mensaje += "Copyright (c) Fco. Javier Ceballos, 2010";
      MessageBox.Show(mensaje, "Acerca de Pr�stamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}