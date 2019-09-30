// Archivo JScript

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

function CancelarLlamadaAsincrona()
{
  var objPRManager = Sys.WebForms.PageRequestManager.getInstance();
  if (objPRManager.get_isInAsyncPostBack())
    objPRManager.abortPostBack();
}
