// Archivo JScript

function LoadXmlFromString(xmlString)
{
  var dom = null;
  if (document.implementation && document.implementation.createDocument)
  {
    domParser = new DOMParser();
    dom = domParser.parseFromString(xmlString, 'text/xml');
  }
  else
  {
    dom = new ActiveXObject('Microsoft.XMLDOM');
    dom.loadXML(xmlString);
  }
  return dom;
}

function CargarTabla(resultado, contexto)
{
  // debugger;
  var elementos = LoadXmlFromString(resultado).getElementsByTagName("string");
  TablaResultados = document.getElementById("TablaDeResultados");
  if (TablaResultados != null)
  {
    // Fila de cabecera
    var cabecera = document.getElementById("ListaDeOpciones").value +
                   " EN LAS PRÁCTICAS DE PROGRAMACIÓN VISUAL";
    TablaResultados.rows[0].cells[0].innerHTML = cabecera;
    // Resto de filas
    if (TablaResultados.rows.length > 1)
      BorrarFilas(TablaResultados); // vaciar la tabla de resultados
    // Añadir los elementos obtenidos a la tabla de resultados
    for(var e = 0; e < elementos.length; e++)
    {
      AnyadirFila(TablaResultados);
      TablaResultados.rows[e+1].cells[1].innerHTML = elementos[e].childNodes[0].nodeValue;
    }
  }
}

function AnyadirFila(tabla)
{
  var siguienteFila = tabla.rows.length;
  var row = tabla.insertRow(siguienteFila);
  
  // Celda 0
  var celda0 = row.insertCell(0);
  var textoCelda = document.createTextNode(siguienteFila);
  celda0.appendChild(textoCelda);
  // Celda 1
  var celda1 = row.insertCell(1);
  var elemento = document.createElement("input");
  elemento.type = "text";
  elemento.name = "txtRow" + siguienteFila;
  elemento.id = "txtRow" + siguienteFila;
  celda1.appendChild(elemento);
}

function BorrarFilas(tabla)
{
  // Borrar todas las filas menos la de cabecera
  for(var f = tabla.rows.length-1; f > 0; f--)
  {
    // alert(f);
    tabla.deleteRow(f);
  }
}

function Error(mensaje, contexto)
{
  alert("Se ha producido un error");
}

function hora()
{
  var fh = new Date();
  var h = fh.getHours();
  var m = fh.getMinutes();
  var s = fh.getSeconds();
  var mt = "AM";
  if (h > 12)
  {
    mt = "PM";
    h = h - 12;
  }
  if (h == 0) hours = 12;
  if (m <= 9) m = "0" + m;
  if (s <= 9) s = "0" + s
  var htmlhora="<font size='5' face='Arial' ><b><font size='1'>Hora actual:</font></br>"+h+":"+m+":"+s+" "+mt+"</b></font>"
  document.write(htmlhora);
}
