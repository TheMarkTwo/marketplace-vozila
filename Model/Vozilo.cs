using System.Collections.Generic;
using System.IO;

namespace MarketplaceVozila.Model
{
    public class Vozilo
    {
        public string Kategorija { get; set; }
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int SnagaMotora { get; set; } // Kw
        public double RadniObujam { get; set; } // l
        public int GodinaProizvodnje { get; set; }
        public double PrijedeniKilometri { get; set; }

        public static List<Vozilo> listaVozila = new List<Vozilo>();

        public Vozilo() { }
        public Vozilo(Vozilo vozilo)
        {
            Kategorija = vozilo.Kategorija;
            ID = vozilo.ID;
            Marka = vozilo.Marka;
            Model = vozilo.Model;
            SnagaMotora = vozilo.SnagaMotora;
            RadniObujam = vozilo.RadniObujam;
            GodinaProizvodnje = vozilo.GodinaProizvodnje;
            PrijedeniKilometri = vozilo.PrijedeniKilometri;
        }

        public void SpremiVozilo()
        {
            using (StreamWriter writer = new StreamWriter(PodatkovniKontekst.bazaVozila, true))
            {
                writer.Write($"{Kategorija}|{ID}|{Marka}|{Model}|{SnagaMotora}" +
                    $"|{RadniObujam}|{GodinaProizvodnje}|{PrijedeniKilometri}|");
                switch (Kategorija)
                {
                    case "Automobil":
                        Automobil a = this as Automobil;
                        writer.WriteLine($"{a.TipAutomobila}|{a.Motor}|{a.Mjenjac}");
                        break;

                    case "Motocikl":
                        Motocikl m = this as Motocikl;
                        writer.WriteLine($"{m.Vrsta}|{m.Motor}");
                        break;

                    case "Kombi":
                        Kombi ko = this as Kombi;
                        writer.WriteLine($"{ko.TipKombia}|{ko.Motor}|{ko.Mjenjac}");
                        break;

                    case "Kamion":
                        Kamion ka = this as Kamion;
                        writer.WriteLine($"{ka.TipKamiona}|{ka.Motor}|{ka.MaksimalnaNosivost}");
                        break;

                    case "Traktor":
                        Traktor t = this as Traktor;
                        writer.WriteLine($"{t.RadniSati}");
                        break;
                }
            }
        }

        public void AzurirajVozilo()
        {
            foreach (Vozilo v in listaVozila)
            {
                using (StreamWriter writer = new StreamWriter(PodatkovniKontekst.bazaVozila, true))
                {
                    writer.Write($"{v.Kategorija}|{v.ID}|{v.Marka}|{v.Model}|{v.SnagaMotora}" +
                        $"|{v.RadniObujam}|{v.GodinaProizvodnje}|{v.PrijedeniKilometri}|");
                    switch (Kategorija)
                    {
                        case "Automobil":
                            Automobil a = v as Automobil;
                            writer.WriteLine($"{a.TipAutomobila}|{a.Motor}|{a.Mjenjac}");
                            break;

                        case "Motocikl":
                            Motocikl m = v as Motocikl;
                            writer.WriteLine($"{m.Vrsta}|{m.Motor}");
                            break;

                        case "Kombi":
                            Kombi ko = v as Kombi;
                            writer.WriteLine($"{ko.TipKombia}|{ko.Motor}|{ko.Mjenjac}");
                            break;

                        case "Kamion":
                            Kamion ka = v as Kamion;
                            writer.WriteLine($"{ka.TipKamiona}|{ka.Motor}|{ka.MaksimalnaNosivost}");
                            break;

                        case "Traktor":
                            Traktor t = v as Traktor;
                            writer.WriteLine($"{t.RadniSati}");
                            break;
                    }
                }
            }
        }

        public static void DohvatiVozila()
        {
            using (StreamReader reader = new StreamReader(PodatkovniKontekst.bazaVozila))
            {
                Vozilo vozilo;
                string line;
                string[] devided;
                while ((line = reader.ReadLine()) != null)
                {
                    devided = line.Split('|');
                    vozilo = new Vozilo()
                    {
                        Kategorija = devided[0],
                        ID = int.Parse(devided[1]),
                        Marka = devided[2],
                        Model = devided[3],
                        SnagaMotora = int.Parse(devided[4]),
                        RadniObujam = double.Parse(devided[5]),
                        GodinaProizvodnje = int.Parse(devided[6]),
                        PrijedeniKilometri = double.Parse(devided[7])
                    };

                    switch (devided[0])
                    {
                        case "Automobil":
                            vozilo = new Automobil(vozilo) {
                                TipAutomobila = devided[8],
                                Motor = devided[9],
                                Mjenjac = devided[10]
                            };
                            break;

                        case "Motocikl":
                            vozilo = new Motocikl(vozilo) {
                                Vrsta = devided[8],
                                Motor = devided[9]
                            };
                            break;

                        case "Kombi":
                            vozilo = new Kombi(vozilo) {
                                TipKombia = devided[8],
                                Motor = devided[9],
                                Mjenjac = devided[10]
                            };
                            break;

                        case "Kamion":
                            vozilo = new Kamion(vozilo) {
                                TipKamiona = devided[8],
                                Motor = devided[9],
                                MaksimalnaNosivost = double.Parse(devided[10])
                            };
                            break;

                        case "Traktor":
                            vozilo = new Traktor(vozilo) {
                                RadniSati = int.Parse(devided[8])
                            };
                            break;
                    }
                    listaVozila.Add(vozilo);
                }
            }
        }

        public override string ToString()
        {
            return $"{Marka} {Model}";
        }
    }
}
