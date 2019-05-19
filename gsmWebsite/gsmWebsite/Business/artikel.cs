using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gsmWebsite.Business
{
    public class artikel
    {
        public int ArtNr { get; set; }
        public string Naam { get; set; }
        public int Voorraad { get; set; }
        public double Prijs { get; set; }
        public string Foto { get; set; }
    }
}