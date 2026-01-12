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
    public partial class frmArama : Form
    {
       
        public string aktarilacakDosyaNo { get; set; }
        public frmArama()
        {
            InitializeComponent();
        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "";

                
                    if (cbAramaKriteri.Text == "Hasta Adı Soyadı")
                    {
                        sorgu = "SELECT dosyano, ad, soyad, tckimlikno FROM Hasta WHERE ad LIKE @p1 OR soyad LIKE @p1";
                    }
                    else 
                    {
                        sorgu = "SELECT dosyano, ad, soyad, tckimlikno FROM Hasta WHERE dosyano = @p1";
                    }

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    
                    if (cbAramaKriteri.Text == "Hasta Adı Soyadı")
                        komut.Parameters.AddWithValue("@p1", "%" + txtAramaTerimi.Text + "%");
                    else
                        komut.Parameters.AddWithValue("@p1", txtAramaTerimi.Text);

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAramaSonuclari.DataSource = dt; 
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Arama hatası: " + hata.Message);
                }
            }
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (dgvAramaSonuclari.CurrentRow != null)
            {
                
                aktarilacakDosyaNo = dgvAramaSonuclari.CurrentRow.Cells["dosyano"].Value.ToString();
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir hasta seçiniz!");
            }
        }

        private void frmArama_Load(object sender, EventArgs e)
        {
            cbAramaKriteri.Items.Add("Hasta Adı Soyadı");
            cbAramaKriteri.Items.Add("Dosya No");
            cbAramaKriteri.SelectedIndex = 0;
        }
    }
}
