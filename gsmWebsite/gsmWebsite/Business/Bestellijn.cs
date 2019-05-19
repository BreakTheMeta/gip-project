using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gsmWebsite.Business
{
    public class Bestellijn
    {
        public int OrderNr { get; set; }

        public int ArtikelNr { get; set; }

        public int Aantal { get; set; }

        public double HistPrijs { get; set; }

    }
}