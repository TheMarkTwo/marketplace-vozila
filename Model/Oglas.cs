using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MarketplaceVozila.Model
{
    public class Oglas
    {
        public int ID { get; set; }
        public Vozilo VoziloZaProdaju { get; set; }
        public Korisnik Prodavac { get; set; }
        public string NazivOglasa { get; set; }
        public double Cijena { get; set; } // kn
        public string Lokacija { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; }

        public static List<Oglas> listaOglasa = new List<Oglas>();

        public void SpremiOglas()
        {
            using (StreamWriter writer = new StreamWriter(PodatkovniKontekst.bazaOglasa, true))
            {
                writer.WriteLine($"{ID}|{Prodavac.ID}|{NazivOglasa}|{Cijena}|{Lokacija}|{Opis}|{Slika}");
            }
            PodatkovniKontekst.AzurirajID();
        }

        public static void AzurirajOglase()
        {
            using (StreamWriter writer = new StreamWriter(PodatkovniKontekst.bazaOglasa))
            {
                foreach (Oglas o in listaOglasa)
                {
                    writer.WriteLine($"{o.ID}|{o.Prodavac.ID}|{o.NazivOglasa}|{o.Cijena}|{o.Lokacija}|{o.Opis}|{o.Slika}");
                }
            }
        }

        public static void DohvatiOglase()
        {
            using (StreamReader reader = new StreamReader(PodatkovniKontekst.bazaOglasa))
            {
                Oglas oglas;
                string line;
                string[] devided;
                while ((line = reader.ReadLine()) != null)
                {
                    devided = line.Split('|');
                    oglas = new Oglas()
                    {
                        ID = int.Parse(devided[0]),
                        VoziloZaProdaju = Vozilo.listaVozila.Where(v => v.ID == int.Parse(devided[0])).ToList()[0],
                        Prodavac = Korisnik.listaKorisnika.Where(k => k.ID == int.Parse(devided[1])).ToList()[0],
                        NazivOglasa = devided[2],
                        Cijena = double.Parse(devided[3]),
                        Lokacija = devided[4],
                        Opis = devided[5],
                        Slika = devided[6]
                    };
                    listaOglasa.Add(oglas);
                }
            }
        }
    }
}
