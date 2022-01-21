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
    public partial class frmMarketplace : Form
    {
        readonly Korisnik trenutniKorisnik;
        List<string> listaMarki = new List<string>();
        List<string> listaModela = new List<string>();

        public frmMarketplace(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void OcistiPretragu()
        {
            cmbKategorija.SelectedIndex = -1;
            cmbLokacija.SelectedIndex = -1;
            cmbMarka.Enabled = false;
            cmbMarka.SelectedIndex = -1;
            cmbModel.Enabled = false;
            cmbModel.SelectedIndex = -1;
            pnlAtributi.Controls.Clear();
        }

        private void frmMarketplace_Load(object sender, EventArgs e)
        {
            cmbKategorija.DataSource = PodatkovniKontekst.listaKategorija;
            cmbLokacija.DataSource = PodatkovniKontekst.popisLokacija;
            OcistiPretragu();
            lblKorisnickoIme.Text = trenutniKorisnik.KorisnickoIme;
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Azuriranje popisa marka, ovisno o odabranoj kategoriji vozila
            cmbMarka.DataSource = null;
            listaMarki.Clear();
            cmbMarka.Items.Clear();
            string odabranaKategorija = cmbKategorija.GetItemText(cmbKategorija.SelectedItem);
            foreach (Vozilo v in Vozilo.listaVozila)
            {
                if (odabranaKategorija == v.GetType().Name) listaMarki.Add(v.Marka);
            }
            listaMarki = listaMarki.Distinct().ToList();
            listaMarki.Sort();
            cmbMarka.DataSource = listaMarki;
            cmbMarka.SelectedIndex = -1;
            if (cmbMarka.Items.Count <= 0) cmbMarka.Enabled = false; else cmbMarka.Enabled = true;

            PodatkovniKontekst.DinamicneKontroleVozila(pnlAtributi, odabranaKategorija);
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Azuriranje popisa modela, ovisno o odabranoj marci vozila
            cmbModel.DataSource = null;
            listaModela.Clear();
            cmbModel.Items.Clear();
            string odabranaMarka = cmbMarka.GetItemText(cmbMarka.SelectedItem);
            foreach (Vozilo v in Vozilo.listaVozila)
            {
                if (odabranaMarka == v.Marka) listaModela.Add(v.Model);
            }
            listaModela = listaModela.Distinct().ToList();
            listaModela.Sort();
            cmbModel.DataSource = listaModela;
            cmbModel.SelectedIndex = -1;
            if (cmbModel.Items.Count <= 0) cmbModel.Enabled = false; else cmbModel.Enabled = true;
        }

        private void btn_Pretraga_Click(object sender, EventArgs e)
        {
            //Filtriranje po unesenim podacima
            List<Oglas> listaPretrazenihOglasa = null;

            if (cmbKategorija.GetItemText(cmbKategorija.SelectedItem) != "")
                listaPretrazenihOglasa = Oglas.listaOglasa.Where(o => o.VoziloZaProdaju.Kategorija == cmbKategorija.GetItemText(cmbKategorija.SelectedItem)).ToList();
            if (cmbMarka.GetItemText(cmbMarka.SelectedItem) != "")
                listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => o.VoziloZaProdaju.Marka == cmbMarka.GetItemText(cmbMarka.SelectedItem)).ToList();
            if (cmbModel.GetItemText(cmbModel.SelectedItem) != "")
                listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => o.VoziloZaProdaju.Model == cmbModel.GetItemText(cmbModel.SelectedItem)).ToList();

            //Ispisivanje oglasa u DataGridView
            dgvPrikazOglasa.Rows.Clear();
            if (listaPretrazenihOglasa != null)
            {
                foreach (Oglas oglas in listaPretrazenihOglasa)
                {
                    Image slika;
                    if (File.Exists($"{PodatkovniKontekst.slikeOglasa}{oglas.VoziloZaProdaju.ID}.jpg"))
                        slika = Image.FromFile($"{PodatkovniKontekst.slikeOglasa}{oglas.VoziloZaProdaju.ID}.jpg");
                    else
                        slika = Image.FromFile(PodatkovniKontekst.tempSlikaOglasa);
                    
                    dgvPrikazOglasa.Rows.Add(oglas.ID, slika, $"{oglas.NazivOglasa} \n\n\n {oglas.VoziloZaProdaju} \n Zupanija: {oglas.Lokacija}", $"{oglas.Cijena:0,0}kn");
                }
            }
            if (dgvPrikazOglasa.SelectedRows.Count > 0)
                dgvPrikazOglasa.CurrentRow.Selected = false;
        }

        private void dgvPrikazOglasa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idOglasa = int.Parse(dgvPrikazOglasa.Rows[e.RowIndex].Cells[0].Value.ToString());
            foreach (Oglas oglas in Oglas.listaOglasa)
            {
                if (oglas.ID == idOglasa && oglas.Prodavac.ID == trenutniKorisnik.ID)
                {
                    btnUrediOglas.Enabled = true;
                    btnObrisiOglas.Enabled = true;
                }
                else
                {
                    btnUrediOglas.Enabled = false;
                    btnObrisiOglas.Enabled = false;
                }
            }
        }

        private void btnOcistiPretragu_Click(object sender, EventArgs e)
        {
            OcistiPretragu();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            List<Form> otvoreneForme = new List<Form>();
            foreach (Form frm in Application.OpenForms)
                otvoreneForme.Add(frm);

            foreach (Form frm in otvoreneForme)
            {
                if (frm.Name != "frmPrijava")
                    frm.Close();
            }

            frmPrijava pri = new frmPrijava();
            this.Hide();
            pri.ShowDialog();
            this.Close();
        }

        private void lblKorisnickoIme_Click(object sender, EventArgs e)
        {
            frmProfil pro = new frmProfil(trenutniKorisnik, true);
            pro.ShowDialog();
        }

        private void btnKreirajOglas_Click(object sender, EventArgs e)
        {
            frmKreiranjeOglasa krog = new frmKreiranjeOglasa(trenutniKorisnik);
            krog.ShowDialog();
        }

        private void dgvPrikazOglasa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Oglas oglas = Oglas.listaOglasa.Where(o => o.ID == int.Parse(dgvPrikazOglasa.Rows[e.RowIndex].Cells[0].Value.ToString())).ToList()[0];
            frmDetaljiOglasa deog = new frmDetaljiOglasa(oglas, trenutniKorisnik);
            deog.Show();
        }
    }
}
