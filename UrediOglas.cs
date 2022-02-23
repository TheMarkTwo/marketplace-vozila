using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MarketplaceVozila.Model;

namespace MarketplaceVozila
{
    public partial class UrediOglas : Form
    {
        readonly Oglas trenutniOglas;
        string base64Img;
        public UrediOglas(Oglas oglas)
        {
            trenutniOglas = oglas;
            InitializeComponent();
        }

        public void PopuniVrijednostKontrola(Panel panel, string[] vrijednosti)
        {
            int poRedu = 0;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = vrijednosti[poRedu];
                    poRedu++;
                }
            }
        }

        private void UrediOglas_Load(object sender, EventArgs e)
        {
            cmbKategorija.DataSource = PodatkovniKontekst.listaKategorija;
            cmbLokacija.DataSource = PodatkovniKontekst.popisLokacija;
            cmbLokacija.SelectedIndex = -1;

            //slika
            byte[] imgBytes;
            if (trenutniOglas.Slika != "") imgBytes = Convert.FromBase64String(trenutniOglas.Slika);
            else imgBytes = Convert.FromBase64String(PodatkovniKontekst.tempSlikaOglasa);
            Image img;
            using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);
            pboxSlika.Image = img;

            //podatci
            cmbKategorija.Text = trenutniOglas.VoziloZaProdaju.Kategorija;
            txtMarka.Text = trenutniOglas.VoziloZaProdaju.Marka;
            txtModel.Text = trenutniOglas.VoziloZaProdaju.Model;
            txtSnagaMotora.Text = trenutniOglas.VoziloZaProdaju.SnagaMotora.ToString();
            txtGodinaPorizvodnje.Text = trenutniOglas.VoziloZaProdaju.GodinaProizvodnje.ToString();
            txtPrijedeniKilometri.Text = trenutniOglas.VoziloZaProdaju.PrijedeniKilometri.ToString();
            txtRadniObujam.Text = trenutniOglas.VoziloZaProdaju.RadniObujam.ToString();
            txtCijena.Text = trenutniOglas.Cijena.ToString();
            cmbLokacija.Text = trenutniOglas.Lokacija;
            txtNazivOglasa.Text = trenutniOglas.NazivOglasa;
            txtOpis.Text = trenutniOglas.Opis.Replace(@" \n ", Environment.NewLine);

            switch (trenutniOglas.VoziloZaProdaju.Kategorija)
            {
                case "Automobil":
                    PopuniVrijednostKontrola(pnlAtributi, new string[] {
                        ((Automobil)trenutniOglas.VoziloZaProdaju).TipAutomobila,
                        ((Automobil)trenutniOglas.VoziloZaProdaju).Motor,
                        ((Automobil)trenutniOglas.VoziloZaProdaju).Mjenjac
                    });
                    break;

                case "Motocikl":
                    PopuniVrijednostKontrola(pnlAtributi, new string[] {
                        ((Motocikl)trenutniOglas.VoziloZaProdaju).Vrsta,
                        ((Motocikl)trenutniOglas.VoziloZaProdaju).Motor
                    });
                    break;

                case "Kombi":
                    PopuniVrijednostKontrola(pnlAtributi, new string[] {
                        ((Kombi)trenutniOglas.VoziloZaProdaju).TipKombia,
                        ((Kombi)trenutniOglas.VoziloZaProdaju).Motor, 
                        ((Kombi)trenutniOglas.VoziloZaProdaju).Mjenjac
                    });
                    break;

                case "Kamion":
                    PopuniVrijednostKontrola(pnlAtributi, new string[] {
                        ((Kamion)trenutniOglas.VoziloZaProdaju).TipKamiona,
                        ((Kamion)trenutniOglas.VoziloZaProdaju).Motor,
                        ((Kamion)trenutniOglas.VoziloZaProdaju).MaksimalnaNosivost.ToString("0,0")
                    });
                    break;

                case "Traktor":
                    PopuniVrijednostKontrola(pnlAtributi, new string[] {
                        ((Traktor)trenutniOglas.VoziloZaProdaju).RadniSati.ToString("0,0")
                    });
                    break;

                default:
                    break;
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
                trenutniOglas.Slika = base64Img;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                string[] vrijednostiAtr = PodatkovniKontekst.DohvatiVrijednostiKontrola(pnlAtributi);
                Vozilo vozilo = new Vozilo();
                foreach (Oglas oglas in Oglas.listaOglasa)
                {
                    if (oglas.ID == trenutniOglas.ID)
                    {
                        trenutniOglas.VoziloZaProdaju.Kategorija = cmbKategorija.Text;
                        trenutniOglas.VoziloZaProdaju.Marka = txtMarka.Text;
                        trenutniOglas.VoziloZaProdaju.Model = txtModel.Text;
                        trenutniOglas.VoziloZaProdaju.SnagaMotora = int.Parse(txtSnagaMotora.Text);
                        trenutniOglas.VoziloZaProdaju.GodinaProizvodnje = int.Parse(txtGodinaPorizvodnje.Text);
                        trenutniOglas.VoziloZaProdaju.PrijedeniKilometri = double.Parse(txtPrijedeniKilometri.Text);
                        trenutniOglas.VoziloZaProdaju.RadniObujam = double.Parse(txtRadniObujam.Text);
                        trenutniOglas.Cijena = double.Parse(txtCijena.Text);
                        trenutniOglas.Lokacija = cmbLokacija.Text;
                        trenutniOglas.NazivOglasa = txtNazivOglasa.Text;

                        switch (trenutniOglas.VoziloZaProdaju.Kategorija)
                        {
                            case "Automobil":
                                ((Automobil)trenutniOglas.VoziloZaProdaju).TipAutomobila = vrijednostiAtr[0];
                                ((Automobil)trenutniOglas.VoziloZaProdaju).Motor = vrijednostiAtr[1];
                                ((Automobil)trenutniOglas.VoziloZaProdaju).Mjenjac = vrijednostiAtr[2];
                                break;

                            case "Motocikl":
                                ((Motocikl)trenutniOglas.VoziloZaProdaju).Vrsta = vrijednostiAtr[0];
                                ((Motocikl)trenutniOglas.VoziloZaProdaju).Motor = vrijednostiAtr[1];
                                break;

                            case "Kombi":
                                ((Kombi)trenutniOglas.VoziloZaProdaju).TipKombia = vrijednostiAtr[0];
                                ((Kombi)trenutniOglas.VoziloZaProdaju).Motor = vrijednostiAtr[1];
                                ((Kombi)trenutniOglas.VoziloZaProdaju).Mjenjac = vrijednostiAtr[2];
                                break;

                            case "Kamion":
                                ((Kamion)trenutniOglas.VoziloZaProdaju).TipKamiona = vrijednostiAtr[0];
                                ((Kamion)trenutniOglas.VoziloZaProdaju).Motor = vrijednostiAtr[1];
                                ((Kamion)trenutniOglas.VoziloZaProdaju).MaksimalnaNosivost = double.Parse(vrijednostiAtr[2]);
                                break;

                            case "Traktor":
                                ((Traktor)trenutniOglas.VoziloZaProdaju).RadniSati = int.Parse(vrijednostiAtr[0]);
                                break;

                            default:
                                break;
                        }
                        break;
                    }
                }

                Vozilo.AzurirajVozila();
                Oglas.AzurirajOglase();
                DialogResult d = MessageBox.Show("Oglas je ureden", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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