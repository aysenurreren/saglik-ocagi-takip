namespace SOHBTS
{
    partial class frmArama
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
            this.cbAramaKriteri = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAramaTerimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAramaSonuclari = new System.Windows.Forms.DataGridView();
            this.btnsec = new System.Windows.Forms.Button();
            this.btnsorgula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAramaSonuclari)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAramaKriteri
            // 
            this.cbAramaKriteri.FormattingEnabled = true;
            this.cbAramaKriteri.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "",
            "",
            "Dosya No",
            "",
            "",
            "T.C. Kimlik No"});
            this.cbAramaKriteri.Location = new System.Drawing.Point(133, 12);
            this.cbAramaKriteri.Name = "cbAramaKriteri";
            this.cbAramaKriteri.Size = new System.Drawing.Size(121, 24);
            this.cbAramaKriteri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Kriteri";
            // 
            // txtAramaTerimi
            // 
            this.txtAramaTerimi.Location = new System.Drawing.Point(133, 56);
            this.txtAramaTerimi.Name = "txtAramaTerimi";
            this.txtAramaTerimi.Size = new System.Drawing.Size(121, 22);
            this.txtAramaTerimi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama Terimi";
            // 
            // dgvAramaSonuclari
            // 
            this.dgvAramaSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAramaSonuclari.Location = new System.Drawing.Point(12, 95);
            this.dgvAramaSonuclari.Name = "dgvAramaSonuclari";
            this.dgvAramaSonuclari.RowHeadersWidth = 51;
            this.dgvAramaSonuclari.RowTemplate.Height = 24;
            this.dgvAramaSonuclari.Size = new System.Drawing.Size(431, 232);
            this.dgvAramaSonuclari.TabIndex = 4;
            // 
            // btnsec
            // 
            this.btnsec.Location = new System.Drawing.Point(282, 12);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(72, 24);
            this.btnsec.TabIndex = 5;
            this.btnsec.Text = "Seç";
            this.btnsec.UseVisualStyleBackColor = true;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // btnsorgula
            // 
            this.btnsorgula.Location = new System.Drawing.Point(282, 56);
            this.btnsorgula.Name = "btnsorgula";
            this.btnsorgula.Size = new System.Drawing.Size(72, 25);
            this.btnsorgula.TabIndex = 6;
            this.btnsorgula.Text = "Sorgula";
            this.btnsorgula.UseVisualStyleBackColor = true;
            this.btnsorgula.Click += new System.EventHandler(this.btnsorgula_Click);
            // 
            // frmArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 334);
            this.Controls.Add(this.btnsorgula);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.dgvAramaSonuclari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAramaTerimi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAramaKriteri);
            this.Name = "frmArama";
            this.Text = "frmArama";
            this.Load += new System.EventHandler(this.frmArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAramaSonuclari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAramaKriteri;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAramaTerimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAramaSonuclari;
        private System.Windows.Forms.Button btnsec;
        private System.Windows.Forms.Button btnsorgula;
    }
}