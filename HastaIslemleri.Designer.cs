namespace SOHBTS
{
    partial class HastaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.nmMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbDrKodu = new System.Windows.Forms.ComboBox();
            this.cbYapilanIslem = new System.Windows.Forms.ComboBox();
            this.cbPoliklinik = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnGit = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.cbOncekiIslemler = new System.Windows.Forms.ComboBox();
            this.dtSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvIslemler = new System.Windows.Forms.DataGridView();
            this.Poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YapilanIslem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBaskiOnizleme = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnHastaBilgileri);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtKurumAdi);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.btnGit);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.cbOncekiIslemler);
            this.panel1.Controls.Add(this.dtSevkTarihi);
            this.panel1.Controls.Add(this.txtDosyaNo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 173);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txtBirimFiyat);
            this.panel2.Controls.Add(this.nmMiktar);
            this.panel2.Controls.Add(this.txtSiraNo);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbDrKodu);
            this.panel2.Controls.Add(this.cbYapilanIslem);
            this.panel2.Controls.Add(this.cbPoliklinik);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 58);
            this.panel2.TabIndex = 17;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(655, 26);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(118, 22);
            this.txtBirimFiyat.TabIndex = 11;
            // 
            // nmMiktar
            // 
            this.nmMiktar.Location = new System.Drawing.Point(535, 28);
            this.nmMiktar.Name = "nmMiktar";
            this.nmMiktar.Size = new System.Drawing.Size(114, 22);
            this.nmMiktar.TabIndex = 9;
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(168, 26);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(116, 22);
            this.txtSiraNo.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label16.Location = new System.Drawing.Point(413, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 23);
            this.label16.TabIndex = 6;
            this.label16.Text = "Dr. Kodu";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbDrKodu
            // 
            this.cbDrKodu.FormattingEnabled = true;
            this.cbDrKodu.Location = new System.Drawing.Point(412, 26);
            this.cbDrKodu.Name = "cbDrKodu";
            this.cbDrKodu.Size = new System.Drawing.Size(117, 24);
            this.cbDrKodu.TabIndex = 7;
            // 
            // cbYapilanIslem
            // 
            this.cbYapilanIslem.FormattingEnabled = true;
            this.cbYapilanIslem.Location = new System.Drawing.Point(290, 26);
            this.cbYapilanIslem.Name = "cbYapilanIslem";
            this.cbYapilanIslem.Size = new System.Drawing.Size(116, 24);
            this.cbYapilanIslem.TabIndex = 5;
            this.cbYapilanIslem.SelectedIndexChanged += new System.EventHandler(this.cbYapilanIslem_SelectedIndexChanged);
            // 
            // cbPoliklinik
            // 
            this.cbPoliklinik.FormattingEnabled = true;
            this.cbPoliklinik.Location = new System.Drawing.Point(3, 26);
            this.cbPoliklinik.Name = "cbPoliklinik";
            this.cbPoliklinik.Size = new System.Drawing.Size(159, 24);
            this.cbPoliklinik.TabIndex = 1;
            this.cbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cbPoliklinik_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEkle.Location = new System.Drawing.Point(782, -1);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(108, 51);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label20.Location = new System.Drawing.Point(655, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 23);
            this.label20.TabIndex = 10;
            this.label20.Text = "Birim Fiyat";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label19.Location = new System.Drawing.Point(535, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 23);
            this.label19.TabIndex = 8;
            this.label19.Text = "Miktar";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label18.Location = new System.Drawing.Point(290, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 23);
            this.label18.TabIndex = 4;
            this.label18.Text = "Yapılan İşlem";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Location = new System.Drawing.Point(168, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 23);
            this.label17.TabIndex = 2;
            this.label17.Text = "SIRA NO";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Poliklinik";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.Location = new System.Drawing.Point(646, 54);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Size = new System.Drawing.Size(211, 55);
            this.btnHastaBilgileri.TabIndex = 15;
            this.btnHastaBilgileri.Text = "Hasta Bilgileri";
            this.btnHastaBilgileri.UseVisualStyleBackColor = true;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.btnHastaBilgileri_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(643, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 23);
            this.label14.TabIndex = 14;
            this.label14.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(450, 83);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(122, 22);
            this.txtKurumAdi.TabIndex = 13;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(450, 54);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(122, 22);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(450, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(122, 22);
            this.txtAd.TabIndex = 11;
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(264, 86);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(75, 23);
            this.btnGit.TabIndex = 7;
            this.btnGit.Text = "Git";
            this.btnGit.UseVisualStyleBackColor = true;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(264, 18);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // cbOncekiIslemler
            // 
            this.cbOncekiIslemler.FormattingEnabled = true;
            this.cbOncekiIslemler.Location = new System.Drawing.Point(146, 86);
            this.cbOncekiIslemler.Name = "cbOncekiIslemler";
            this.cbOncekiIslemler.Size = new System.Drawing.Size(100, 24);
            this.cbOncekiIslemler.TabIndex = 5;
            this.cbOncekiIslemler.SelectedIndexChanged += new System.EventHandler(this.cbOncekiIslemler_SelectedIndexChanged);
            // 
            // dtSevkTarihi
            // 
            this.dtSevkTarihi.Location = new System.Drawing.Point(146, 54);
            this.dtSevkTarihi.Name = "dtSevkTarihi";
            this.dtSevkTarihi.Size = new System.Drawing.Size(193, 22);
            this.dtSevkTarihi.TabIndex = 4;
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Location = new System.Drawing.Point(146, 18);
            this.txtDosyaNo.MaxLength = 10;
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(100, 22);
            this.txtDosyaNo.TabIndex = 3;
            this.txtDosyaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDosyaNo_KeyPress);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(357, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "Kurum Adı";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(357, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "Soyadı";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(357, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "Hasta Adı";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(49, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Önceki İşlemler";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(49, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sevk Tarihi";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(49, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dosya No";
            // 
            // dgvIslemler
            // 
            this.dgvIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poliklinik,
            this.sirano,
            this.Saat,
            this.YapilanIslem,
            this.DrKodu,
            this.Miktar,
            this.BirimFiyat});
            this.dgvIslemler.Location = new System.Drawing.Point(0, 171);
            this.dgvIslemler.Name = "dgvIslemler";
            this.dgvIslemler.ReadOnly = true;
            this.dgvIslemler.RowHeadersWidth = 51;
            this.dgvIslemler.RowTemplate.Height = 24;
            this.dgvIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIslemler.Size = new System.Drawing.Size(899, 380);
            this.dgvIslemler.TabIndex = 1;
            // 
            // Poliklinik
            // 
            this.Poliklinik.HeaderText = "Poliklinik";
            this.Poliklinik.MinimumWidth = 6;
            this.Poliklinik.Name = "Poliklinik";
            this.Poliklinik.ReadOnly = true;
            this.Poliklinik.Width = 125;
            // 
            // sirano
            // 
            this.sirano.HeaderText = "SIRA NO";
            this.sirano.MinimumWidth = 6;
            this.sirano.Name = "sirano";
            this.sirano.ReadOnly = true;
            this.sirano.Width = 125;
            // 
            // Saat
            // 
            this.Saat.HeaderText = "SAAT";
            this.Saat.MinimumWidth = 6;
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            this.Saat.Width = 125;
            // 
            // YapilanIslem
            // 
            this.YapilanIslem.HeaderText = "YAPILAN İŞLEM";
            this.YapilanIslem.MinimumWidth = 6;
            this.YapilanIslem.Name = "YapilanIslem";
            this.YapilanIslem.ReadOnly = true;
            this.YapilanIslem.Width = 125;
            // 
            // DrKodu
            // 
            this.DrKodu.HeaderText = "DR. KODU";
            this.DrKodu.MinimumWidth = 6;
            this.DrKodu.Name = "DrKodu";
            this.DrKodu.ReadOnly = true;
            this.DrKodu.Width = 125;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "MİKTAR";
            this.Miktar.MinimumWidth = 6;
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            this.Miktar.Width = 125;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "BİRİM FİYAT";
            this.BirimFiyat.MinimumWidth = 6;
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.ReadOnly = true;
            this.BirimFiyat.Width = 125;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblToplamTutar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToplamTutar.Location = new System.Drawing.Point(646, 554);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(253, 22);
            this.lblToplamTutar.TabIndex = 2;
            this.lblToplamTutar.Text = "TOPLAM TUTAR:   0YTL";
            this.lblToplamTutar.Click += new System.EventHandler(this.lblToplamTutar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.lblBilgi);
            this.panel3.Controls.Add(this.btnCikis);
            this.panel3.Controls.Add(this.btnBaskiOnizleme);
            this.panel3.Controls.Add(this.btnYazdir);
            this.panel3.Controls.Add(this.btnTaburcu);
            this.panel3.Controls.Add(this.btnSecSil);
            this.panel3.Controls.Add(this.btnYeni);
            this.panel3.Location = new System.Drawing.Point(0, 579);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 64);
            this.panel3.TabIndex = 3;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(773, 22);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(0, 16);
            this.lblBilgi.TabIndex = 6;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCikis.Location = new System.Drawing.Point(782, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(108, 55);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBaskiOnizleme
            // 
            this.btnBaskiOnizleme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBaskiOnizleme.Location = new System.Drawing.Point(369, 3);
            this.btnBaskiOnizleme.Name = "btnBaskiOnizleme";
            this.btnBaskiOnizleme.Size = new System.Drawing.Size(87, 55);
            this.btnBaskiOnizleme.TabIndex = 4;
            this.btnBaskiOnizleme.Text = "Baskı Önizleme";
            this.btnBaskiOnizleme.UseVisualStyleBackColor = false;
            this.btnBaskiOnizleme.Click += new System.EventHandler(this.btnBaskiOnizleme_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnYazdir.Location = new System.Drawing.Point(276, 3);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(87, 55);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTaburcu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTaburcu.Location = new System.Drawing.Point(185, 3);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(85, 55);
            this.btnTaburcu.TabIndex = 2;
            this.btnTaburcu.Text = "Taburcu";
            this.btnTaburcu.UseVisualStyleBackColor = false;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSecSil.ForeColor = System.Drawing.Color.Red;
            this.btnSecSil.Location = new System.Drawing.Point(91, 3);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(88, 55);
            this.btnSecSil.TabIndex = 1;
            this.btnSecSil.Text = "Seç-Sil";
            this.btnSecSil.UseVisualStyleBackColor = false;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnYeni.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYeni.Location = new System.Drawing.Point(6, 3);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(79, 55);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // HastaIslemleri
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(901, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.dgvIslemler);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(919, 692);
            this.Name = "HastaIslemleri";
            this.Load += new System.EventHandler(this.HastaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.ComboBox cbOncekiIslemler;
        private System.Windows.Forms.DateTimePicker dtSevkTarihi;
        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDrKodu;
        private System.Windows.Forms.ComboBox cbYapilanIslem;
        private System.Windows.Forms.ComboBox cbPoliklinik;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.NumericUpDown nmMiktar;
        private System.Windows.Forms.DataGridView dgvIslemler;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBaskiOnizleme;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn YapilanIslem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}