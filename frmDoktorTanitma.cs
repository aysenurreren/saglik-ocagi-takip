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
    public partial class frmDoktorTanitma : Form
    {
        
        public frmDoktorTanitma()
        {
            InitializeComponent();
        }

        private void txtDrKodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
                {
                    try
                    {
                        baglanti.Open();
                        string sorgu = "SELECT * FROM Doktorlar WHERE drkodu = @p1";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@p1", txtDrKodu.Text);
                        SqlDataReader oku = komut.ExecuteReader();

                        if (oku.Read())
                        {
                            
                            txtDrAdSoyad.Text = oku["adsoyad"].ToString();
                            cbPoliklinik.Text = oku["poliklinik"].ToString();
                        }
                        else
                        {
                            
                            DialogResult dr = MessageBox.Show("Bu kodla kayıtlı doktor bulunamadı. Yeni kayıt açayım mı?", "Doktor Tanıtma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dr == DialogResult.Yes)
                            {
                                txtDrAdSoyad.Focus(); 
                            }
                            else
                            {
                                txtDrKodu.Clear();
                            }
                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata oluştu: " + hata.Message);
                    }
                }
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();

                   
                    string sorgu = @"IF EXISTS (SELECT 1 FROM Doktorlar WHERE drkodu = @p1) 
                             UPDATE Doktorlar SET adsoyad = @p2, poliklinikadi = @p3 WHERE drkodu = @p1 
                             ELSE INSERT INTO Doktorlar (drkodu, adsoyad, poliklinikadi) VALUES (@p1, @p2, @p3)";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1", txtDrKodu.Text.Trim());
                    komut.Parameters.AddWithValue("@p2", txtDrAdSoyad.Text.Trim());
                    komut.Parameters.AddWithValue("@p3", cbPoliklinik.Text);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Doktor bilgileri başarıyla kaydedildi!");
                }
                catch (Exception hata)
                {
                   
                    MessageBox.Show("Kayıt hatası: " + hata.Message);
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDrKodu.Text)) return;

            DialogResult onay = MessageBox.Show("Bu doktoru silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
                {
                    try
                    {
                        baglanti.Open();
                        string sorgu = "DELETE FROM Doktorlar WHERE drkodu = @p1";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@p1", txtDrKodu.Text);

                        komut.ExecuteNonQuery();
                        MessageBox.Show("Doktor kaydı başarıyla silindi.");
                        btnsil.PerformClick(); 
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Silme hatası: " + hata.Message);
                    }
                }
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtDrKodu.Clear();
            txtDrAdSoyad.Clear();
            cbPoliklinik.SelectedIndex = -1;
            txtDrKodu.Focus();
        }

        private void frmDoktorTanitma_Load(object sender, EventArgs e)
        {

        }
    }
}
