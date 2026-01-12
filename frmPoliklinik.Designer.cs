namespace SOHBTS
{
    partial class frmPoliklinik
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbPoliklinikAd = new System.Windows.Forms.ComboBox();
            this.chkGecerli = new System.Windows.Forms.CheckBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poliklinik Adı";
            // 
            // cbPoliklinikAd
            // 
            this.cbPoliklinikAd.FormattingEnabled = true;
            this.cbPoliklinikAd.Location = new System.Drawing.Point(157, 35);
            this.cbPoliklinikAd.Name = "cbPoliklinikAd";
            this.cbPoliklinikAd.Size = new System.Drawing.Size(121, 24);
            this.cbPoliklinikAd.TabIndex = 2;
            this.cbPoliklinikAd.SelectedIndexChanged += new System.EventHandler(this.cbPoliklinikAd_SelectedIndexChanged);
            this.cbPoliklinikAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPoliklinikAd_KeyPress);
            // 
            // chkGecerli
            // 
            this.chkGecerli.AutoSize = true;
            this.chkGecerli.Location = new System.Drawing.Point(157, 76);
            this.chkGecerli.Name = "chkGecerli";
            this.chkGecerli.Size = new System.Drawing.Size(129, 20);
            this.chkGecerli.TabIndex = 3;
            this.chkGecerli.Text = "Geçerli/Geçersiz";
            this.chkGecerli.UseVisualStyleBackColor = true;
            this.chkGecerli.CheckedChanged += new System.EventHandler(this.chkGecerli_CheckedChanged);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 125);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(105, 125);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(203, 125);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 6;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(308, 125);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(75, 23);
            this.btncikis.TabIndex = 7;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // frmPoliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 170);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.chkGecerli);
            this.Controls.Add(this.cbPoliklinikAd);
            this.Controls.Add(this.label2);
            this.Name = "frmPoliklinik";
            this.Text = "frmPoliklinik";
            this.Load += new System.EventHandler(this.frmPoliklinik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPoliklinikAd;
        private System.Windows.Forms.CheckBox chkGecerli;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btncikis;
    }
}