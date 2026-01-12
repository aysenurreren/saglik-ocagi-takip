using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHBTS
{
    public partial class frmPoliklinik : Form
    {
        
        public frmPoliklinik()
        {
            InitializeComponent();
        }

        private void cbPoliklinikAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPoliklinikAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
                {
                    baglanti.Open();
                    string sorgu = "SELECT durum FROM Poliklinik WHERE poliklinikadi = @p1";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", cbPoliklinikAd.Text.Trim());
                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        chkGecerli.Checked = oku["durum"].ToString().ToLower() == "true";
                    }
                    else
                    {
                        if (MessageBox.Show("Kayıt bulunamadı, yeni kayıt açayım mı?", "SOHATS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            chkGecerli.Focus();
                        }
                    }
                }
                e.Handled = true;
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(cbPoliklinikAd.Text))
            {
                MessageBox.Show("Lütfen bir poliklinik adı giriniz!");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();

                  
                    string sorgu = @"IF EXISTS (SELECT 1 FROM Poliklinik WHERE poliklinikadi = @p1) 
                             UPDATE Poliklinik SET durum = @p2 WHERE poliklinikadi = @p1 
                             ELSE INSERT INTO Poliklinik (poliklinikadi, durum) VALUES (@p1, @p2)";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1", cbPoliklinikAd.Text.Trim());

                    komut.Parameters.AddWithValue("@p2", chkGecerli.Checked.ToString());

                    komut.ExecuteNonQuery();
                    MessageBox.Show("İşlem başarıyla kaydedildi!");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Kaydetme hatası: " + hata.Message);
                }
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM Poliklinik WHERE poliklinikadi = @p1";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", cbPoliklinikAd.Text);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Poliklinik başarıyla silindi. [cite: 172]");
                    cbPoliklinikAd.Text = "";
                    chkGecerli.Checked = false;
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Silme hatası: " + hata.Message);
                }
            }
        }

        private void frmPoliklinik_Load(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT poliklinikadi FROM Poliklinik", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();

                    cbPoliklinikAd.Items.Clear();
                    while (oku.Read())
                    {
                        cbPoliklinikAd.Items.Add(oku["poliklinikadi"].ToString());
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Poliklinik listesi yüklenirken hata: " + hata.Message);
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPoliklinikAd.Text)) return;

            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                    
                    string sorgu = "UPDATE Poliklinik SET durum = @p2 WHERE poliklinikadi = @p1";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", cbPoliklinikAd.Text);
                    komut.Parameters.AddWithValue("@p2", chkGecerli.Checked.ToString());

                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                        MessageBox.Show("Poliklinik bilgileri başarıyla güncellendi.");
                    else
                        MessageBox.Show("Güncellenecek kayıt bulunamadı.");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Güncelleme hatası: " + hata.Message);
                }
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkGecerli_CheckedChanged(object sender, EventArgs e)
        {
            chkGecerli.Text = chkGecerli.Checked ? "Geçerli" : "Geçersiz";
        }
    }
}

