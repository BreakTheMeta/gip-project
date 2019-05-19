using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gsmWebsite
{
    public partial class BestelBevestiging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOrderNr.Text = Convert.ToInt32(Session["ordernr"]).ToString();

            lblPrijs.Text = "€ " + Math.Round(Convert.ToDouble(Session["totaalprijs"]), 2);


        }

        protected void btngoback_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}