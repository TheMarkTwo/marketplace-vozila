
namespace MarketplaceVozila
{
    partial class frmDetaljiOglasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiOglasa));
            this.pboxSlika = new System.Windows.Forms.PictureBox();
            this.lblKilometraza = new System.Windows.Forms.Label();
            this.lblAutomobil = new System.Windows.Forms.Label();
            this.lblNazivOglasa = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblProdavac = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxSlika
            // 
            this.pboxSlika.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pboxSlika.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pboxSlika.Location = new System.Drawing.Point(12, 12);
            this.pboxSlika.Name = "pboxSlika";
            this.pboxSlika.Size = new System.Drawing.Size(300, 222);
            this.pboxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSlika.TabIndex = 2;
            this.pboxSlika.TabStop = false;
            this.pboxSlika.Click += new System.EventHandler(this.pboxSlika_Click);
            // 
            // lblKilometraza
            // 
            this.lblKilometraza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometraza.Location = new System.Drawing.Point(12, 350);
            this.lblKilometraza.Name = "lblKilometraza";
            this.lblKilometraza.Size = new System.Drawing.Size(300, 20);
            this.lblKilometraza.TabIndex = 9;
            this.lblKilometraza.Text = "kilometraza";
            this.lblKilometraza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutomobil
            // 
            this.lblAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomobil.Location = new System.Drawing.Point(12, 306);
            this.lblAutomobil.Name = "lblAutomobil";
            this.lblAutomobil.Size = new System.Drawing.Size(300, 20);
            this.lblAutomobil.TabIndex = 8;
            this.lblAutomobil.Text = "marka model (obujam), tip";
            this.lblAutomobil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNazivOglasa
            // 
            this.lblNazivOglasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivOglasa.Location = new System.Drawing.Point(325, 12);
            this.lblNazivOglasa.Name = "lblNazivOglasa";
            this.lblNazivOglasa.Size = new System.Drawing.Size(463, 39);
            this.lblNazivOglasa.TabIndex = 7;
            this.lblNazivOglasa.Text = "naziv oglasa";
            this.lblNazivOglasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCijena
            // 
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.Location = new System.Drawing.Point(12, 246);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(300, 25);
            this.lblCijena.TabIndex = 13;
            this.lblCijena.Text = "cijena";
            this.lblCijena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGodina
            // 
            this.lblGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodina.Location = new System.Drawing.Point(12, 328);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(300, 20);
            this.lblGodina.TabIndex = 14;
            this.lblGodina.Text = "godina";
            this.lblGodina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdavac
            // 
            this.lblProdavac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdavac.Location = new System.Drawing.Point(12, 273);
            this.lblProdavac.Name = "lblProdavac";
            this.lblProdavac.Size = new System.Drawing.Size(300, 25);
            this.lblProdavac.TabIndex = 15;
            this.lblProdavac.Text = "prodavac";
            this.lblProdavac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProdavac.Click += new System.EventHandler(this.lblProdavac_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(326, 49);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Padding = new System.Windows.Forms.Padding(20);
            this.lblOpis.Size = new System.Drawing.Size(462, 476);
            this.lblOpis.TabIndex = 16;
            this.lblOpis.Text = "opis";
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(340, 71);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ReadOnly = true;
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(446, 434);
            this.txtOpis.TabIndex = 17;
            this.txtOpis.TabStop = false;
            this.txtOpis.Text = "opis";
            // 
            // frmDetaljiOglasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblProdavac);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblKilometraza);
            this.Controls.Add(this.lblAutomobil);
            this.Controls.Add(this.lblNazivOglasa);
            this.Controls.Add(this.pboxSlika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDetaljiOglasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oglas ###";
            this.Load += new System.EventHandler(this.frmDetaljiOglasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxSlika;
        private System.Windows.Forms.Label lblKilometraza;
        private System.Windows.Forms.Label lblAutomobil;
        private System.Windows.Forms.Label lblNazivOglasa;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblProdavac;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
    }
}