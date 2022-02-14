using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MarketplaceVozila.Model;

namespace MarketplaceVozila
{
    public partial class frmProfil : Form
    {
        List<Oglas> korisniceviOglasi = new List<Oglas>();
        Korisnik trenutniKorisnik;
        bool _vlastitiProfil;
        public frmProfil(Korisnik korisnik, bool vlastitiProfil)
        {
            _vlastitiProfil = vlastitiProfil;
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            //popunjavanje polja korisnickim podatcima
            this.Text = trenutniKorisnik.KorisnickoIme;

            byte[] imgBytes;
            Image img;
            if (trenutniKorisnik.Slika == "") imgBytes = Convert.FromBase64String(PodatkovniKontekst.tempProfilna);
            else imgBytes = Convert.FromBase64String(trenutniKorisnik.Slika);
            using (MemoryStream ms = new MemoryStream(imgBytes))
            {
                img = Image.FromStream(ms);
            }
            pboxProfilna.Image = img;

            if (!_vlastitiProfil)
                pboxProfilna.Cursor = Cursors.Default;

            lblKorisnickoIme.Text = trenutniKorisnik.KorisnickoIme;
            lblPunoIme.Text = trenutniKorisnik.PunoIme;
            lblAdresa.Text = trenutniKorisnik.Adresa;
            lblTelefon.Text = trenutniKorisnik.Broj;
            lblEmail.Text = trenutniKorisnik.Email;

            //kontroliranje opcijama vezane za vlastiti profil i oglase
            if (!_vlastitiProfil)
            {
                pnlKontrole.Enabled = false;
                pnlKontrole.Visible = false;
                this.Size = new Size(816, 486);
            }

            //popunjavanje DataGridView-a sa korisnicevim oglasima
            korisniceviOglasi = Oglas.listaOglasa.Where(oglas => oglas.Prodavac.ID == trenutniKorisnik.ID).ToList();
            if (korisniceviOglasi.Count != 0)
            {
                foreach (Oglas oglas in korisniceviOglasi)
                {
                    if (oglas.Slika == "") imgBytes = Convert.FromBase64String(PodatkovniKontekst.tempSlikaOglasa);
                    else imgBytes = Convert.FromBase64String(oglas.Slika);
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        img = Image.FromStream(ms);
                    }

                    dgvPrikazOglasa.Rows.Add(oglas.ID, img, $"{oglas.NazivOglasa} \n\n\n {oglas.VoziloZaProdaju} \n Zupanija: {oglas.Lokacija}", $"{oglas.Cijena:0,0}kn");
                }
                dgvPrikazOglasa.CurrentRow.Selected = false;
            }
        }

        private void pboxProfilna_Click(object sender, EventArgs e)
        {
            if (_vlastitiProfil)
            {
                byte[] imgBytes;
                Image img;
                string base64Img = PodatkovniKontekst.GetImageBase64();
                if (base64Img != "")
                {
                    trenutniKorisnik.Slika = base64Img;
                    imgBytes = Convert.FromBase64String(base64Img);
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        img = Image.FromStream(ms);
                    }
                    pboxProfilna.Image = img;
                    trenutniKorisnik.AzurirajKorisnika();
                } 
            }
        }

        private void dgvPrikazOglasa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Oglas oglas = Oglas.listaOglasa.Where(o => o.ID == int.Parse(dgvPrikazOglasa.Rows[e.RowIndex].Cells[0].Value.ToString())).ToList()[0];
            frmDetaljiOglasa deog = new frmDetaljiOglasa(oglas, trenutniKorisnik);
            deog.Show();
        }

        private void btnObrisiKRacun_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da zelite izbrisati korisnicki racun?", "Brisanje korisnickog racuna", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                frmMarketplace.Odjava(this);
            }
        }

        private void btnUrediKRacun_Click(object sender, EventArgs e)
        {

        }

        private void btnUrediOglas_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisiOglas_Click(object sender, EventArgs e)
        {

        }
    }
}
