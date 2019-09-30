using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarAsignatura : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    etMsj.Text = "";
  }
  protected void btAgregarAs_Click(object sender, EventArgs e)
  {
    try
    {
      etMsj.Text = "";
      // Colección columna-valor para el método Insert
      ListDictionary nuevaFila = new ListDictionary();
      // Valores de la fila
      nuevaFila.Add("id_asignatura", ctIdAsig.Text);
      nuevaFila.Add("nombre", ctNombre.Text);
      // Insertar la fila en asignaturas
      EntityDataSource1.Insert(nuevaFila);
      etMsj.Text = "Operación realizada.";
    }
    catch (Exception exc)
    {
      string msjError = "Los datos no son correctos " +
            "o la asignatura ya existe (clave duplicada)";
      etMsj.Text = msjError;
    }
  }
}
