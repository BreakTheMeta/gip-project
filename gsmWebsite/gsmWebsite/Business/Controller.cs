using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gsmWebsite.Persistence;

namespace gsmWebsite.Business
{
    public class Controller
    {
        PersistenceCode _persistence = new PersistenceCode();
        winkelmand _winkelmand = new winkelmand();
        Gebruiker _gebruiker = new Gebruiker();
        Bestelling _bestelling = new Bestelling();
        Bestellijn _bestellijn = new Bestellijn();

        public List<artikel> HaalArtikelsOp()
        {
            return _persistence.loadArtikels();
        }

        public artikel LaadArtikelmetnummer(int ArtNr)
        {
          return _persistence.LoadArtikelMetNR(ArtNr);
        }

        public bool controleervoorraad(int ArtNr)
        {
            return _persistence.ControleerVoorraad(ArtNr);
        }

        public void voegProductAanMandjeToe(int klantnr, int artnr, int aantal)
        {
            _winkelmand.KlantNr = klantnr;
            _winkelmand.ArtNr = artnr;
            _winkelmand.Aantal = aantal;
            _persistence.toevoegenAanwinkemand(_winkelmand);

        }
        

        public void PasDeVoorraadAAN(int ArtNr, int Voorraad)
        {
            _persistence.PasVoorraadAan(ArtNr, Voorraad);
        }

        public List<winkelmand> haalwinkelmandop(int KlantNr)
        {
            return _persistence.laadwinkelmand(KlantNr);
        }

        public Klant Laadklant(int Klantnr)
        {
            return _persistence.LoadKlantMetNR(Klantnr);
        }

        public Klant laadklantnummer(string GEbr)
        {
            return _persistence.laadklantnummer(GEbr);
        }
        


        public Boolean controleerCredentials(string GN, string WW)

        {
            _gebruiker.Gebr = GN;
            _gebruiker.Wachtwoord = WW;
            return _persistence.controleerCredentials(_gebruiker);

        }
        public void deleteProduct(int ArtNr, int KlantNr)

        {
            _persistence.VerwijderProduct(ArtNr, KlantNr);
        }
        public bool ControleerDemand(int klantnr)
        {
            return _persistence.ControleerWinkelMand(klantnr);
        }

        public void slaBestellingOp(DateTime datum, int klantnr)

        {

            _bestelling.Datum = datum;

            _bestelling.KlantNr = klantnr;



            _persistence.voegordertoe(_bestelling);

        }

        public void slaBestellijnOp(int ordernr, int artnr, int aantal, double histprijs)

        {
            _bestellijn.OrderNr = ordernr;

            _bestellijn.ArtikelNr = artnr;

            _bestellijn.Aantal = aantal;

            _bestellijn.HistPrijs = histprijs;


            _persistence.voegbestellijntoe(_bestellijn);

        }

        public double haalPrijsOp(int artnr)

        {
            return _persistence.prijslijst(artnr);
        }



        public totaal Haaltotalenop(int klnr)

        {
            return _persistence.getTotals(klnr);
        }


        public int haalOrderNrOp(DateTime datum)

        {
            return _persistence.getOrderNumber(datum);

        }



        public int Haalvoorraadop(int id)

        {
            return _persistence.getVoorraad(id);
        }

        public string haalMailOp(int KlantNr)
        {
            return _persistence.HaalEmailOp(KlantNr);
        }




    }
}