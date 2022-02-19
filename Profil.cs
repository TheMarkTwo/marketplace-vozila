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
        public bool izbrisanOglas { get; set; } = false;
        byte[] imgBytes;
        Image img;
        List<Oglas> korisniceviOglasi = new List<Oglas>();
        Korisnik trenutniKorisnik;
        bool _vlastitiProfil;
        public frmProfil(Korisnik korisnik, bool vlastitiProfil)
        {
            _vlastitiProfil = vlastitiProfil;
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        public void AzurirajDGV()
        {
            dgvPrikazOglasa.Rows.Clear();
            korisniceviOglasi = Oglas.listaOglasa.Where(oglas => oglas.Prodavac.ID == trenutniKorisnik.ID).ToList();
            if (korisniceviOglasi.Count != 0)
            {
                foreach (Oglas oglas in korisniceviOglasi)
                {
                    if (oglas.Slika == "") imgBytes = Convert.FromBase64String(PodatkovniKontekst.tempSlikaOglasa);
                    else imgBytes = Convert.FromBase64String(oglas.Slika);
                    using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);
                    dgvPrikazOglasa.Rows.Add(oglas.ID, img, $"{oglas.NazivOglasa} \n\n\n {oglas.VoziloZaProdaju} \n Zupanija: {oglas.Lokacija}", $"{oglas.Cijena:0,0}kn");
                }
                dgvPrikazOglasa.CurrentRow.Selected = false;
            }
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            //popunjavanje polja korisnickim podatcima
            this.Text = trenutniKorisnik.KorisnickoIme;

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
            AzurirajDGV();
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
                    Korisnik.AzurirajKorisnike();
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
            UrediRacun urra = new UrediRacun(trenutniKorisnik);
            urra.ShowDialog();
        }

        private void btnUrediOglas_Click(object sender, EventArgs e)
        {
            if (dgvPrikazOglasa.SelectedRows.Count > 0)
            {
                Oglas oglas = Oglas.listaOglasa.Where(o => o.ID == int.Parse(dgvPrikazOglasa.Rows[dgvPrikazOglasa.CurrentCell.RowIndex].Cells[0].Value.ToString())).ToList()[0];
                UrediOglas urog = new UrediOglas(oglas);
                urog.ShowDialog();
            }
        }

        private void btnObrisiOglas_Click(object sender, EventArgs e)
        {
            if (dgvPrikazOglasa.SelectedRows.Count > 0)
            {
                Oglas oglas = Oglas.listaOglasa.Where(o => o.ID == int.Parse(dgvPrikazOglasa.Rows[dgvPrikazOglasa.CurrentCell.RowIndex].Cells[0].Value.ToString())).ToList()[0];
                Vozilo.listaVozila.Remove(oglas.VoziloZaProdaju);
                Oglas.listaOglasa.Remove(oglas);
                Vozilo.AzurirajVozila();
                Oglas.AzurirajOglase();
                izbrisanOglas = true;
                AzurirajDGV();
            }
        }
    }
}
