using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static List<Korisnik> listaKorisnika = new List<Korisnik>();

        public void SpremiKorisnika()
        {
            using (StreamWriter writer = new StreamWriter(PodatkovniKontekst.bazaKorisnika, true))
            {
                writer.WriteLine($"{this.ID}|{this.KorisnickoIme}|{this.Lozinka}|{this.PunoIme}|{this.Adresa}|{this.Broj}|{this.Email}");
            }
            PodatkovniKontekst.AzurirajID();
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
                        Email = devided[6]
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
