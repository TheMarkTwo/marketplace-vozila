namespace MarketplaceVozila.Model
{
    class Automobil : Vozilo
    {
        public string TipAutomobila { get; set; }
        public string Motor { get; set; }
        public string Mjenjac { get; set; }

        public Automobil() { }
        public Automobil(Vozilo v) : base(v) { }
    }
}
