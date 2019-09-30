using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page, ICallbackEventHandler
{
  private string[] elementos;

  protected void Page_Load(object sender, EventArgs e)
  {
    if (!IsCallback)
    {
      // Asignar la llamada en segundo plano al evento onchange de la lista
      this.ListaDeOpciones.Attributes["onchange"] = JavaScriptCallback();
    }
  }

  private string JavaScriptCallback()
  {
    // Obtener el Id de la lista
    string IdLista = this.ListaDeOpciones.ClientID;
    // Construir la sentencia javascript para obtener el elemento seleccionado en la lista
    string opcionLista = string.Format("document.getElementById('{0}').value", IdLista);
    // Construir la llamada en segundo plano hacia el servidor
    string callback = Page.ClientScript.GetCallbackEventReference(this, opcionLista,
                      "CargarTabla", "null", "Error", true);
    // Construir la llamada en segundo plano en javascript
    return string.Format("javascript:{0}", callback);
  }

  public string GetCallbackResult()
  {
    return DevuelveXML(elementos);
  }

  public void RaiseCallbackEvent(string op)
  {
    switch (op.ToLower())
    {
      case "aptos":
        elementos = new string[] { "Felipe Gracia", "Nuria Pérez", "José Santiesteban", "Verónica Gutiérrez", "Israel Domínguez", "Carmela Ruíz" };
        break;
      case "no aptos":
        elementos = new string[] { "Enrique Pérez", "Elena Gutiérrez", "Andrea Ramos", "Luis Sánchez", "Antonio Delgado" };
        break;
    }
  }

  // Función para crear el XML a devolver
  private string DevuelveXML(string[] ElementosMatriz)
  {
    System.Xml.Serialization.XmlSerializer miSerializador;
    System.IO.TextWriter miEscritorTexto;
    miSerializador = new System.Xml.Serialization.XmlSerializer(typeof(string[]));
    miEscritorTexto = new System.IO.StreamWriter(@"C:\Inetpub\wwwroot\AJAX2\App_Data\respuesta.txt");
    miSerializador.Serialize(miEscritorTexto, ElementosMatriz);
    miEscritorTexto.Close();
    // Ojo: intr0duce las etiquetas <string> </string>. Cambiar: getElementsByTagName("string")
    string respuestaXML = System.IO.File.ReadAllText(@"C:\Inetpub\wwwroot\AJAX2\App_Data\respuesta.txt");

    return respuestaXML;
  }
}
