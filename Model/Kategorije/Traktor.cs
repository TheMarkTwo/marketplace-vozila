namespace MarketplaceVozila.Model
{
    class Traktor : Vozilo
    {
        public int RadniSati { get; set; }

        public Traktor() { }
        public Traktor(Vozilo v) : base(v) { }
    }
}
