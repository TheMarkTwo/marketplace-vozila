using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketplaceVozila.Model;

namespace MarketplaceVozila
{
    public partial class frmKreiranjeOglasa : Form
    {
        string filePath;
        readonly Korisnik trenutniKorisnik;
        public frmKreiranjeOglasa(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void frmKreiranjeOglasa_Load(object sender, EventArgs e)
        {
            cmbKategorija.DataSource = PodatkovniKontekst.listaKategorija;
            cmbLokacija.DataSource = PodatkovniKontekst.popisLokacija;
            cmbLokacija.SelectedIndex = -1;
            pboxSlika.Image = Image.FromFile(PodatkovniKontekst.tempSlikaOglasa);
        }

        private void pboxSlika_Click(object sender, EventArgs e)
        {
            //Dodavanje slike oglasa
            if (!File.Exists(PodatkovniKontekst.slikeOglasa + (PodatkovniKontekst.IDs[0] + 1) + ".jpg"))
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "JPG Files|*.jpg";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        Image slika = Image.FromFile(filePath);
                        pboxSlika.Image = slika;
                    }
                }
            }
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ocisti sve prilikom mijenjanja kategorije
            pboxSlika.Image = Image.FromFile(PodatkovniKontekst.tempSlikaOglasa);
            string odabranaKategorija = cmbKategorija.GetItemText(cmbKategorija.SelectedItem);
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
            PodatkovniKontekst.DinamicneKontroleVozila(pnlAtributi, odabranaKategorija);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            bool nastavi = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    if (control.Text.Contains("|") || control.Text.Contains(@"\n"))
                    {
                        MessageBox.Show("Unutar teksutalih polja se ne moze nalaziti znak | ili \\n", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nastavi = false;
                        break;
                    }
                    else if(string.IsNullOrWhiteSpace(control.Text))
                    {
                        MessageBox.Show("Sva polja moraju biti popunjena", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nastavi = false;
                        break;
                    }
                }
            }

            if (nastavi)
            {
                //Kreiranje vozila
                string[] vrijednostiAtr = PodatkovniKontekst.DohvatiVrijednostiKontrola(pnlAtributi);
                int ID = ++PodatkovniKontekst.IDs[0];
                string kategorija = cmbKategorija.GetItemText(cmbKategorija.SelectedItem);
                Vozilo vozilo = new Vozilo()
                {
                    Kategorija = kategorija,
                    ID = ID,
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    SnagaMotora = int.Parse(txtSnagaMotora.Text),
                    RadniObujam = double.Parse(txtRadniObujam.Text),
                    GodinaProizvodnje = int.Parse(txtGodinaPorizvodnje.Text),
                    PrijedeniKilometri = double.Parse(txtPrijedeniKilometri.Text)
                };
                switch (kategorija)
                {
                    case "Automobil":
                        Automobil a = new Automobil(vozilo)
                        {
                            TipAutomobila = vrijednostiAtr[0],
                            Motor = vrijednostiAtr[1],
                            Mjenjac = vrijednostiAtr[2]
                        };
                        Vozilo.listaVozila.Add(a);
                        a.SpremiVozilo();
                        break;

                    case "Motocikl":
                        Motocikl m = new Motocikl(vozilo)
                        {
                            Vrsta = vrijednostiAtr[0],
                            Motor = vrijednostiAtr[1]
                        };
                        Vozilo.listaVozila.Add(m);
                        m.SpremiVozilo();
                        break;

                    case "Kombi":
                        Kombi ko = new Kombi(vozilo)
                        {
                            TipKombia = vrijednostiAtr[0],
                            Motor = vrijednostiAtr[1],
                            Mjenjac = vrijednostiAtr[2]
                        };
                        Vozilo.listaVozila.Add(ko);
                        ko.SpremiVozilo();
                        break;

                    case "Kamion":
                        Kamion ka = new Kamion(vozilo)
                        {
                            TipKamiona = vrijednostiAtr[0],
                            Motor = vrijednostiAtr[1],
                            MaksimalnaNosivost = double.Parse(vrijednostiAtr[2])
                        };
                        Vozilo.listaVozila.Add(ka);
                        ka.SpremiVozilo();
                        break;

                    case "Traktor":
                        Traktor t = new Traktor(vozilo)
                        {
                            RadniSati = int.Parse(vrijednostiAtr[0])
                        };
                        Vozilo.listaVozila.Add(t);
                        t.SpremiVozilo();
                        break;

                    default:
                        break;
                }

                //Kreiranje oglasa
                Oglas oglas = new Oglas()
                {
                    ID = ID,
                    VoziloZaProdaju = Vozilo.listaVozila.Where(v => v.ID == ID).ToList()[0],
                    Prodavac = trenutniKorisnik,
                    NazivOglasa = txtNazivOglasa.Text,
                    Cijena = double.Parse(txtCijena.Text),
                    Lokacija = cmbLokacija.GetItemText(cmbLokacija.SelectedItem),
                    Opis = txtOpis.Text.Replace(Environment.NewLine, @" \n ")
                };
                Oglas.listaOglasa.Add(oglas);
                oglas.SpremiOglas();

                if (!string.IsNullOrEmpty(filePath))
                {
                    string slikaPath = PodatkovniKontekst.slikeOglasa + oglas.ID + ".jpg";
                    File.Copy(filePath, slikaPath);
                    pboxSlika.Image = Image.FromFile(slikaPath);
                }

                DialogResult d = MessageBox.Show("Oglas je kreiran", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
