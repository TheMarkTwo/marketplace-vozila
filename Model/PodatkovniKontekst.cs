using System;
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

        public static readonly string slikeOglasa = @"..\..\Slike\SlikeOglasa\";
        public static readonly string tempSlikaOglasa = @"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";
        public static readonly string tempProfilna = @"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";
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

        /// <summary>
        /// Dohvaca sve podatke iz baza
        /// </summary>
        public static void DohvatiPodatke()
        {
            DohvatiID();
            Vozilo.DohvatiVozila();
            Korisnik.DohvatiKorisike();
            Oglas.DohvatiOglase();
        }

        /// <summary>
        /// Pretvara odabrane slike u Base64 format
        /// </summary>
        /// <returns>Base64 format slike</returns>
        public static string GetImageBase64()
        {
            string base64Image = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { InitialDirectory = Directory.GetCurrentDirectory(), Filter = "JPG Files|*.jpg"})
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] imageArray = File.ReadAllBytes(openFileDialog.FileName);
                    base64Image = Convert.ToBase64String(imageArray);
                }
                else base64Image = "";
            }
            return base64Image;
        }

        public static void DinamicneKontroleVozila(Panel panel, string odabranaKategorija, Size velicinaKontrole)
        {
            // Size(194, 21); pretraga
            // Size(142, 21); kreiranje

            Size velicina = velicinaKontrole;
            panel.Controls.Clear();
            // Tip
            Label lblTip = new Label() { Text = "Tip:", Location = new Point(-3, 0) };
            TextBox txtTip = new TextBox() { Width = 121, Location = new Point(0, 16), Size = velicina };

            // Motor
            Label lblMotor = new Label() { Text = "Motor:", Location = new Point(-3, 40) };
            ComboBox cmbMotor = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(0, 56), Size = velicina };

            // Mjenjac
            Label lblMjenjac = new Label() { Text = "Mjenjac:", Location = new Point(-3, 80) };
            ComboBox cmbMjenjac = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(0, 96), Size = velicina };
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
                ComboBox cmbVrsta = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(0, 16), Size = velicina };
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
                Label lblMaksNosivost = new Label() { Text = "Nosivost do:", Location = new Point(-3, 80) };
                TextBox txtMaksNosivost = new TextBox() { Width = 121, Location = new Point(0, 96), Size = velicina };
                panel.Controls.Add(txtMaksNosivost);
                panel.Controls.Add(lblMaksNosivost);
            }
            else if (odabranaKategorija == "Traktor")
            {
                Label lblRadniSati = new Label() { Text = "Radni sati do:", Location = new Point(-3, 0) };
                TextBox txtRadniSati = new TextBox() { Width = 121, Location = new Point(0, 16), Size = velicina };
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