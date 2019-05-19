using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gsmWebsite.Business;
using System.Net.Mail;
using System.Net;
using System.IO;
namespace gsmWebsite
{
    public partial class Winkelmandje : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {



            lblKlantNr.Text = _controller.Laadklant(Convert.ToInt32(Session["KlantNr"])).KlantNr.ToString(); //Je klantnummer word opgehaald via een sessie. 

            lblNaam.Text = _controller.Laadklant(Convert.ToInt32(Session["KlantNr"])).Voornaam + " " + _controller.Laadklant(Convert.ToInt32(Session["KlantNr"])).Naam; //Je naam en voornaam worden opgehaald via een persistence code waarbij je een sessie van je klantennummer bij mee stuurt.

            lblAdres.Text = Convert.ToString(_controller.Laadklant(Convert.ToInt32(Session["KlantNr"])).adres); //je adres word opgehaald via een persistence code waarbij je een sessie van je klantennummer bij mee stuurt.

            lblPC.Text = _controller.Laadklant(Convert.ToInt32(Session["KlantNr"])).PC.ToString(); //je postcode word opgehaald via een persistence code waarbij je een sessie van je klantennummer bij mee stuurt.

            lblgemeente.Text = Convert.ToString(_controller.Laadklant(Convert.ToInt32(Session["KlantNr"])).Gemeente); //je gemeente word opgehaald via een persistence code waarbij je een sessie van je klantennummer bij mee stuurt.

            lblBesteldatum.Text = DateTime.Now.ToLongDateString(); // De dag en datum van vandaag worden toegevoegd.


            lblTotExclBtw.Text = "€ " + Math.Round(_controller.Haaltotalenop(Convert.ToInt32(Session["KlantNr"])).TotExBtw, 2);
            lblBTW.Text = "€ " + Math.Round(_controller.Haaltotalenop(Convert.ToInt32(Session["KlantNr"])).Btw, 2);
            lblTotInclBtw.Text = "€ " + Math.Round(_controller.Haaltotalenop(Convert.ToInt32(Session["KlantNr"])).TotIncBtw, 2);
            Session["totaalprijs"] = Math.Round(_controller.Haaltotalenop(Convert.ToInt32(Session["KlantNr"])).TotIncBtw, 2);

            gvWinkelmand.DataSource = _controller.haalwinkelmandop(Convert.ToInt32(Session["KlantNr"])); //via de persistence code worden er gegevens toegevoegd aan de gridview
            gvWinkelmand.DataBind();


        }

        protected void gvWinkelmand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NieuweVoorraad = _controller.Haalvoorraadop(Convert.ToInt32(gvWinkelmand.SelectedRow.Cells[2].Text)) + Convert.ToInt32(gvWinkelmand.SelectedRow.Cells[4].Text);

            _controller.deleteProduct(Convert.ToInt32(gvWinkelmand.SelectedRow.Cells[2].Text), Convert.ToInt32(Session["KlantNr"])); //hier verwijder je het artikel uit je winkelmandje    

            _controller.PasDeVoorraadAAN(Convert.ToInt32(gvWinkelmand.SelectedRow.Cells[2].Text), NieuweVoorraad); // via de persistence code die we hier ophalen gaat de voorraad aangepast worden

            if (_controller.ControleerDemand(Convert.ToInt32(Session["KlantNr"]))) //als je artikels verwijderd en er uiteindelijk geen voorwerp meer in winkelmand is dat deze van pagina veranderd.

            {
                Response.Redirect("WinkelmandLeeg.aspx");
            }

            else
            {
                gvWinkelmand.DataSource = _controller.haalwinkelmandop(Convert.ToInt32(Session["KlantNr"]));

                gvWinkelmand.DataBind();
            }

        }

        protected void btnbestel_Click(object sender, EventArgs e)
        {
            _controller.slaBestellingOp(DateTime.Now, Convert.ToInt32(Session["KlantNr"]));
            for (int i = 0; i < gvWinkelmand.Rows.Count; i++)
            { 
                _controller.slaBestellijnOp(_controller.haalOrderNrOp(DateTime.Now), Convert.ToInt32(gvWinkelmand.Rows[i].Cells[2].Text), Convert.ToInt32(gvWinkelmand.Rows[i].Cells[4].Text), _controller.haalPrijsOp(Convert.ToInt32(gvWinkelmand.Rows[i].Cells[2].Text)));
            _controller.deleteProduct(Convert.ToInt32(gvWinkelmand.Rows[i].Cells[2].Text), Convert.ToInt32(Session["KlantNr"]));
             }
                Session["ordernr"] = _controller.haalOrderNrOp(DateTime.Now);

            MailMessage Email = new MailMessage();
            Email.From = new MailAddress("hjacked.smolders@gmail.com");
            Email.To.Add(_controller.haalMailOp(Convert.ToInt32(Convert.ToInt32(Session["KlantNr"]))));
            Email.Subject = "Bevestiging bestelling GSM-Shop";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("hjacked.smolders@gmail.com", "jojo1010");
            smtp.Send(Email);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email succesvol verstuurd ! ');", true);



             Response.Redirect("bestelbevestiging.aspx");
        }


        protected void btnTerugCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx"); //als je op de knop klikt ga je weer naar de catalogus.
        }
    }
}
