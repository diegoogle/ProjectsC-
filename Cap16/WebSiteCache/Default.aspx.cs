using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    //Response.Cache.SetExpires(DateTime.Now.AddSeconds(30));
    //Response.Cache.SetCacheability(HttpCacheability.Public);
    //Response.Cache.SetValidUntilExpires(true);
    Label1.Text = System.DateTime.Now.ToString();

    using (bd_telefonosContexto contextoObjs = new bd_telefonosContexto())
    {
      GridView1.DataSource = contextoObjs.telefonos.ToList();
      GridView1.DataBind();
    }
  }

  protected static string hora(HttpContext c)
  {
    return System.DateTime.Now.ToString();
  }
}
