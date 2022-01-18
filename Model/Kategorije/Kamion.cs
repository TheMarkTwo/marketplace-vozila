using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceVozila.Model
{
    class Kamion : Vozilo
    {
        public string TipKamiona { get; set; }
        public string Motor { get; set; }
        public double MaksimalnaNosivost { get; set; } // Ton

        public Kamion() { }
        public Kamion(Vozilo v) : base(v) { }
    }
}
