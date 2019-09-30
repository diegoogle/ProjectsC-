using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefServWCFConverTemps;

public partial class _Default : System.Web.UI.Page
{
  private ServWebWCFConverTempsClient cliente = null;
  private double nGrados;

  protected void Page_Load(object sender, EventArgs e)
  {
    etError.Text = "";
    cliente = new ServWebWCFConverTempsClient();

    cliente.ConvCentAFahrCompleted +=
      new EventHandler<ConvCentAFahrCompletedEventArgs>(
            cliente_ConvCentAFahrCompleted);
    cliente.ConvFahrACentCompleted +=
      new EventHandler<ConvFahrACentCompletedEventArgs>(
            cliente_ConvFahrACentCompleted);
    cliente.ResultadoDetalladoCompleted +=
      new EventHandler<ResultadoDetalladoCompletedEventArgs>(
            cliente_ResultadoDetalladoCompleted);
  }

  //protected void btConvertir_Click(object sender, EventArgs e)
  //{
  //  etError.Text = "";

  //  // Obtener el valor escrito en la caja de texto
  //  try
  //  {
  //    nGrados = Convert.ToDouble(ctGrados.Text);
  //    // Realizar la conversión invocando al método correspondiente
  //    if (boConvCF.Checked)
  //    {
  //      ctGrados.Text = Convert.ToString(cliente.ConvCentAFahr(nGrados));
  //    }
  //    if (boConvFC.Checked)
  //    {
  //      ctGrados.Text = Convert.ToString(cliente.ConvFahrACent(nGrados));
  //    }
  //  }
  //  catch (Exception exc)
  //  {
  //    etError.Text = exc.Message;
  //  }
  //}

  //protected void btDetalles_Click(object sender, EventArgs e)
  //{
  //  etError.Text = "";
  //  try
  //  {
  //    nGrados = Convert.ToDouble(ctGrados.Text);
  //    Detalles detalle = new Detalles();
  //    detalle.Grados = nGrados;
  //    detalle.SonCentigrados = boConvCF.Checked;
  //    ctGrados.Text = cliente.ResultadoDetallado(detalle).Literal;
  //  }
  //  catch (Exception exc)
  //  {
  //    etError.Text = exc.Message;
  //  }
  //}

  private void cliente_ConvCentAFahrCompleted(object sender, ConvCentAFahrCompletedEventArgs e)
  {
    if (e.Error != null)
    {
      etError.Text = "Error en la conversión de grados C a F";
    }
    else
    {
      ctGrados.Text = Convert.ToString(e.Result);
    }
  }

  private void cliente_ConvFahrACentCompleted(object sender, ConvFahrACentCompletedEventArgs e)
  {
    if (e.Error != null)
    {
      etError.Text = "Error en la conversión de grados F a C";
    }
    else
    {
      ctGrados.Text = Convert.ToString(e.Result);
    }
  }

  private void cliente_ResultadoDetalladoCompleted(object sender, ResultadoDetalladoCompletedEventArgs e)
  {
    if (e.Error != null)
    {
      etError.Text = "Error al obtener detalles del resultado";
    }
    else
    {
      ctGrados.Text = e.Result.Literal;
    }
  }

  protected void btConvertir_Click(object sender, EventArgs e)
  {
    etError.Text = "";

    // Obtener el valor escrito en la caja de texto
    try
    {
      nGrados = Convert.ToDouble(ctGrados.Text);
      // Realizar la conversión invocando al método correspondiente
      if (boConvCF.Checked)
      {
        cliente.ConvCentAFahrAsync(nGrados);
      }
      if (boConvFC.Checked)
      {
        cliente.ConvFahrACentAsync(nGrados);
      }
    }
    catch (Exception exc)
    {
      etError.Text = exc.Message;
    }
  }

  protected void btDetalles_Click(object sender, EventArgs e)
  {
    etError.Text = "";
    try
    {
      nGrados = Convert.ToDouble(ctGrados.Text);
      Detalles detalle = new Detalles();
      detalle.Grados = nGrados;
      detalle.SonCentigrados = boConvCF.Checked;
      cliente.ResultadoDetalladoAsync(detalle);
    }
    catch (Exception exc)
    {
      etError.Text = exc.Message;
    }
  }
}