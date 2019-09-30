using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarAlumno : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    etMsj.Text = "";
  }

  protected void btAgregarAl_Click(object sender, EventArgs e)
  {
    try
    {
      etMsj.Text = "";
      // Colección columna-valor para el método Insert
      ListDictionary nuevaFila = new ListDictionary();
      // Valores de la fila
      nuevaFila.Add("id_alumno", ctDni.Text);
      nuevaFila.Add("nombre", ctNombre.Text);
      // Insertar la fila en alumnos
      EntityDataSource1.Insert(nuevaFila);
      etMsj.Text = "Operación realizada.";
    }
    catch (Exception exc)
    {
      string msjError = "Los datos no son correctos " +
            "o el alumno ya existe (clave duplicada)";
      etMsj.Text = msjError;
    }
  }
}
