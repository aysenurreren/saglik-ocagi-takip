namespace SOHBTS
{
    partial class frmDoktorTanitma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrKodu = new System.Windows.Forms.TextBox();
            this.txtDrAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPoliklinik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Kodu";
            // 
            // txtDrKodu
            // 
            this.txtDrKodu.Location = new System.Drawing.Point(209, 57);
            this.txtDrKodu.Name = "txtDrKodu";
            this.txtDrKodu.Size = new System.Drawing.Size(100, 22);
            this.txtDrKodu.TabIndex = 1;
            this.txtDrKodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrKodu_KeyDown);
            // 
            // txtDrAdSoyad
            // 
            this.txtDrAdSoyad.Location = new System.Drawing.Point(209, 104);
            this.txtDrAdSoyad.Name = "txtDrAdSoyad";
            this.txtDrAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtDrAdSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dr. Ad-Soyad";
            // 
            // cbPoliklinik
            // 
            this.cbPoliklinik.FormattingEnabled = true;
            this.cbPoliklinik.Items.AddRange(new object[] {
            "KBB",
            "Dahiliye",
            "Göz",
            "Genel Cerrahi",
            "Kardiyoloji",
            "Nöroloji",
            "Ortopedi",
            "Cildiye",
            "Psikiyatri",
            "Üroloji"});
            this.cbPoliklinik.Location = new System.Drawing.Point(209, 150);
            this.cbPoliklinik.Name = "cbPoliklinik";
            this.cbPoliklinik.Size = new System.Drawing.Size(100, 24);
            this.cbPoliklinik.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poliklinik";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(12, 212);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(137, 212);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(283, 212);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 23);
            this.btntemizle.TabIndex = 8;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // frmDoktorTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 285);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPoliklinik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDrAdSoyad);
            this.Controls.Add(this.txtDrKodu);
            this.Controls.Add(this.label1);
            this.Name = "frmDoktorTanitma";
            this.Text = "frmDoktorTanitma";
            this.Load += new System.EventHandler(this.frmDoktorTanitma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDrKodu;
        private System.Windows.Forms.TextBox txtDrAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPoliklinik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btntemizle;
    }
}