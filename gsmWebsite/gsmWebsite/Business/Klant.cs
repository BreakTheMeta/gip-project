using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gsmWebsite.Business
{
    public class Klant
    {
        public int KlantNr { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string adres { get; set; }
        public int PC { get; set; }
        public string Gemeente { get; set; }
        public string Mail { get; set; }
        public string Gebr { get; set; }
        public string Wachtwoord { get; set; }
        public string Orderdatum { get; set; }
    }
}