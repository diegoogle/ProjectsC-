using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
  protected void Page_Load(object sender, EventArgs e)
  {

  }

  protected void Timer1_Tick(object sender, EventArgs e)
  {
    Label1.Text = "Hora actual:";
    etHora.Text = DateTime.Now.ToString("h:mm:ss tt",
                                 DateTimeFormatInfo.InvariantInfo);
  }
}
