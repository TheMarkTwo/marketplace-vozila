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
        public frmProfil(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            //popunjavanje polja korisnickim podatcima
            this.Text = trenutniKorisnik.KorisnickoIme;
            string putanjaSlike = $"{PodatkovniKontekst.slikeKorisnika}{trenutniKorisnik.ID}.jpg";
            //Image tempslika;
            if (File.Exists(putanjaSlike))
            //{
            //    using (Image slika = Image.FromFile(putanjaSlike))
            //    {
            //        tempslika = slika;   
            //    }
            //    pboxProfilna.Image = tempslika;
            //} VELIKI ERROR
                pboxProfilna.Image = Image.FromFile(putanjaSlike);
            else
                pboxProfilna.Image = Image.FromFile(PodatkovniKontekst.tempProfilna);
            putanjaSlike = null;

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

        private void dgvPrikazOglasa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Oglas oglas = Oglas.listaOglasa.Where(o => o.ID == int.Parse(dgvPrikazOglasa.Rows[e.RowIndex].Cells[0].Value.ToString())).ToList()[0];
            frmDetaljiOglasa deog = new frmDetaljiOglasa(oglas);
            deog.Show();
        }
    }
}
