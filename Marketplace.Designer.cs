﻿
namespace MarketplaceVozila
{
    partial class frmMarketplace
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarketplace));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrikazOglasa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.txtSnagaMotoraOd = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblSnagaMotora = new System.Windows.Forms.Label();
            this.pnlAtributi = new System.Windows.Forms.Panel();
            this.btn_Pretraga = new System.Windows.Forms.Button();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.txtSnagaMotoraDo = new System.Windows.Forms.TextBox();
            this.lblDo1 = new System.Windows.Forms.Label();
            this.txtGodinaPorizvodnjeDo = new System.Windows.Forms.TextBox();
            this.lblOd1 = new System.Windows.Forms.Label();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.txtGodinaPorizvodnjeOd = new System.Windows.Forms.TextBox();
            this.lblDo2 = new System.Windows.Forms.Label();
            this.kilometri = new System.Windows.Forms.TextBox();
            this.lblOd2 = new System.Windows.Forms.Label();
            this.lblPrijedeniKilometri = new System.Windows.Forms.Label();
            this.txtPrijedeniKilometriOd = new System.Windows.Forms.TextBox();
            this.lblDo3 = new System.Windows.Forms.Label();
            this.txtCijenaDo = new System.Windows.Forms.TextBox();
            this.lblOd3 = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijenaiOd = new System.Windows.Forms.TextBox();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.pnlOpcije = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.btnObrisiOglas = new System.Windows.Forms.Button();
            this.btnUrediOglas = new System.Windows.Forms.Button();
            this.btnKreirajOglas = new System.Windows.Forms.Button();
            this.btnOcistiPretragu = new System.Windows.Forms.Button();
            this.pnlBG = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazOglasa)).BeginInit();
            this.pnlOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrikazOglasa
            // 
            this.dgvPrikazOglasa.AllowUserToAddRows = false;
            this.dgvPrikazOglasa.AllowUserToDeleteRows = false;
            this.dgvPrikazOglasa.AllowUserToResizeColumns = false;
            this.dgvPrikazOglasa.AllowUserToResizeRows = false;
            this.dgvPrikazOglasa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazOglasa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikazOglasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazOglasa.ColumnHeadersVisible = false;
            this.dgvPrikazOglasa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Slika,
            this.Opis,
            this.Cijena});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazOglasa.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrikazOglasa.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPrikazOglasa.Location = new System.Drawing.Point(244, -2);
            this.dgvPrikazOglasa.MultiSelect = false;
            this.dgvPrikazOglasa.Name = "dgvPrikazOglasa";
            this.dgvPrikazOglasa.ReadOnly = true;
            this.dgvPrikazOglasa.RowHeadersVisible = false;
            this.dgvPrikazOglasa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrikazOglasa.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.dgvPrikazOglasa.RowTemplate.Height = 165;
            this.dgvPrikazOglasa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPrikazOglasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazOglasa.Size = new System.Drawing.Size(822, 720);
            this.dgvPrikazOglasa.TabIndex = 0;
            this.dgvPrikazOglasa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikazOglasa_CellContentClick);
            this.dgvPrikazOglasa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikazOglasa_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            // 
            // Slika
            // 
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.Slika.DefaultCellStyle = dataGridViewCellStyle2;
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Slika.Width = 225;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Opis.Width = 375;
            // 
            // Cijena
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Cijena.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cijena.Width = 200;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategorija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(21, 30);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(195, 24);
            this.cmbKategorija.TabIndex = 2;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(21, 76);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(195, 24);
            this.cmbMarka.TabIndex = 4;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // txtSnagaMotoraOd
            // 
            this.txtSnagaMotoraOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSnagaMotoraOd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSnagaMotoraOd.Location = new System.Drawing.Point(50, 175);
            this.txtSnagaMotoraOd.Name = "txtSnagaMotoraOd";
            this.txtSnagaMotoraOd.Size = new System.Drawing.Size(65, 22);
            this.txtSnagaMotoraOd.TabIndex = 8;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKategorija.Location = new System.Drawing.Point(18, 11);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(69, 16);
            this.lblKategorija.TabIndex = 1;
            this.lblKategorija.Text = "Kategorija";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMarka.Location = new System.Drawing.Point(18, 57);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(46, 16);
            this.lblMarka.TabIndex = 3;
            this.lblMarka.Text = "Marka";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModel.Location = new System.Drawing.Point(18, 103);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 16);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(21, 122);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(195, 24);
            this.cmbModel.TabIndex = 6;
            // 
            // lblSnagaMotora
            // 
            this.lblSnagaMotora.AutoSize = true;
            this.lblSnagaMotora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnagaMotora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSnagaMotora.Location = new System.Drawing.Point(18, 155);
            this.lblSnagaMotora.Name = "lblSnagaMotora";
            this.lblSnagaMotora.Size = new System.Drawing.Size(124, 16);
            this.lblSnagaMotora.TabIndex = 7;
            this.lblSnagaMotora.Text = "Snaga Motora (kW)";
            // 
            // pnlAtributi
            // 
            this.pnlAtributi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAtributi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlAtributi.Location = new System.Drawing.Point(21, 410);
            this.pnlAtributi.Name = "pnlAtributi";
            this.pnlAtributi.Size = new System.Drawing.Size(194, 164);
            this.pnlAtributi.TabIndex = 9;
            // 
            // btn_Pretraga
            // 
            this.btn_Pretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pretraga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pretraga.Location = new System.Drawing.Point(21, 665);
            this.btn_Pretraga.Name = "btn_Pretraga";
            this.btn_Pretraga.Size = new System.Drawing.Size(195, 40);
            this.btn_Pretraga.TabIndex = 10;
            this.btn_Pretraga.Text = "Pretrazi";
            this.btn_Pretraga.UseVisualStyleBackColor = true;
            this.btn_Pretraga.Click += new System.EventHandler(this.btn_Pretraga_Click);
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOd.Location = new System.Drawing.Point(19, 178);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(29, 16);
            this.lblOd.TabIndex = 11;
            this.lblOd.Text = "Od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDo.Location = new System.Drawing.Point(120, 178);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(29, 16);
            this.lblDo.TabIndex = 13;
            this.lblDo.Text = "Do:";
            // 
            // txtSnagaMotoraDo
            // 
            this.txtSnagaMotoraDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSnagaMotoraDo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSnagaMotoraDo.Location = new System.Drawing.Point(150, 175);
            this.txtSnagaMotoraDo.Name = "txtSnagaMotoraDo";
            this.txtSnagaMotoraDo.Size = new System.Drawing.Size(65, 22);
            this.txtSnagaMotoraDo.TabIndex = 12;
            // 
            // lblDo1
            // 
            this.lblDo1.AutoSize = true;
            this.lblDo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDo1.Location = new System.Drawing.Point(120, 229);
            this.lblDo1.Name = "lblDo1";
            this.lblDo1.Size = new System.Drawing.Size(29, 16);
            this.lblDo1.TabIndex = 18;
            this.lblDo1.Text = "Do:";
            // 
            // txtGodinaPorizvodnjeDo
            // 
            this.txtGodinaPorizvodnjeDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodinaPorizvodnjeDo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGodinaPorizvodnjeDo.Location = new System.Drawing.Point(150, 226);
            this.txtGodinaPorizvodnjeDo.Name = "txtGodinaPorizvodnjeDo";
            this.txtGodinaPorizvodnjeDo.Size = new System.Drawing.Size(65, 22);
            this.txtGodinaPorizvodnjeDo.TabIndex = 17;
            // 
            // lblOd1
            // 
            this.lblOd1.AutoSize = true;
            this.lblOd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOd1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOd1.Location = new System.Drawing.Point(19, 229);
            this.lblOd1.Name = "lblOd1";
            this.lblOd1.Size = new System.Drawing.Size(29, 16);
            this.lblOd1.TabIndex = 16;
            this.lblOd1.Text = "Od:";
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodinaProizvodnje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(17, 207);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(125, 16);
            this.lblGodinaProizvodnje.TabIndex = 14;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje";
            // 
            // txtGodinaPorizvodnjeOd
            // 
            this.txtGodinaPorizvodnjeOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodinaPorizvodnjeOd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGodinaPorizvodnjeOd.Location = new System.Drawing.Point(50, 226);
            this.txtGodinaPorizvodnjeOd.Name = "txtGodinaPorizvodnjeOd";
            this.txtGodinaPorizvodnjeOd.Size = new System.Drawing.Size(65, 22);
            this.txtGodinaPorizvodnjeOd.TabIndex = 15;
            // 
            // lblDo2
            // 
            this.lblDo2.AutoSize = true;
            this.lblDo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDo2.Location = new System.Drawing.Point(120, 281);
            this.lblDo2.Name = "lblDo2";
            this.lblDo2.Size = new System.Drawing.Size(29, 16);
            this.lblDo2.TabIndex = 23;
            this.lblDo2.Text = "Do:";
            // 
            // kilometri
            // 
            this.kilometri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kilometri.Location = new System.Drawing.Point(150, 278);
            this.kilometri.Name = "kilometri";
            this.kilometri.Size = new System.Drawing.Size(65, 22);
            this.kilometri.TabIndex = 22;
            // 
            // lblOd2
            // 
            this.lblOd2.AutoSize = true;
            this.lblOd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOd2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOd2.Location = new System.Drawing.Point(19, 281);
            this.lblOd2.Name = "lblOd2";
            this.lblOd2.Size = new System.Drawing.Size(29, 16);
            this.lblOd2.TabIndex = 21;
            this.lblOd2.Text = "Od:";
            // 
            // lblPrijedeniKilometri
            // 
            this.lblPrijedeniKilometri.AutoSize = true;
            this.lblPrijedeniKilometri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijedeniKilometri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrijedeniKilometri.Location = new System.Drawing.Point(17, 259);
            this.lblPrijedeniKilometri.Name = "lblPrijedeniKilometri";
            this.lblPrijedeniKilometri.Size = new System.Drawing.Size(118, 16);
            this.lblPrijedeniKilometri.TabIndex = 19;
            this.lblPrijedeniKilometri.Text = "Prijedeni Kilometri:";
            // 
            // txtPrijedeniKilometriOd
            // 
            this.txtPrijedeniKilometriOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrijedeniKilometriOd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrijedeniKilometriOd.Location = new System.Drawing.Point(50, 278);
            this.txtPrijedeniKilometriOd.Name = "txtPrijedeniKilometriOd";
            this.txtPrijedeniKilometriOd.Size = new System.Drawing.Size(65, 22);
            this.txtPrijedeniKilometriOd.TabIndex = 20;
            // 
            // lblDo3
            // 
            this.lblDo3.AutoSize = true;
            this.lblDo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDo3.Location = new System.Drawing.Point(120, 332);
            this.lblDo3.Name = "lblDo3";
            this.lblDo3.Size = new System.Drawing.Size(29, 16);
            this.lblDo3.TabIndex = 28;
            this.lblDo3.Text = "Do:";
            // 
            // txtCijenaDo
            // 
            this.txtCijenaDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijenaDo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCijenaDo.Location = new System.Drawing.Point(150, 329);
            this.txtCijenaDo.Name = "txtCijenaDo";
            this.txtCijenaDo.Size = new System.Drawing.Size(65, 22);
            this.txtCijenaDo.TabIndex = 27;
            // 
            // lblOd3
            // 
            this.lblOd3.AutoSize = true;
            this.lblOd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOd3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOd3.Location = new System.Drawing.Point(19, 332);
            this.lblOd3.Name = "lblOd3";
            this.lblOd3.Size = new System.Drawing.Size(29, 16);
            this.lblOd3.TabIndex = 26;
            this.lblOd3.Text = "Od:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCijena.Location = new System.Drawing.Point(17, 310);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(49, 16);
            this.lblCijena.TabIndex = 24;
            this.lblCijena.Text = "Cijena:";
            // 
            // txtCijenaiOd
            // 
            this.txtCijenaiOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijenaiOd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCijenaiOd.Location = new System.Drawing.Point(50, 329);
            this.txtCijenaiOd.Name = "txtCijenaiOd";
            this.txtCijenaiOd.Size = new System.Drawing.Size(65, 22);
            this.txtCijenaiOd.TabIndex = 25;
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLokacija.Location = new System.Drawing.Point(18, 360);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(62, 16);
            this.lblLokacija.TabIndex = 29;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLokacija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(21, 379);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(195, 24);
            this.cmbLokacija.TabIndex = 30;
            // 
            // pnlOpcije
            // 
            this.pnlOpcije.BackColor = System.Drawing.Color.White;
            this.pnlOpcije.Controls.Add(this.btnOdjava);
            this.pnlOpcije.Controls.Add(this.lblKorisnickoIme);
            this.pnlOpcije.Controls.Add(this.btnObrisiOglas);
            this.pnlOpcije.Controls.Add(this.btnUrediOglas);
            this.pnlOpcije.Controls.Add(this.btnKreirajOglas);
            this.pnlOpcije.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOpcije.Location = new System.Drawing.Point(1044, 0);
            this.pnlOpcije.Name = "pnlOpcije";
            this.pnlOpcije.Size = new System.Drawing.Size(245, 717);
            this.pnlOpcije.TabIndex = 31;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(180, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(54, 30);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Milliard Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(83, 12);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(91, 30);
            this.lblKorisnickoIme.TabIndex = 3;
            this.lblKorisnickoIme.Text = "kime";
            this.lblKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKorisnickoIme.UseMnemonic = false;
            this.lblKorisnickoIme.Click += new System.EventHandler(this.lblKorisnickoIme_Click);
            // 
            // btnObrisiOglas
            // 
            this.btnObrisiOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiOglas.Location = new System.Drawing.Point(28, 670);
            this.btnObrisiOglas.Name = "btnObrisiOglas";
            this.btnObrisiOglas.Size = new System.Drawing.Size(195, 31);
            this.btnObrisiOglas.TabIndex = 2;
            this.btnObrisiOglas.Text = "Obrisi oglas";
            this.btnObrisiOglas.UseVisualStyleBackColor = true;
            // 
            // btnUrediOglas
            // 
            this.btnUrediOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediOglas.Location = new System.Drawing.Point(28, 633);
            this.btnUrediOglas.Name = "btnUrediOglas";
            this.btnUrediOglas.Size = new System.Drawing.Size(195, 31);
            this.btnUrediOglas.TabIndex = 1;
            this.btnUrediOglas.Text = "Uredi oglas";
            this.btnUrediOglas.UseVisualStyleBackColor = true;
            // 
            // btnKreirajOglas
            // 
            this.btnKreirajOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajOglas.Location = new System.Drawing.Point(28, 596);
            this.btnKreirajOglas.Name = "btnKreirajOglas";
            this.btnKreirajOglas.Size = new System.Drawing.Size(195, 31);
            this.btnKreirajOglas.TabIndex = 0;
            this.btnKreirajOglas.Text = "Kreiraj oglas";
            this.btnKreirajOglas.UseVisualStyleBackColor = true;
            this.btnKreirajOglas.Click += new System.EventHandler(this.btnKreirajOglas_Click);
            // 
            // btnOcistiPretragu
            // 
            this.btnOcistiPretragu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcistiPretragu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOcistiPretragu.Location = new System.Drawing.Point(21, 619);
            this.btnOcistiPretragu.Name = "btnOcistiPretragu";
            this.btnOcistiPretragu.Size = new System.Drawing.Size(195, 40);
            this.btnOcistiPretragu.TabIndex = 32;
            this.btnOcistiPretragu.Text = "Ocisti pretragu";
            this.btnOcistiPretragu.UseVisualStyleBackColor = true;
            this.btnOcistiPretragu.Click += new System.EventHandler(this.btnOcistiPretragu_Click);
            // 
            // pnlBG
            // 
            this.pnlBG.Location = new System.Drawing.Point(235, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(10, 717);
            this.pnlBG.TabIndex = 33;
            // 
            // frmMarketplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 717);
            this.Controls.Add(this.pnlBG);
            this.Controls.Add(this.btnOcistiPretragu);
            this.Controls.Add(this.pnlOpcije);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.lblDo3);
            this.Controls.Add(this.txtCijenaDo);
            this.Controls.Add(this.lblOd3);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtCijenaiOd);
            this.Controls.Add(this.lblDo2);
            this.Controls.Add(this.kilometri);
            this.Controls.Add(this.lblOd2);
            this.Controls.Add(this.lblPrijedeniKilometri);
            this.Controls.Add(this.txtPrijedeniKilometriOd);
            this.Controls.Add(this.lblDo1);
            this.Controls.Add(this.txtGodinaPorizvodnjeDo);
            this.Controls.Add(this.lblOd1);
            this.Controls.Add(this.lblGodinaProizvodnje);
            this.Controls.Add(this.txtGodinaPorizvodnjeOd);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.txtSnagaMotoraDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.btn_Pretraga);
            this.Controls.Add(this.pnlAtributi);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.lblSnagaMotora);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.txtSnagaMotoraOd);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.dgvPrikazOglasa);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMarketplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marketplace Vozila";
            this.Load += new System.EventHandler(this.frmMarketplace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazOglasa)).EndInit();
            this.pnlOpcije.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazOglasa;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtSnagaMotoraOd;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblSnagaMotora;
        private System.Windows.Forms.Panel pnlAtributi;
        private System.Windows.Forms.Button btn_Pretraga;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.TextBox txtSnagaMotoraDo;
        private System.Windows.Forms.Label lblDo1;
        private System.Windows.Forms.TextBox txtGodinaPorizvodnjeDo;
        private System.Windows.Forms.Label lblOd1;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtGodinaPorizvodnjeOd;
        private System.Windows.Forms.Label lblDo2;
        private System.Windows.Forms.TextBox kilometri;
        private System.Windows.Forms.Label lblOd2;
        private System.Windows.Forms.Label lblPrijedeniKilometri;
        private System.Windows.Forms.TextBox txtPrijedeniKilometriOd;
        private System.Windows.Forms.Label lblDo3;
        private System.Windows.Forms.TextBox txtCijenaDo;
        private System.Windows.Forms.Label lblOd3;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijenaiOd;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.ComboBox cmbLokacija;
        private System.Windows.Forms.Panel pnlOpcije;
        private System.Windows.Forms.Button btnKreirajOglas;
        private System.Windows.Forms.Button btnUrediOglas;
        private System.Windows.Forms.Button btnObrisiOglas;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnOcistiPretragu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Panel pnlBG;
    }
}
