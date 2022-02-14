using System.Collections.Generic;
using System.IO;

namespace MarketplaceVozila.Model
{
    public class Korisnik
    {
        public int ID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string PunoIme { get; set; }
        public string Adresa { get; set; }
        public string Broj { get; set; }
        public string Email { get; set; }
        public string Slika { get; set; }

        public static List<Korisnik> listaKorisnika = new List<Korisnik>();

        public void SpremiKorisnika()
        {
            using (StreamWriter writer = new StreamWriter(PodatkovniKontekst.bazaKorisnika, true))
            {
                writer.WriteLine($"{ID}|{KorisnickoIme}|{Lozinka}|{PunoIme}|{Adresa}|{Broj}|{Email}|{Slika}");
            }
            PodatkovniKontekst.AzurirajID();
        }

        public void AzurirajKorisnika()
        {
            using (StreamWriter writer = new StreamWriter(PodatkovniKontekst.bazaKorisnika))
            {
                foreach (Korisnik k in listaKorisnika)
                {
                    writer.WriteLine($"{k.ID}|{k.KorisnickoIme}|{k.Lozinka}|{k.PunoIme}|{k.Adresa}|{k.Broj}|{k.Email}|{k.Slika}");
                }
            }
        }

        public static void DohvatiKorisike()
        {
            using (StreamReader reader = new StreamReader(PodatkovniKontekst.bazaKorisnika))
            {
                Korisnik korisnik;
                string line;
                string[] devided;
                while ((line = reader.ReadLine()) != null)
                {
                    devided = line.Split('|');
                    korisnik = new Korisnik()
                    {
                        ID = int.Parse(devided[0]),
                        KorisnickoIme = devided[1],
                        Lozinka = devided[2],
                        PunoIme = devided[3],
                        Adresa = devided[4],
                        Broj = devided[5],
                        Email = devided[6],
                        Slika = devided[7]
                    };
                    listaKorisnika.Add(korisnik);
                }
            }
        }

        public override string ToString()
        {
            return KorisnickoIme;
        }
    }
}
