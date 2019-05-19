using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gsmWebsite.Business;

namespace gsmWebsite
{
    public partial class ItemToevoegenWinkelmandje : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            imgArtikel.ImageUrl ="~/Images/" +  _controller.LaadArtikelmetnummer(Convert.ToInt32(Session["ArtNr"])).Foto; //We voegen de foto toe op basis van het artikel nummer.
            lblArtNr.Text = Convert.ToString(Session["ArtNr"]); // hier zorgen we dat het label met het id ArtNr het artikel nummer zal tonen aan de hand van de sessie die we aangemaakt hebben.
            lblNaam.Text = _controller.LaadArtikelmetnummer(Convert.ToInt32(Session["ArtNr"])).Naam; // We halen de naam van het artikel op aan de hand van het artikel nummer en zetten deze in het juiste label
            lblPrijs.Text = "€ "+_controller.LaadArtikelmetnummer(Convert.ToInt32(Session["ArtNr"])).Prijs.ToString(); //We halen de prijs van het product op aan de hand van het artikel nummer en zetten deze in het juiste label samen met een euro teken.
            lblVoorraad.Text = _controller.LaadArtikelmetnummer(Convert.ToInt32(Session["ArtNr"])).Voorraad.ToString(); // We halen de voorraad op aan de hand van het artikel nummer en zetten deze in het juiste label






        }
        protected void btnvoegtoe(object sender, EventArgs e)
        {
            
        }

        protected void btnVoegtoe_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAantal.Text) > _controller.LaadArtikelmetnummer(Convert.ToInt32(Session["ArtNr"])).Voorraad) //Hier kijken we als we genoeg op voorraad hebben.
            {
                lblfout.Text = "je voorraad is te klein! "; // Als het aantal die je hebt ingegeven  groter is dan de voorraad dan krijg je deze fout melding.

            }
            else
            {
                try
                {
                    int NieuweVoorraad = _controller.LaadArtikelmetnummer(Convert.ToInt32(Session["ArtNr"])).Voorraad - Convert.ToInt32(txtAantal.Text); // Hier word uw voorraad aangepast door het aantal af te trekken van je voorraad.
                    _controller.voegProductAanMandjeToe(Convert.ToInt32(Session["KlantNr"]), _controller.LaadArtikelmetnummer(Convert.ToInt32(Session["ArtNr"])).ArtNr, Convert.ToInt32(txtAantal.Text));// Het product word basis van het artikel nummer toegevoegd aan het winkelmandje.
                    _controller.PasDeVoorraadAAN(Convert.ToInt32(Session["ArtNr"]), NieuweVoorraad); // De oude voorraad word aangepast naar de nieuwe zodat er geen misverstanden kunnen gebeuren.


                    Response.Redirect("winkelmandje.aspx"); // je word doorgestuurd naar de pagina van het winkelmandje.
                }
                catch
                {
                    lblfout.Text = "Dit product zit al in het mandje. Als u het aantal wil wijzigen, verwijder het dan uit het mandje en voeg het correcte aantal toe."; // Deze melding krijg je als het product al aanwezig is in het mandje.
                }

            }
            
        }

        protected void btncatalogus_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}