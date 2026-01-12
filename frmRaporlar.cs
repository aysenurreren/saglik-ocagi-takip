using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHBTS
{
    public partial class frmRaporlar : Form
    {
        
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "";
               
                    if (radioButton2.Checked) 
                    {
                        sorgu = @"SELECT DISTINCT c.dosyano, h.ad, h.soyad, c.sevktarihi, s.poliklinik, c.toplamtutar 
                          FROM cikis c 
                          INNER JOIN hasta h ON LTRIM(RTRIM(c.dosyano)) = LTRIM(RTRIM(h.dosyano)) 
                          LEFT JOIN sevk s ON c.dosyano = s.dosyano AND c.sevktarihi = s.sevktarihi 
                          WHERE c.sevktarihi BETWEEN @t1 AND @t2";
                    }
                    else if (radioButton3.Checked)
                    {
                        sorgu = @"SELECT DISTINCT s.dosyano, h.ad, h.soyad, s.sevktarihi, s.poliklinik, s.toplamtutar 
                          FROM sevk s 
                          INNER JOIN hasta h ON LTRIM(RTRIM(s.dosyano)) = LTRIM(RTRIM(h.dosyano)) 
                          WHERE s.taburcu = 'edilmedi' AND s.sevktarihi BETWEEN @t1 AND @t2";
                    }
                    else 
                    {
                        sorgu = @"SELECT DISTINCT s.dosyano, h.ad, h.soyad, s.sevktarihi, s.poliklinik, s.taburcu 
                          FROM sevk s 
                          INNER JOIN hasta h ON LTRIM(RTRIM(s.dosyano)) = LTRIM(RTRIM(h.dosyano)) 
                          WHERE s.sevktarihi BETWEEN @t1 AND @t2";
                    }

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                  
                    komut.Parameters.Add("@t1", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    komut.Parameters.Add("@t2", SqlDbType.NVarChar).Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Seçilen kriterlere uygun kayıt bulunamadı.");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Rapor hatası: " + hata.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.Document = printDocument1;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("HASTA RAPORU", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, 100);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToShortDateString(), new Font("Arial", 10), Brushes.Black, 100, 130);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; 
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            radioButton1.Checked = true; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {

        }
    }
}


