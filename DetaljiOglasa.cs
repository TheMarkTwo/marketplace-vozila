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

            byte[] imgBytes;
            Image img;
            if (trenutniOglas.Slika == "") imgBytes = Convert.FromBase64String(PodatkovniKontekst.tempSlikaOglasa);
            else imgBytes = Convert.FromBase64String(trenutniOglas.Slika);
            using (MemoryStream ms = new MemoryStream(imgBytes))
            {
                img = Image.FromStream(ms);
            }
            pboxSlika.Image = img;

            lblNazivOglasa.Text = trenutniOglas.NazivOglasa;
            lblCijena.Text = trenutniOglas.Cijena.ToString("0,0") + "kn";
            lblProdavac.Text = trenutniOglas.Prodavac.ToString();

            lblAutomobil.Text = trenutniOglas.VoziloZaProdaju.ToString() + $" ({trenutniOglas.VoziloZaProdaju.RadniObujam:0.0}L)";
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

        private void pboxSlika_Click(object sender, EventArgs e)
        {
            byte[] imgBytes;
            Image img;
            string base64Img = PodatkovniKontekst.GetImageBase64();
            if (base64Img != "")
            {
                trenutniOglas.Slika = base64Img;
                imgBytes = Convert.FromBase64String(base64Img);
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    img = Image.FromStream(ms);
                }
                pboxSlika.Image = img;
                trenutniOglas.AzurirajOglas();
            }
        }
    }
}
