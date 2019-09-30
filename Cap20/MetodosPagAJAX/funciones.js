// Archivo JScript

function InvocarMetodoPag()
{
  PageMethods.Saludo($get("nombre").value , Mensaje);
}

function Mensaje(resultado)
{
  var etiqueta = $get("etMensaje"); // $get = document.getElementById
  var tamanyo = numero_aleatorio(4, 7);
  var color = color_aleatorio();
  etiqueta.innerHTML = "<FONT SIZE='" + tamanyo + "' COLOR='" +
                       color + "'>\n" + resultado + "\n</FONT>\n";
}

function color_aleatorio()
{ 
   color_aleat="#" 
   hexadecimal = new Array("0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F") 
   var inferior = 0; 
   var superior = hexadecimal.length - 1; 
   for (i = 0; i < 6; i++)
     color_aleat += hexadecimal[numero_aleatorio(superior, inferior)]; 
   return color_aleat 
} 

function numero_aleatorio(superior, inferior)
{ 
  var numPosibilidades = (superior + 1) - inferior; 
  var aleat = Math.random() * numPosibilidades; 
  aleat = Math.floor(aleat); 
  aleat = (inferior + aleat); 
  return aleat;
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
