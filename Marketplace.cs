using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        void OcistiPretragu()
        {
            cmbKategorija.SelectedIndex = -1;
            cmbLokacija.SelectedIndex = -1;
            cmbSortiranje.SelectedIndex = -1;
            cmbMarka.Enabled = false;
            cmbMarka.SelectedIndex = -1;
            cmbModel.Enabled = false;
            cmbModel.SelectedIndex = -1;
            pnlAtributi.Controls.Clear();
            dgvPrikazOglasa.Rows.Clear();
        }

        /// <summary>
        /// Odjavljuje korisnika iz profila i vraca ga na formu prijave
        /// </summary>
        void Odjava()
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

        void PretragaOdDo<T>(TextBox txtOd, TextBox txtDo, Func<Oglas, T> propZaUsporedbu) where T: IComparable<T>
        {
            T vrjOd = default;
            T vrjDo = default;

            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Double:
                    vrjDo = (T)(dynamic)double.MaxValue;
                    break;
                case TypeCode.Int32:
                    vrjDo = (T)(dynamic)int.MaxValue;
                    break;
            }

            if (txtOd.Text != "" || txtDo.Text != "")
            {
                try
                {
                    if (txtOd.Text != "") vrjOd = (T)Convert.ChangeType(txtOd.Text, typeof(T));
                    if (txtDo.Text != "") vrjDo = (T)Convert.ChangeType(txtDo.Text, typeof(T));

                    listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => vrjOd.CompareTo(propZaUsporedbu(o)) <= 0 && propZaUsporedbu(o).CompareTo(vrjDo) <= 0).ToList();
                }
                catch (Exception)
                {
                    txtOd.Text = "";
                    txtDo.Text = "";
                }
            }
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

            if (trenutniKorisnik.KorisnickoIme == "Gost")
            {
                lblKorisnickoIme.Enabled = false;
                btnKreirajOglas.Enabled = false;
            }
        }

        // Azuriranje popisa marka, ovisno o odabranoj kategoriji vozila
        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabranaKategorija = cmbKategorija.GetItemText(cmbKategorija.SelectedItem);

            cmbMarka.DataSource = null;
            listaMarki.Clear();
            cmbMarka.Items.Clear();
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

            PodatkovniKontekst.DinamicneKontroleVozila(pnlAtributi, odabranaKategorija, new Size(194, 21));
        }

        // Azuriranje popisa modela, ovisno o odabranoj marci vozila
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabranaMarka = cmbMarka.GetItemText(cmbMarka.SelectedItem);

            cmbModel.DataSource = null;
            listaModela.Clear();
            cmbModel.Items.Clear();
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
            string kategorija = cmbKategorija.GetItemText(cmbKategorija.SelectedItem);

            if (kategorija != "")
                listaPretrazenihOglasa = Oglas.listaOglasa.Where(o => o.VoziloZaProdaju.Kategorija == kategorija).ToList();
            if (cmbMarka.GetItemText(cmbMarka.SelectedItem) != "")
                listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => o.VoziloZaProdaju.Marka == cmbMarka.GetItemText(cmbMarka.SelectedItem)).ToList();
            if (cmbModel.GetItemText(cmbModel.SelectedItem) != "")
                listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => o.VoziloZaProdaju.Model == cmbModel.GetItemText(cmbModel.SelectedItem)).ToList();

            if (kategorija != "")
            {
                PretragaOdDo(txtSnagaMotoraOd, txtSnagaMotoraDo, o => o.VoziloZaProdaju.SnagaMotora);
                PretragaOdDo(txtGodinaPorizvodnjeOd, txtGodinaPorizvodnjeDo, o => o.VoziloZaProdaju.GodinaProizvodnje);
                PretragaOdDo(txtPrijedeniKilometriOd, txtPrijedeniKilometriDo, o => o.VoziloZaProdaju.PrijedeniKilometri);
                PretragaOdDo(txtCijenaOd, txtCijenaDo, o => o.Cijena);
            }

            if (cmbLokacija.GetItemText(cmbLokacija.SelectedItem) != "")
                listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => o.Lokacija == cmbLokacija.GetItemText(cmbLokacija.SelectedItem)).ToList();

            string[] vrijednostiAtr = PodatkovniKontekst.DohvatiVrijednostiKontrola(pnlAtributi);
            try
            {
                switch (kategorija)
                {
                    case "Automobil":
                        if (vrijednostiAtr[0] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Automobil)o.VoziloZaProdaju).TipAutomobila.Contains(vrijednostiAtr[0])).ToList();
                        if (vrijednostiAtr[1] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Automobil)o.VoziloZaProdaju).Motor == vrijednostiAtr[1]).ToList();
                        if (vrijednostiAtr[2] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Automobil)o.VoziloZaProdaju).Mjenjac == vrijednostiAtr[2]).ToList();
                        break;

                    case "Motocikl":
                        if (vrijednostiAtr[0] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Motocikl)o.VoziloZaProdaju).Vrsta == vrijednostiAtr[0]).ToList();
                        if (vrijednostiAtr[1] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Motocikl)o.VoziloZaProdaju).Motor == vrijednostiAtr[1]).ToList();
                        break;

                    case "Kombi":
                        if (vrijednostiAtr[0] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Kombi)o.VoziloZaProdaju).TipKombia.Contains(vrijednostiAtr[0])).ToList();
                        if (vrijednostiAtr[1] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Kombi)o.VoziloZaProdaju).Motor == vrijednostiAtr[1]).ToList();
                        if (vrijednostiAtr[2] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Kombi)o.VoziloZaProdaju).Mjenjac == vrijednostiAtr[2]).ToList();
                        break;

                    case "Kamion":
                        if (vrijednostiAtr[0] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Kamion)o.VoziloZaProdaju).TipKamiona.Contains(vrijednostiAtr[0])).ToList();
                        if (vrijednostiAtr[1] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Kamion)o.VoziloZaProdaju).Motor == vrijednostiAtr[1]).ToList();
                        if (vrijednostiAtr[2] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Kamion)o.VoziloZaProdaju).MaksimalnaNosivost <= double.Parse(vrijednostiAtr[2])).ToList();
                        break;

                    case "Traktor":
                        if (vrijednostiAtr[0] != "") listaPretrazenihOglasa = listaPretrazenihOglasa.Where(o => ((Traktor)o.VoziloZaProdaju).RadniSati <= double.Parse(vrijednostiAtr[0])).ToList();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }

            //Ispisivanje oglasa u DataGridView
            dgvPrikazOglasa.Rows.Clear();
            if (listaPretrazenihOglasa != null)
            {
                foreach (Oglas oglas in listaPretrazenihOglasa)
                {
                    byte[] imgBytes;
                    Image img;
                    if (oglas.Slika == "") imgBytes = Convert.FromBase64String(PodatkovniKontekst.tempSlikaOglasa);
                    else imgBytes = Convert.FromBase64String(oglas.Slika);
                    using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);

                    dgvPrikazOglasa.Rows.Add(oglas.ID, img, $"{oglas.NazivOglasa} \n\n\n {oglas.VoziloZaProdaju} \n Zupanija: {oglas.Lokacija} \n Prijedeni kilometri: {oglas.VoziloZaProdaju.PrijedeniKilometri.ToString("0,0") + "km"}", $"{oglas.Cijena:0,0}kn", oglas.VoziloZaProdaju.PrijedeniKilometri, oglas.Cijena);
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
            Odjava();
        }

        private void lblKorisnickoIme_Click(object sender, EventArgs e)
        {
            frmProfil pro = new frmProfil(trenutniKorisnik, true);
            pro.ShowDialog();
            if (pro.izbrisanOglas) dgvPrikazOglasa.Rows.Clear();
            if (pro.izbrisanProfil)
            {
                for (int i = Oglas.listaOglasa.Count; i-- > 0;)
                {
                    if (trenutniKorisnik.ID == Oglas.listaOglasa[i].Prodavac.ID)
                    {
                        Vozilo.listaVozila.Remove(Oglas.listaOglasa[i].VoziloZaProdaju);
                        Oglas.listaOglasa.Remove(Oglas.listaOglasa[i]);
                    }
                }
                Vozilo.AzurirajVozila();
                Oglas.AzurirajOglase();
                Korisnik.listaKorisnika.Remove(trenutniKorisnik);
                Korisnik.AzurirajKorisnike();
                Odjava();
            }
        }

        private void btnKreirajOglas_Click(object sender, EventArgs e)
        {
            frmKreiranjeOglasa krog = new frmKreiranjeOglasa(trenutniKorisnik);
            krog.ShowDialog();
            OcistiPretragu();
        }

        private void dgvPrikazOglasa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Oglas oglas = Oglas.listaOglasa.Where(o => o.ID == int.Parse(dgvPrikazOglasa.Rows[e.RowIndex].Cells[0].Value.ToString())).ToList()[0];
            frmDetaljiOglasa deog = new frmDetaljiOglasa(oglas, trenutniKorisnik);
            deog.Show();
        }
    }
}
