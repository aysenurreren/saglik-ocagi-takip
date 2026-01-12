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
    public partial class frmKullaniciTanitma : Form
    {
        
        public frmKullaniciTanitma()
        {
            InitializeComponent();
        }

        private void txtKullaniciKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciKodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
                {
                    try
                    {
                        baglanti.Open();
                       
                        string sorgu = "SELECT * FROM Kullanici WHERE kullaniciadi = @p1";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@p1", txtKullaniciKodu.Text);
                        SqlDataReader oku = komut.ExecuteReader();

                        if (oku.Read())
                        {
                            txtsifre.Text = oku["sifre"].ToString();
                            cbYetki.Text = oku["yetki"].ToString(); 
                        }
                        else
                        {
                            MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata: " + hata.Message);
                    }
                }
            }
        }

        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtKullaniciKodu.Text) ||
                string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("Lütfen Kod, Kullanıcı Adı ve Şifre alanlarını boş bırakmayınız!");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();

                   
                    string sorgu = @"INSERT INTO kullanici (kodu, username, sifre, yetki, ad, soyad) 
                             VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    
                    komut.Parameters.AddWithValue("@p1", txtKullaniciKodu.Text.Trim()); 
                    komut.Parameters.AddWithValue("@p2", txtusername.Text.Trim());      
                    komut.Parameters.AddWithValue("@p3", txtsifre.Text.Trim());        
                    komut.Parameters.AddWithValue("@p4", cbYetki.Text);                
                    komut.Parameters.AddWithValue("@p5", "Yeni");                      
                    komut.Parameters.AddWithValue("@p6", "Kullanıcı");                 

                    komut.ExecuteNonQuery();

                    MessageBox.Show($"'{txtusername.Text}' kullanıcısı başarıyla oluşturuldu!");

                    
                    Temizle();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Kullanıcı eklenirken bir hata oluştu: " + hata.Message);
                }
            }
        }

        private void Temizle()
        {
            txtKullaniciKodu.Clear();
            txtusername.Clear();
            txtsifre.Clear();
            cbYetki.SelectedIndex = -1;
        }

        private void frmKullaniciTanitma_Load(object sender, EventArgs e)
        {

        }
    }
    }

