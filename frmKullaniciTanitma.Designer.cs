namespace SOHBTS
{
    partial class frmKullaniciTanitma
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
            this.btnYeniKullaniciEkle = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.cbYetki = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Kodu";
            // 
            // btnYeniKullaniciEkle
            // 
            this.btnYeniKullaniciEkle.Location = new System.Drawing.Point(99, 175);
            this.btnYeniKullaniciEkle.Name = "btnYeniKullaniciEkle";
            this.btnYeniKullaniciEkle.Size = new System.Drawing.Size(200, 26);
            this.btnYeniKullaniciEkle.TabIndex = 3;
            this.btnYeniKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnYeniKullaniciEkle.Click += new System.EventHandler(this.btnYeniKullaniciEkle_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(205, 136);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(121, 22);
            this.txtsifre.TabIndex = 4;
            // 
            // cbYetki
            // 
            this.cbYetki.FormattingEnabled = true;
            this.cbYetki.Items.AddRange(new object[] {
            "Admin",
            "Normal"});
            this.cbYetki.Location = new System.Drawing.Point(205, 94);
            this.cbYetki.Name = "cbYetki";
            this.cbYetki.Size = new System.Drawing.Size(121, 24);
            this.cbYetki.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin/Normal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre";
            // 
            // txtKullaniciKodu
            // 
            this.txtKullaniciKodu.Location = new System.Drawing.Point(205, 26);
            this.txtKullaniciKodu.Name = "txtKullaniciKodu";
            this.txtKullaniciKodu.Size = new System.Drawing.Size(121, 22);
            this.txtKullaniciKodu.TabIndex = 8;
            this.txtKullaniciKodu.TextChanged += new System.EventHandler(this.txtKullaniciKodu_TextChanged);
            this.txtKullaniciKodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKullaniciKodu_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(205, 60);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 22);
            this.txtusername.TabIndex = 10;
            // 
            // frmKullaniciTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 228);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKullaniciKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYetki);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btnYeniKullaniciEkle);
            this.Controls.Add(this.label2);
            this.Name = "frmKullaniciTanitma";
            this.Text = "frmKullaniciTanitma";
            this.Load += new System.EventHandler(this.frmKullaniciTanitma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniKullaniciEkle;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.ComboBox cbYetki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullaniciKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusername;
    }
}