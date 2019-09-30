using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      etError.Text = "";
    }

    protected void DetailsView1_PreRender(object sender, EventArgs e)
    {
      if (this.IsPostBack && DetailsView1.DataItemCount == 0)
        etError.Text = "Error: no está en acta";
      else
        etError.Text = "";
    }

    protected void Default_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    {
      e.DataMethodsObject = new GestionAlumsAsigs();
    }
}