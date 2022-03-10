using System;
using System.Windows.Forms;
using MarketplaceVozila.Model;

namespace MarketplaceVozila
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string kime = txtKorisnickoIme.Text;
            string loz = txtLozinka.Text;
            bool uspjesno = false;
            //provjerava postojanje korisnika u bazi
            foreach (Korisnik k in Korisnik.listaKorisnika)
            {
                if (kime == k.KorisnickoIme && loz == k.Lozinka)
                {
                    frmMarketplace mp = new frmMarketplace(k);
                    this.Hide();
                    mp.ShowDialog();
                    this.Close();
                    uspjesno = true;
                    break;
                }
            }
            if (!uspjesno)
            {
                MessageBox.Show("Provjerite jeste li tocno unjeli korisnicko ime ili lozinku.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLozinka.Text = "";
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija reg = new frmRegistracija();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void btnGost_Click(object sender, EventArgs e)
        {
            frmMarketplace mp = new frmMarketplace(new Korisnik { KorisnickoIme = "Gost"} );
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }
    }
}
