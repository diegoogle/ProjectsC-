<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Página sin título</title>

<script language="javascript" src="funciones.js"></script>
</head>
<body>
  <img src="ceballos.png" width="120" />
  <p><script>hora()</script></p>
  <p align="center">
    Completar una lista dinámicamente con AJAX en función de la opción elegida.</p>
  <form id="form1" runat="server">
    <div>
      <p align="center">
        Elija una OPCIÓN:
        <select name="ListaDeOpciones" id="ListaDeOpciones" runat="server">
          <option value=""></option>
          <option value="APTOS">APTOS</option>
          <option value="NO APTOS">NO APTOS</option>
        </select>
      </p>
      <table border="1" id="TablaDeResultados" width="100%">
        <tr>
          <th colspan="3">
            RESULTADOS</th>
        </tr>
      </table>
    </div>
  </form>
</body>
</html>
