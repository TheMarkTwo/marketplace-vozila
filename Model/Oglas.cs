using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public static List<Oglas> listaOglasa = new List<Oglas>();

        public void SpremiOglas()
        {
            using (StreamWriter writer = new StreamWriter(PodatkovniKontekst.bazaOglasa, true))
            {
                writer.WriteLine($"{this.ID}|{this.Prodavac.ID}|{this.NazivOglasa}|{this.Cijena}|{this.Lokacija}|{this.Opis}");
            }
            PodatkovniKontekst.AzurirajID();
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
                        Opis = devided[5]
                    };
                    listaOglasa.Add(oglas);
                }
            }
        }
    }
}
