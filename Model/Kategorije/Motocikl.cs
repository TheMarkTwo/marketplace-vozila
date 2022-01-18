using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceVozila.Model
{
    class Motocikl : Vozilo
    {
        public string Vrsta { get; set; }
        public string Motor { get; set; }

        public Motocikl() { }
        public Motocikl(Vozilo v) : base(v) { }
    }
}
