using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using gsmWebsite.Business;

namespace gsmWebsite
{
    public partial class Login : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            if (_controller.controleerCredentials(txtGebruikersNaam.Text, txtWachtwoord.Text) == true)
            {
                Session["KlantNr"] = _controller.laadklantnummer(txtGebruikersNaam.Text).KlantNr;
                FormsAuthentication.RedirectFromLoginPage(txtGebruikersNaam.Text, false);
            }
            else
            {
                lblUitvoer.Text = "Ongeldige login.";
            }

        }
    }
}