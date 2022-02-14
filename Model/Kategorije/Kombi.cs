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
