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
        List<Oglas> listaPretrazenihOglasa = null;

        public frmMarketplace(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        /// <summary>
        /// Cisti sva popunjena polja za pretragu glavne forme, cisti DataGridView za oglase
        /// </summary>
        public void OcistiPretragu()
        {
            cmbKategorija.SelectedIndex = -1;
            cmbLokacija.SelectedIndex = -1;
            cmbSortiranje.SelectedIndex = -1;
            cmbMarka.Enabled = false;
            cmbMarka.SelectedIndex = -1;
            cmbModel.Enabled = false;
            cmbModel.SelectedIndex = -1;
            pnlAtributi.Controls.Clear();
        }

        //
        // Marketplace eventi
        private void frmMarketplace_Load(object sender, EventArgs e)
        {
            cmbKategorija.DataSource = PodatkovniKontekst.listaKategorija;
            cmbLokacija.DataSource = PodatkovniKontekst.popisLokacija;
            cmbSortiranje.DataSource = PodatkovniKontekst.sortiranjePo;
            lblKorisnickoIme.Text = trenutniKorisnik.KorisnickoIme;
            OcistiPretragu();
        }

        // Azuriranje popisa marka, ovisno o odabranoj kategoriji vozila
        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarka.DataSource = null;
            listaMarki.Clear();
            cmbMarka.Items.Clear();
            string odabranaKategorija = cmbKategorija.GetItemText(cmbKategorija.SelectedItem);
            foreach (Vozilo v in Vozilo.listaVozila)
            {
                if (odabranaKategorija == v.GetType().Name) 
                    listaMarki.Add(v.Marka);
            }
            listaMarki = listaMarki.Distinct().ToList();
            listaMarki.Sort();
            cmbMarka.DataSource = listaMarki;
            cmbMarka.SelectedIndex = -1;
            if (cmbMarka.Items.Count <= 0) cmbMarka.Enabled = false; else cmbMarka.Enabled = true;

            PodatkovniKontekst.DinamicneKontroleVozila(pnlAtributi, odabranaKategorija);
        }

        // Azuriranje popisa modela, ovisno o odabranoj marci vozila
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.DataSource = null;
            listaModela.Clear();
            cmbModel.Items.Clear();
            string odabranaMarka = cmbMarka.GetItemText(cmbMarka.SelectedItem);
            foreach (Vozilo v in Vozilo.listaVozila)
            {
                if (odabranaMarka == v.Marka) 
                    listaModela.Add(v.Model);
            }
            listaModela = listaModela.Distinct().ToList();
            listaModela.Sort();
            cmbModel.DataSource = listaModela;
            cmbModel.SelectedIndex = -1;
            if (cmbModel.Items.Count <= 0) cmbModel.Enabled = false; else cmbModel.Enabled = true;
        }

        // Filtriranje po unesenim podacima
        private void btn_Pretraga_Click(object sender, EventArgs e)
        {
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
                    
                    dgvPrikazOglasa.Rows.Add(oglas.ID, slika, $"{oglas.NazivOglasa} \n\n\n {oglas.VoziloZaProdaju} \n Zupanija: {oglas.Lokacija} \n Prijedeni kilometri: {oglas.VoziloZaProdaju.PrijedeniKilometri.ToString("0,0") + "km"}", $"{oglas.Cijena:0,0}kn", oglas.VoziloZaProdaju.PrijedeniKilometri, oglas.Cijena);
                }
            }
            if (dgvPrikazOglasa.SelectedRows.Count > 0)
                dgvPrikazOglasa.CurrentRow.Selected = false;
        }

        // Sortiranje oglasa nakon ispisivanja
        private void cmbSortiranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortirajPo = cmbSortiranje.GetItemText(cmbSortiranje.SelectedItem);
            switch (sortirajPo)
            {
                case "Nazivu":
                    dgvPrikazOglasa.Sort(dgvPrikazOglasa.Columns["Opis"], ListSortDirection.Ascending); break;
                case "Najevcoj kilometrazi":
                    dgvPrikazOglasa.Sort(dgvPrikazOglasa.Columns["Kilometraza"], ListSortDirection.Descending); break;
                case "Najmanjoj kilometrazi":
                    dgvPrikazOglasa.Sort(dgvPrikazOglasa.Columns["Kilometraza"], ListSortDirection.Ascending); break;
                case "Najevcoj cijeni":
                    dgvPrikazOglasa.Sort(dgvPrikazOglasa.Columns["RawCijena"], ListSortDirection.Descending); break;
                case "Najmanjoj cijeni":
                    dgvPrikazOglasa.Sort(dgvPrikazOglasa.Columns["RawCijena"], ListSortDirection.Ascending); break;
                default: break;
            }
        }

        // Definiranje nacina za sortiranje DataGridView-a
        private void dgvPrikazOglasa_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 4 || e.Column.Index == 5)
            {
                e.SortResult = double.Parse(e.CellValue1.ToString()).CompareTo(double.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }

        private void btnOcistiPretragu_Click(object sender, EventArgs e)
        {
            OcistiPretragu();
        }

        //
        // Metode za otvaranje drugih formi
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
