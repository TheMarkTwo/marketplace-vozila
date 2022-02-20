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
        readonly Korisnik trenutniKorisnik;
        string base64Img = "";
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

            //slika
            byte[] imgBytes = Convert.FromBase64String(PodatkovniKontekst.tempSlikaOglasa);
            Image img;
            using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);
            pboxSlika.Image = img;
        }

        private void pboxSlika_Click(object sender, EventArgs e)
        {
            byte[] imgBytes;
            Image img;
            base64Img = PodatkovniKontekst.GetImageBase64();
            if (base64Img != "")
            {
                imgBytes = Convert.FromBase64String(base64Img);
                using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);
                pboxSlika.Image = img;
            }
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ocisti sve prilikom mijenjanja kategorije
            string odabranaKategorija = cmbKategorija.GetItemText(cmbKategorija.SelectedItem);
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
            PodatkovniKontekst.DinamicneKontroleVozila(pnlAtributi, odabranaKategorija, new Size(142, 21));
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
                try
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

                    double testParseCijena = double.Parse(txtCijena.Text);

                    switch (kategorija)
                    {
                        case "Automobil":
                            vozilo = new Automobil(vozilo)
                            {
                                TipAutomobila = vrijednostiAtr[0],
                                Motor = vrijednostiAtr[1],
                                Mjenjac = vrijednostiAtr[2]
                            };
                            break;

                        case "Motocikl":
                            vozilo = new Motocikl(vozilo)
                            {
                                Vrsta = vrijednostiAtr[0],
                                Motor = vrijednostiAtr[1]
                            };
                            break;

                        case "Kombi":
                            vozilo = new Kombi(vozilo)
                            {
                                TipKombia = vrijednostiAtr[0],
                                Motor = vrijednostiAtr[1],
                                Mjenjac = vrijednostiAtr[2]
                            };
                            break;

                        case "Kamion":
                            vozilo = new Kamion(vozilo)
                            {
                                TipKamiona = vrijednostiAtr[0],
                                Motor = vrijednostiAtr[1],
                                MaksimalnaNosivost = double.Parse(vrijednostiAtr[2])
                            };
                            break;

                        case "Traktor":
                            vozilo = new Traktor(vozilo)
                            {
                                RadniSati = int.Parse(vrijednostiAtr[0])
                            };
                            break;

                        default:
                            break;
                    }

                    Vozilo.listaVozila.Add(vozilo);
                    vozilo.SpremiVozilo();

                    //Kreiranje oglasa
                    Oglas oglas = new Oglas()
                    {
                        ID = ID,
                        VoziloZaProdaju = Vozilo.listaVozila.Where(v => v.ID == ID).ToList()[0],
                        Prodavac = trenutniKorisnik,
                        NazivOglasa = txtNazivOglasa.Text,
                        Cijena = testParseCijena,
                        Lokacija = cmbLokacija.GetItemText(cmbLokacija.SelectedItem),
                        Opis = txtOpis.Text.Replace(Environment.NewLine, @" \n "),
                        Slika = base64Img
                    };

                    Oglas.listaOglasa.Add(oglas);
                    oglas.SpremiOglas();

                    DialogResult d = MessageBox.Show("Oglas je kreiran", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (d == DialogResult.OK)
                        this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Unesen je krivi format brojcanih vrijednosti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
