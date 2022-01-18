
namespace MarketplaceVozila
{
    partial class frmKreiranjeOglasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKreiranjeOglasa));
            this.pboxSlika = new System.Windows.Forms.PictureBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblPrijedeniKilometri = new System.Windows.Forms.Label();
            this.txtPrijedeniKilometri = new System.Windows.Forms.TextBox();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.txtGodinaPorizvodnje = new System.Windows.Forms.TextBox();
            this.lblSnagaMotora = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.txtSnagaMotora = new System.Windows.Forms.TextBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.pnlAtributi = new System.Windows.Forms.Panel();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtRadniObujam = new System.Windows.Forms.TextBox();
            this.lblRadniObujam = new System.Windows.Forms.Label();
            this.txtNazivOglasa = new System.Windows.Forms.TextBox();
            this.lblNazivOglasa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxSlika
            // 
            this.pboxSlika.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pboxSlika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxSlika.Location = new System.Drawing.Point(12, 12);
            this.pboxSlika.Name = "pboxSlika";
            this.pboxSlika.Size = new System.Drawing.Size(300, 222);
            this.pboxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSlika.TabIndex = 1;
            this.pboxSlika.TabStop = false;
            this.pboxSlika.Click += new System.EventHandler(this.pboxSlika_Click);
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCijena.Location = new System.Drawing.Point(168, 291);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 42;
            this.lblCijena.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCijena.Location = new System.Drawing.Point(171, 307);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 8;
            // 
            // lblPrijedeniKilometri
            // 
            this.lblPrijedeniKilometri.AutoSize = true;
            this.lblPrijedeniKilometri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrijedeniKilometri.Location = new System.Drawing.Point(26, 461);
            this.lblPrijedeniKilometri.Name = "lblPrijedeniKilometri";
            this.lblPrijedeniKilometri.Size = new System.Drawing.Size(92, 13);
            this.lblPrijedeniKilometri.TabIndex = 39;
            this.lblPrijedeniKilometri.Text = "Prijedeni Kilometri:";
            // 
            // txtPrijedeniKilometri
            // 
            this.txtPrijedeniKilometri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrijedeniKilometri.Location = new System.Drawing.Point(29, 477);
            this.txtPrijedeniKilometri.Name = "txtPrijedeniKilometri";
            this.txtPrijedeniKilometri.Size = new System.Drawing.Size(121, 20);
            this.txtPrijedeniKilometri.TabIndex = 6;
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(26, 420);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(98, 13);
            this.lblGodinaProizvodnje.TabIndex = 36;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje";
            // 
            // txtGodinaPorizvodnje
            // 
            this.txtGodinaPorizvodnje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGodinaPorizvodnje.Location = new System.Drawing.Point(29, 436);
            this.txtGodinaPorizvodnje.Name = "txtGodinaPorizvodnje";
            this.txtGodinaPorizvodnje.Size = new System.Drawing.Size(121, 20);
            this.txtGodinaPorizvodnje.TabIndex = 5;
            // 
            // lblSnagaMotora
            // 
            this.lblSnagaMotora.AutoSize = true;
            this.lblSnagaMotora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSnagaMotora.Location = new System.Drawing.Point(26, 374);
            this.lblSnagaMotora.Name = "lblSnagaMotora";
            this.lblSnagaMotora.Size = new System.Drawing.Size(100, 13);
            this.lblSnagaMotora.TabIndex = 33;
            this.lblSnagaMotora.Text = "Snaga Motora (kW)";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModel.Location = new System.Drawing.Point(26, 331);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 31;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMarka.Location = new System.Drawing.Point(26, 291);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 29;
            this.lblMarka.Text = "Marka";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKategorija.Location = new System.Drawing.Point(26, 251);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(54, 13);
            this.lblKategorija.TabIndex = 27;
            this.lblKategorija.Text = "Kategorija";
            // 
            // txtSnagaMotora
            // 
            this.txtSnagaMotora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSnagaMotora.Location = new System.Drawing.Point(29, 390);
            this.txtSnagaMotora.Name = "txtSnagaMotora";
            this.txtSnagaMotora.Size = new System.Drawing.Size(121, 20);
            this.txtSnagaMotora.TabIndex = 4;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategorija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(29, 267);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.TabIndex = 1;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // txtMarka
            // 
            this.txtMarka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMarka.Location = new System.Drawing.Point(29, 307);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 20);
            this.txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtModel.Location = new System.Drawing.Point(29, 347);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 3;
            // 
            // pnlAtributi
            // 
            this.pnlAtributi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlAtributi.Location = new System.Drawing.Point(171, 377);
            this.pnlAtributi.Name = "pnlAtributi";
            this.pnlAtributi.Size = new System.Drawing.Size(121, 119);
            this.pnlAtributi.TabIndex = 10;
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLokacija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(171, 347);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(121, 21);
            this.cmbLokacija.TabIndex = 9;
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLokacija.Location = new System.Drawing.Point(168, 331);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(47, 13);
            this.lblLokacija.TabIndex = 47;
            this.lblLokacija.Text = "Lokacija";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(331, 436);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(457, 59);
            this.btnKreiraj.TabIndex = 25;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(331, 79);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(457, 333);
            this.txtOpis.TabIndex = 20;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOpis.Location = new System.Drawing.Point(328, 63);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(31, 13);
            this.lblOpis.TabIndex = 51;
            this.lblOpis.Text = "Opis:";
            // 
            // txtRadniObujam
            // 
            this.txtRadniObujam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRadniObujam.Location = new System.Drawing.Point(171, 268);
            this.txtRadniObujam.Name = "txtRadniObujam";
            this.txtRadniObujam.Size = new System.Drawing.Size(121, 20);
            this.txtRadniObujam.TabIndex = 7;
            // 
            // lblRadniObujam
            // 
            this.lblRadniObujam.AutoSize = true;
            this.lblRadniObujam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRadniObujam.Location = new System.Drawing.Point(168, 252);
            this.lblRadniObujam.Name = "lblRadniObujam";
            this.lblRadniObujam.Size = new System.Drawing.Size(72, 13);
            this.lblRadniObujam.TabIndex = 52;
            this.lblRadniObujam.Text = "Radni obujam";
            // 
            // txtNazivOglasa
            // 
            this.txtNazivOglasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNazivOglasa.Location = new System.Drawing.Point(331, 33);
            this.txtNazivOglasa.Name = "txtNazivOglasa";
            this.txtNazivOglasa.Size = new System.Drawing.Size(457, 20);
            this.txtNazivOglasa.TabIndex = 15;
            // 
            // lblNazivOglasa
            // 
            this.lblNazivOglasa.AutoSize = true;
            this.lblNazivOglasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNazivOglasa.Location = new System.Drawing.Point(328, 17);
            this.lblNazivOglasa.Name = "lblNazivOglasa";
            this.lblNazivOglasa.Size = new System.Drawing.Size(68, 13);
            this.lblNazivOglasa.TabIndex = 54;
            this.lblNazivOglasa.Text = "Naziv oglasa";
            // 
            // frmKreiranjeOglasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.txtNazivOglasa);
            this.Controls.Add(this.lblNazivOglasa);
            this.Controls.Add(this.txtRadniObujam);
            this.Controls.Add(this.lblRadniObujam);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.pnlAtributi);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblPrijedeniKilometri);
            this.Controls.Add(this.txtPrijedeniKilometri);
            this.Controls.Add(this.lblGodinaProizvodnje);
            this.Controls.Add(this.txtGodinaPorizvodnje);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.lblSnagaMotora);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.txtSnagaMotora);
            this.Controls.Add(this.pboxSlika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKreiranjeOglasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oglas";
            this.Load += new System.EventHandler(this.frmKreiranjeOglasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxSlika;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblPrijedeniKilometri;
        private System.Windows.Forms.TextBox txtPrijedeniKilometri;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtGodinaPorizvodnje;
        private System.Windows.Forms.Label lblSnagaMotora;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.TextBox txtSnagaMotora;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Panel pnlAtributi;
        private System.Windows.Forms.ComboBox cmbLokacija;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtRadniObujam;
        private System.Windows.Forms.Label lblRadniObujam;
        private System.Windows.Forms.TextBox txtNazivOglasa;
        private System.Windows.Forms.Label lblNazivOglasa;
    }
}