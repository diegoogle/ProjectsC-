using System;

public partial class obtenerDatos : System.Web.UI.Page
{
  string[] elementos;
  protected void Page_Load(object sender, EventArgs e)
  {
    string op = Request.Params["opcion"];
    switch (op.ToLower())
    {
      case "aptos":
        elementos = new string[] { "Felipe Gracia", "Nuria Pérez", "José Santiesteban", "Verónica Gutiérrez", "Israel Domínguez", "Carmela Ruíz" };
        break;
      case "no aptos":
        elementos = new string[] { "Enrique Pérez", "Elena Gutiérrez", "Andrea Ramos", "Luis Sánchez", "Antonio Delgado" };
        break;
    }
    // Se devuelve como XML
    Response.ContentType = "text/xml";
    // Evitar que haya caché de este contenido
    Response.AppendHeader("cache-control", "no-cache");
    Response.Expires = -1;
    Response.Write(DevuelveXML(elementos));
    // Ojo: eliminar el HTML, el formulario, del fichero obtenerDatos.aspx
    // porque si no Response lo añadirá al final del documento XML
    // y dará lugar a un documento XML mal formado, lo que hará que la
    // propiedad responseXML esté vacía.
  }

  // Función para crear el XML a devolver
  string DevuelveXML(string[] ElementosMatriz)
  {
    string respuestaXML = "<?xml version='1.0' encoding='utf-8'?>" + "\r\n" + "<elementos>" + "\r\n";
    if (ElementosMatriz.Length != 0)
    {
      // Recorrer la matriz para construir el XML;
      foreach (string elemento in ElementosMatriz)
      {
        respuestaXML += "<elemento>" + elemento + "</elemento>";
      }
    }
    else
    {
      respuestaXML += "<elemento>[Sin elementos]</elemento>";
    }
    respuestaXML += "</elementos>";

    //// Otra forma:
    //System.Xml.Serialization.XmlSerializer miSerializador;
    //System.IO.TextWriter miEscritorTexto;
    //miSerializador = new System.Xml.Serialization.XmlSerializer(typeof(string[]));
    //miEscritorTexto = new System.IO.StreamWriter(@"C:\Inetpub\wwwroot\AJAX1\App_Data\respuesta.txt");
    //miSerializador.Serialize(miEscritorTexto, ElementosMatriz);
    //miEscritorTexto.Close();
    //// Ojo: intr0duce las etiquetas <string> </string>. Cambiar: getElementsByTagName("string")
    //string respuestaXML = System.IO.File.ReadAllText(@"C:\Inetpub\wwwroot\AJAX1\App_Data\respuesta.txt");

    return respuestaXML;
  }
}
