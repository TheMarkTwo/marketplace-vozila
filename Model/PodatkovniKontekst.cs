using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace MarketplaceVozila.Model
{
    class PodatkovniKontekst
    {
        public static readonly string[] listaKategorija = { "Automobil", "Motocikl", "Kombi", "Kamion", "Traktor" };
        public static readonly string[] tipoviMotora = { "Dizel", "Benzin", "Struja", "Hibrid" };
        public static readonly string[] tipoviMjenjaca = { "Automatski", "Manualni" };
        public static readonly string[] vrsteMotocikala = { "Sportski", "Cestovni", "Cross", "Moped", "Skuter" };
        public static readonly string[] vrsteMotoraMotocikala = { "Dvotaktni", "Cetverotaktni" };
        public static readonly string[] popisLokacija = {
            "Zagrebacka",
            "Krapinsko-zagorska",
            "Sisacko-moslavacka",
            "Karlovacka",
            "Varazdinska",
            "Koprivnicko-krizevacka",
            "Bjelovarsko-bilogorska",
            "Primorsko-goranska",
            "Licko-senjska",
            "Viroviticko-podravska",
            "Pozesko-slavonska",
            "Brodsko-posavska",
            "Zadarska",
            "Osjecko-baranjska",
            "Sibensko-kninska",
            "Vukovarsko-srijemska",
            "Splitsko-dalmatinska",
            "Istarska",
            "Dubrovacko-neretvanska",
            "Medimurska",
            "Grad Zagreb"
        };
        public static readonly string[] sortiranjePo = { "Nazivu", "Najevcoj kilometrazi", "Najmanjoj kilometrazi", "Najevcoj cijeni", "Najmanjoj cijeni" };

        static readonly string bazaIDa = @"..\..\Baze\IDs.txt";
        public static int[] IDs;
        public static readonly string bazaVozila = @"..\..\Baze\Vozila.txt";
        public static readonly string bazaKorisnika = @"..\..\Baze\Korisnici.txt";
        public static readonly string bazaOglasa = @"..\..\Baze\Oglasi.txt";

        public static readonly string slikeKorisnika = @"..\..\Slike\SlikeKorisnika\";
        public static readonly string slikeOglasa = @"..\..\Slike\SlikeOglasa\";
        public static readonly string tempSlikaOglasa = @"..\..\Slike\SlikeOglasa\temp.jpg";
        public static readonly string tempProfilna = @"..\..\Slike\SlikeKorisnika\temp.jpg";

        public static void DohvatiID()
        {
            using (StreamReader reader = new StreamReader(bazaIDa))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    IDs = Array.ConvertAll(line.Split('|'), int.Parse);
                }
            }
        }

        public static void AzurirajID()
        {
            using (StreamWriter writer = new StreamWriter(bazaIDa))
            {
                writer.WriteLine($"{IDs[0]}|{IDs[1]}");
            }
        }

        public static void DohvatiPodatke()
        {
            DohvatiID();
            Vozilo.DohvatiVozila();
            Korisnik.DohvatiKorisike();
            Oglas.DohvatiOglase();
        }

        public static void DinamicneKontroleVozila(Panel panel, string odabranaKategorija)
        {
            Size velicina = new Size(194, 21);
            panel.Controls.Clear();
            // Tip
            Label lblTip = new Label() { Text = "Tip:", Location = new Point(-3, 0) };
            TextBox txtTip = new TextBox() { Width = 121, Location = new Point(0, 15), Size = velicina };

            // Motor
            Label lblMotor = new Label() { Text = "Motor:", Location = new Point(-3, 40) };
            ComboBox cmbMotor = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(0, 55), Size = velicina };

            // Mjenjac
            Label lblMjenjac = new Label() { Text = "Mjenjac:", Location = new Point(-3, 80) };
            ComboBox cmbMjenjac = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(0, 95), Size = velicina };
            // Dinamicko kreiranje kontrola
            if (odabranaKategorija == "Automobil" || odabranaKategorija == "Kombi")
            {
                panel.Controls.Add(txtTip);
                panel.Controls.Add(lblTip);

                cmbMotor.Items.AddRange(PodatkovniKontekst.tipoviMotora);
                panel.Controls.Add(cmbMotor);
                panel.Controls.Add(lblMotor);

                cmbMjenjac.Items.AddRange(PodatkovniKontekst.tipoviMjenjaca);
                panel.Controls.Add(cmbMjenjac);
                panel.Controls.Add(lblMjenjac);
            }
            else if (odabranaKategorija == "Motocikl")
            {
                // Vrsta
                Label lblVrsta = new Label() { Text = "Vrsta:", Location = new Point(-3, 0) };
                ComboBox cmbVrsta = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(0, 15), Size = velicina };
                cmbVrsta.Items.AddRange(PodatkovniKontekst.vrsteMotocikala);
                panel.Controls.Add(cmbVrsta);
                panel.Controls.Add(lblVrsta);

                cmbMotor.Items.AddRange(PodatkovniKontekst.vrsteMotoraMotocikala);
                panel.Controls.Add(cmbMotor);
                panel.Controls.Add(lblMotor);
            }
            else if (odabranaKategorija == "Kamion")
            {
                panel.Controls.Add(txtTip);
                panel.Controls.Add(lblTip);

                cmbMotor.Items.AddRange(PodatkovniKontekst.tipoviMotora);
                panel.Controls.Add(cmbMotor);
                panel.Controls.Add(lblMotor);

                // Maksimalna nosivost
                Label lblMaksNosivost = new Label() { Text = "Nosivost:", Location = new Point(-3, 80) };
                TextBox txtMaksNosivost = new TextBox() { Width = 121, Location = new Point(0, 95), Size = velicina };
                panel.Controls.Add(txtMaksNosivost);
                panel.Controls.Add(lblMaksNosivost);
            }
            else if (odabranaKategorija == "Traktor")
            {
                Label lblRadniSati = new Label() { Text = "Radni sati:", Location = new Point(-3, 0) };
                TextBox txtRadniSati = new TextBox() { Width = 121, Location = new Point(0, 15), Size = velicina };
                panel.Controls.Add(txtRadniSati);
                panel.Controls.Add(lblRadniSati);
            }
        }

        public static string[] DohvatiVrijednostiKontrola(Panel panel)
        {
            string[] vrijednosti = new string[3];
            int poRedu = 0;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    vrijednosti[poRedu] = control.Text;
                    poRedu++;
                }
                else if (control is ComboBox)
                {
                    ComboBox cbox = control as ComboBox;
                    vrijednosti[poRedu] = cbox.GetItemText(cbox.SelectedItem);
                    poRedu++;
                }
            }
            return vrijednosti;
        }
    }
}