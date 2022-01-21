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
        Oglas trenutniOglas;
        Korisnik trenutniKorisnik;
        public frmDetaljiOglasa(Oglas oglas, Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            trenutniOglas = oglas;
            InitializeComponent();
        }

        private void frmDetaljiOglasa_Load(object sender, EventArgs e)
        {
            this.Text = "Oglas #" + trenutniOglas.ID;
            if (File.Exists(PodatkovniKontekst.slikeOglasa + trenutniOglas.ID + ".jpg"))
                pboxSlika.Image = Image.FromFile(PodatkovniKontekst.slikeOglasa + trenutniOglas.ID + ".jpg");
            else
                pboxSlika.Image = Image.FromFile(PodatkovniKontekst.tempSlikaOglasa);
            lblNazivOglasa.Text = trenutniOglas.NazivOglasa;
            lblCijena.Text = trenutniOglas.Cijena.ToString("0,0") + "kn";
            lblProdavac.Text = trenutniOglas.Prodavac.ToString();

            lblAutomobil.Text = trenutniOglas.VoziloZaProdaju.ToString() + $" ({trenutniOglas.VoziloZaProdaju.RadniObujam.ToString("0.0")}L)";
            lblKilometraza.Text = trenutniOglas.VoziloZaProdaju.PrijedeniKilometri.ToString("0,0") + "km";
            lblGodina.Text = trenutniOglas.VoziloZaProdaju.GodinaProizvodnje + ". godina";
            txtOpis.Text = trenutniOglas.Opis.Replace(@" \n ", Environment.NewLine);
        }

        private void lblProdavac_Click(object sender, EventArgs e)
        {
            bool vlastitiOglas;

            if (trenutniKorisnik.ID == trenutniOglas.Prodavac.ID)
                vlastitiOglas = true;
            else
                vlastitiOglas = false;

            frmProfil prof = new frmProfil(trenutniOglas.Prodavac, vlastitiOglas);
            prof.Show();
        }
    }
}
