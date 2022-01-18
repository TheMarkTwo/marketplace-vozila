using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceVozila.Model
{
    class Traktor : Vozilo
    {
        public int RadniSati { get; set; }

        public Traktor() { }
        public Traktor(Vozilo v) : base(v) { }
    }
}
