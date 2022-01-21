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
            string putanjaSlike = $"{PodatkovniKontekst.slikeKorisnika}{trenutniKorisnik.ID}.jpg";
            if (File.Exists(putanjaSlike))
                pboxProfilna.Image = Image.FromFile(putanjaSlike);
            else
                pboxProfilna.Image = Image.FromFile(PodatkovniKontekst.tempProfilna);
            putanjaSlike = null;

            if (!_vlastitiProfil)
                pboxProfilna.Cursor = Cursors.Default;

            lblKorisnickoIme.Text = trenutniKorisnik.KorisnickoIme;
            lblPunoIme.Text = trenutniKorisnik.PunoIme;
            lblAdresa.Text = trenutniKorisnik.Adresa;
            lblTelefon.Text = trenutniKorisnik.Broj;
            lblEmail.Text = trenutniKorisnik.Email;

            //popunjavanje DataGridView-a sa korisnicevim oglasima
            korisniceviOglasi = Oglas.listaOglasa.Where(oglas => oglas.Prodavac.ID == trenutniKorisnik.ID).ToList();
            if (korisniceviOglasi.Count != 0)
            {
                foreach (Oglas oglas in korisniceviOglasi)
                {
                    Image slika;
                    if (File.Exists($"{PodatkovniKontekst.slikeOglasa}{oglas.VoziloZaProdaju.ID}.jpg"))
                        slika = Image.FromFile($"{PodatkovniKontekst.slikeOglasa}{oglas.VoziloZaProdaju.ID}.jpg");
                    else
                        slika = Image.FromFile(PodatkovniKontekst.tempSlikaOglasa);
                    dgvPrikazOglasa.Rows.Add(oglas.ID, slika, $"{oglas.NazivOglasa} \n\n\n {oglas.VoziloZaProdaju} \n Zupanija: {oglas.Lokacija}", $"{oglas.Cijena:0,0}kn");
                }
                dgvPrikazOglasa.CurrentRow.Selected = false;
            }
        }

        private void pboxProfilna_Click(object sender, EventArgs e)
        {
            if (_vlastitiProfil)
            {
                string profilnaPath = PodatkovniKontekst.slikeKorisnika + trenutniKorisnik.ID + ".jpg";
                //dodavanje profilne slike
                //if (!File.Exists(profilnaPath)) // dodaj replace slike
                //{
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "JPG Files|*.jpg";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pboxProfilna.Image = null;
                        if (File.Exists(profilnaPath))
                            File.Delete(profilnaPath);
                        string filePath = openFileDialog.FileName;
                        File.Copy(filePath, profilnaPath);
                        pboxProfilna.Image = Image.FromFile(profilnaPath);
                    }
                }
                //}
            }
        }

        private void dgvPrikazOglasa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Oglas oglas = Oglas.listaOglasa.Where(o => o.ID == int.Parse(dgvPrikazOglasa.Rows[e.RowIndex].Cells[0].Value.ToString())).ToList()[0];
            frmDetaljiOglasa deog = new frmDetaljiOglasa(oglas, trenutniKorisnik);
            deog.Show();
        }
    }
}
