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
    public partial class frmDetaljiOglasa : Form
    {
        readonly Oglas trenutniOglas;
        readonly Korisnik trenutniKorisnik;
        public frmDetaljiOglasa(Oglas oglas, Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            trenutniOglas = oglas;
            InitializeComponent();
        }

        private void frmDetaljiOglasa_Load(object sender, EventArgs e)
        {
            this.Text = "Oglas #" + trenutniOglas.ID;

            byte[] imgBytes;
            if (trenutniOglas.Slika == "") imgBytes = Convert.FromBase64String(PodatkovniKontekst.tempSlikaOglasa);
            else imgBytes = Convert.FromBase64String(trenutniOglas.Slika);
            using (MemoryStream ms = new MemoryStream(imgBytes)) pboxSlika.Image = Image.FromStream(ms);

            lblNazivOglasa.Text = trenutniOglas.NazivOglasa;
            lblCijena.Text = trenutniOglas.Cijena.ToString("0,0") + "kn";
            lblProdavac.Text = trenutniOglas.Prodavac.ToString();

            lblAutomobil.Text = trenutniOglas.VoziloZaProdaju.ToString() + $" ({trenutniOglas.VoziloZaProdaju.RadniObujam:0.0}L)" + $", {trenutniOglas.VoziloZaProdaju.SnagaMotora} kW";
            lblKilometraza.Text = trenutniOglas.VoziloZaProdaju.PrijedeniKilometri.ToString("0,0") + "km";
            lblGodina.Text = trenutniOglas.VoziloZaProdaju.GodinaProizvodnje + ". godina";
            txtOpis.Text = trenutniOglas.Opis.Replace(@" \n ", Environment.NewLine);

            switch (trenutniOglas.VoziloZaProdaju.Kategorija)
            {
                case "Automobil":
                    lblProp1.Text = "Tip automobila: " + ((Automobil)trenutniOglas.VoziloZaProdaju).TipAutomobila;
                    lblProp2.Text = "Motor: " + ((Automobil)trenutniOglas.VoziloZaProdaju).Motor;
                    lblProp3.Text = "Mjenjac: " + ((Automobil)trenutniOglas.VoziloZaProdaju).Mjenjac;
                    break;

                case "Motocikl":
                    lblProp1.Text = "Vrsta motora: " + ((Motocikl)trenutniOglas.VoziloZaProdaju).Vrsta;
                    lblProp2.Text = "Motor: " + ((Motocikl)trenutniOglas.VoziloZaProdaju).Motor;
                    break;

                case "Kombi":
                    lblProp1.Text = "Tip kombia: " + ((Kombi)trenutniOglas.VoziloZaProdaju).TipKombia;
                    lblProp2.Text = "Motor: " + ((Kombi)trenutniOglas.VoziloZaProdaju).Motor;
                    lblProp3.Text = "Mjenjac: " + ((Kombi)trenutniOglas.VoziloZaProdaju).Mjenjac;
                    break;

                case "Kamion":
                    lblProp1.Text = "Tip kamiona: " + ((Kamion)trenutniOglas.VoziloZaProdaju).TipKamiona;
                    lblProp2.Text = "Motor: " + ((Kamion)trenutniOglas.VoziloZaProdaju).Motor;
                    lblProp3.Text = "Maksimalna nosivost: " + ((Kamion)trenutniOglas.VoziloZaProdaju).MaksimalnaNosivost.ToString() + "t";
                    break;

                case "Traktor":
                    lblProp1.Text = "Radni sati: " + ((Traktor)trenutniOglas.VoziloZaProdaju).RadniSati.ToString();
                    break;

                default:
                    break;
            }
        }

        private void lblProdavac_Click(object sender, EventArgs e)
        {
            bool vlastitiOglas;

            if (trenutniKorisnik.ID == trenutniOglas.Prodavac.ID)
                vlastitiOglas = true;
            else
                vlastitiOglas = false;

            frmProfil prof = new frmProfil(trenutniKorisnik, trenutniOglas.Prodavac, vlastitiOglas);
            prof.Show();
        }
    }
}
