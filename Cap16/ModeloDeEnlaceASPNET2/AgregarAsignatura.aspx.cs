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
    etMsjAs.Text = "";
  }

  protected void FormView1_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
  {
    e.DataMethodsObject = new GestionAlumsAsigs();
  }
}
