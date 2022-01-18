using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceVozila.Model
{
    class Kombi : Vozilo
    {
        public string TipKombia { get; set; }
        public string Motor { get; set; }
        public string Mjenjac { get; set; }

        public Kombi() { }
        public Kombi(Vozilo v) : base(v) { }
    }
}
