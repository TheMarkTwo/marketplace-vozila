using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketplaceVozila.Model;

namespace MarketplaceVozila
{
    public partial class UrediRacun : Form
    {
        Korisnik trenutniKorisnik;
        public UrediRacun(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void UrediRacun_Load(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = trenutniKorisnik.KorisnickoIme;
            txtEmail.Text = trenutniKorisnik.Email;
            txtPunoIme.Text = trenutniKorisnik.PunoIme;
            txtAdresa.Text = trenutniKorisnik.Adresa;
            txtTelefon.Text = trenutniKorisnik.Broj;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            //provjerava jesu li prazne TextBox kontrole
            bool uspjesno = true;
            foreach (Control control in pnlPodatci.Controls)
            {
                if (control.Text.Trim() != "" || control.Name == "txtLozinka" || control.Name == "txtPotvrdiLozinku")
                    uspjesno = true;
                else
                {
                    uspjesno = false;
                    break;
                }
            }

            if (!uspjesno)
            {
                DialogResult d = MessageBox.Show("Sva polja su potrebna popuniti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //provjerava dostupnost korisnickih podataka
            else if (uspjesno)
            {
                int brojEmaila = 0;
                int brojKImena = 0;
                DialogResult d = DialogResult.OK;
                if (txtEmail.Text != trenutniKorisnik.Email) brojEmaila = Korisnik.listaKorisnika.Where(k => k.Email == txtEmail.Text).Count();
                if (txtKorisnickoIme.Text != trenutniKorisnik.KorisnickoIme) brojKImena = Korisnik.listaKorisnika.Where(k => k.KorisnickoIme == txtKorisnickoIme.Text).Count();

                if (brojKImena != 0)
                {
                    d = MessageBox.Show("Korisicnko ime je vec registrirano", "Greska", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    uspjesno = false;
                }
                else if (brojEmaila != 0)
                {
                    d = MessageBox.Show("E-mail je vec registriran", "Greska", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    uspjesno = false;
                }
                else if (!txtEmail.Text.Contains("@"))
                {
                    d = MessageBox.Show("E-mail mora sadrzavat znak @", "Greska", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    uspjesno = false;
                }
                else if (txtLozinka.Text != txtPotvrdiLozinku.Text)
                {
                    d = MessageBox.Show("Lozinke se ne podudaraju", "Greska", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    uspjesno = false;
                }

                if (d == DialogResult.Retry)
                {
                    foreach (Control control in pnlPodatci.Controls)
                        control.Text = "";
                }

                if (uspjesno)
                {
                    foreach (Korisnik korisnik in Korisnik.listaKorisnika)
                    {
                        if (korisnik.ID == trenutniKorisnik.ID)
                        {
                            trenutniKorisnik.KorisnickoIme = txtKorisnickoIme.Text;
                            trenutniKorisnik.Email = txtEmail.Text;
                            trenutniKorisnik.PunoIme = txtPunoIme.Text;
                            trenutniKorisnik.Adresa = txtAdresa.Text;
                            trenutniKorisnik.Broj = txtTelefon.Text;
                            if (txtLozinka.Text != "" && txtPotvrdiLozinku.Text != "") trenutniKorisnik.Lozinka = txtLozinka.Text;
                        }
                    }
                    trenutniKorisnik.AzurirajKorisnika();
                    MessageBox.Show("Spremili ste nove podatke", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
