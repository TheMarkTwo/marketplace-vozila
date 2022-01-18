
namespace MarketplaceVozila
{
    partial class frmProfil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfil));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPodatci = new System.Windows.Forms.Panel();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblPunoIme = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pboxProfilna = new System.Windows.Forms.PictureBox();
            this.dgvPrikazOglasa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPodatci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProfilna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazOglasa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPodatci
            // 
            this.pnlPodatci.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPodatci.Controls.Add(this.lblKontakt);
            this.pnlPodatci.Controls.Add(this.lblEmail);
            this.pnlPodatci.Controls.Add(this.lblTelefon);
            this.pnlPodatci.Controls.Add(this.lblAdresa);
            this.pnlPodatci.Controls.Add(this.lblPunoIme);
            this.pnlPodatci.Controls.Add(this.lblKorisnickoIme);
            this.pnlPodatci.Controls.Add(this.pboxProfilna);
            this.pnlPodatci.Location = new System.Drawing.Point(0, 0);
            this.pnlPodatci.Name = "pnlPodatci";
            this.pnlPodatci.Size = new System.Drawing.Size(228, 488);
            this.pnlPodatci.TabIndex = 1;
            // 
            // lblKontakt
            // 
            this.lblKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontakt.Location = new System.Drawing.Point(13, 336);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(200, 20);
            this.lblKontakt.TabIndex = 6;
            this.lblKontakt.Text = "Kontakt:";
            this.lblKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 383);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(200, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefon
            // 
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(12, 360);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(200, 20);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "broj mobitela";
            this.lblTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdresa
            // 
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(12, 290);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(200, 20);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "adresa";
            this.lblAdresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPunoIme
            // 
            this.lblPunoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunoIme.Location = new System.Drawing.Point(12, 266);
            this.lblPunoIme.Name = "lblPunoIme";
            this.lblPunoIme.Size = new System.Drawing.Size(200, 20);
            this.lblPunoIme.TabIndex = 2;
            this.lblPunoIme.Text = "puno ime";
            this.lblPunoIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(12, 226);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(200, 25);
            this.lblKorisnickoIme.TabIndex = 1;
            this.lblKorisnickoIme.Text = "korisnicko ime";
            this.lblKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxProfilna
            // 
            this.pboxProfilna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxProfilna.Location = new System.Drawing.Point(12, 12);
            this.pboxProfilna.Name = "pboxProfilna";
            this.pboxProfilna.Size = new System.Drawing.Size(200, 200);
            this.pboxProfilna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxProfilna.TabIndex = 0;
            this.pboxProfilna.TabStop = false;
            this.pboxProfilna.Click += new System.EventHandler(this.pboxProfilna_Click);
            // 
            // dgvPrikazOglasa
            // 
            this.dgvPrikazOglasa.AllowUserToAddRows = false;
            this.dgvPrikazOglasa.AllowUserToDeleteRows = false;
            this.dgvPrikazOglasa.AllowUserToResizeColumns = false;
            this.dgvPrikazOglasa.AllowUserToResizeRows = false;
            this.dgvPrikazOglasa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrikazOglasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazOglasa.ColumnHeadersVisible = false;
            this.dgvPrikazOglasa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Slika,
            this.Opis,
            this.Cijena});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazOglasa.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrikazOglasa.Location = new System.Drawing.Point(228, -1);
            this.dgvPrikazOglasa.MultiSelect = false;
            this.dgvPrikazOglasa.Name = "dgvPrikazOglasa";
            this.dgvPrikazOglasa.ReadOnly = true;
            this.dgvPrikazOglasa.RowHeadersVisible = false;
            this.dgvPrikazOglasa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrikazOglasa.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.dgvPrikazOglasa.RowTemplate.Height = 152;
            this.dgvPrikazOglasa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPrikazOglasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazOglasa.Size = new System.Drawing.Size(576, 452);
            this.dgvPrikazOglasa.TabIndex = 2;
            this.dgvPrikazOglasa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikazOglasa_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            this.ID.Width = 5;
            // 
            // Slika
            // 
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.Slika.DefaultCellStyle = dataGridViewCellStyle4;
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Slika.Width = 205;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Opis.Width = 245;
            // 
            // Cijena
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Cijena.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cijena.Width = 125;
            // 
            // frmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.dgvPrikazOglasa);
            this.Controls.Add(this.pnlPodatci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.pnlPodatci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProfilna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazOglasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxProfilna;
        private System.Windows.Forms.Panel pnlPodatci;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblPunoIme;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.DataGridView dgvPrikazOglasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}