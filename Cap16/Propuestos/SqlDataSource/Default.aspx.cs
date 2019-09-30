using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  protected void DetailsView1_PreRender(object sender, EventArgs e)
  {
    if (this.IsPostBack && DetailsView1.DataItemCount == 0)
      etError.Text = "Error: no está en acta";
    else
      etError.Text = "";
  }
}
