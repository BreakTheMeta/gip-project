using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gsmWebsite
{
    public partial class WinkelmandLeeg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx"); // als er op de knop word geklikt word je terug naar de catalogus gebracht.
        }
    }
}