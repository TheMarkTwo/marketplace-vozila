using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MarketplaceVozila.Model;

namespace MarketplaceVozila
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            //provjerava jesu li prazne TextBox kontrole
            bool uspjesno = true;
            foreach (Control control in pnlPodatci.Controls)
            {
                if (control.Text.Trim() != "")
                    uspjesno = true;
                else
                {
                    uspjesno = false; 
                    break;
                }
            }

            if (!uspjesno)
            {
                DialogResult d = MessageBox.Show("Sva polja su potrebna popuniti", "Greska", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Retry)
                {
                    foreach (Control control in pnlPodatci.Controls)
                        control.Text = "";
                }
            }

            //provjerava dostupnost korisnickih podataka
            else if (uspjesno)
            {
                DialogResult d = DialogResult.OK;
                int brojKImena = Korisnik.listaKorisnika.Where(k => k.KorisnickoIme == txtKorisnickoIme.Text).Count();
                int brojEmaila = Korisnik.listaKorisnika.Where(k => k.Email == txtEmail.Text).Count();
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
            }

            if (uspjesno)
            {
                int ID = ++PodatkovniKontekst.IDs[1];
                Korisnik korisnik = new Korisnik() {
                    ID = ID,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                    PunoIme = txtPunoIme.Text,
                    Adresa = txtAdresa.Text,
                    Broj = txtTelefon.Text,
                    Email = txtEmail.Text
                };
                Korisnik.listaKorisnika.Add(korisnik);
                korisnik.SpremiKorisnika();
                DialogResult d = MessageBox.Show("Registrirali ste se", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    frmPrijava pri = new frmPrijava();
                    this.Hide();
                    pri.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            frmPrijava pri = new frmPrijava();
            this.Hide();
            pri.ShowDialog();
            this.Close();
        }
    }
}
