using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gsmWebsite.Business;

namespace gsmWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvArtikels.DataSource = _controller.HaalArtikelsOp();
            gvArtikels.DataBind();

            for (int i = 0; i < gvArtikels.Rows.Count; i++) // We gebruiken hier een for om heel de gridview te doorlopen!
            {
                if (gvArtikels.Rows[i].Cells[4].Text == "0") // Hier kijken we of de voorraad die in cell 4 staat of deze gelijk is aan nul!
                {
                    gvArtikels.Rows[i].Cells[5].Text = "Niet op voorraad"; // Is de voorraad nul dan zorgen we dat de select knop vervangen word door de tekst Niet op voorraad.


                }
            
            }
        }

        protected void btnWinkelmandje_Click(object sender, EventArgs e)
        {
            if (_controller.controleervoorraad(Convert.ToInt32(Session["KlantNr"]))) //Hier gaan we kijken of het winkelmandje leeg is op basis van het klant nummer.
            {
                Response.Redirect("winkelmandje.aspx");  //Als er iets in zit dan gaan we naar de winkelmand.
            }
            else
            {
                Response.Redirect("WinkelmandLeeg.aspx"); //Als het mandje leeg is dan ga je naar een pagina dat zegt dat het mandje leeg is.
            }
        }

        protected void gvArtikels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["ArtNr"] = gvArtikels.SelectedRow.Cells[0].Text; // Hier word een sessie gemaakt van het artikel nummer.

            Response.Redirect("itemToevoegenWinkelmandje.aspx"); // je gaat naar de pagina voor een artikel toe te voegen aan het winkelmandje

        }

        
    }
}