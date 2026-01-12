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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {


                using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
                {
                    baglanti.Open();

                    
                    string sorgu = "SELECT * FROM kullanici WHERE username=@p1 AND sifre=@p2";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        
                        string yetkiDurumu = oku["yetki"].ToString(); 

                        AnaForm ana = new AnaForm();

                       
                        if (yetkiDurumu != "Admin")
                        {
                            ana.referanslarToolStripMenuItem.Visible = false;
                        }

                        ana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hata: Kullanıcı adı veya şifre yanlış!");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı hatası: " + hata.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtKullaniciAdi.Focus(); 
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
