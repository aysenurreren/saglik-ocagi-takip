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
    public partial class HastaIslemleri : Form
    {
        
        public HastaIslemleri()
        {
            InitializeComponent();
        }

        private void txtDosya_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter tuşuna basıldı, veri aranıyor...");

            }
        }

        private void txtDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              

                using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
                {
                    baglanti.Open();
                
                    string sorgu = "SELECT ad, soyad, kurumadi FROM Hastalar WHERE dosyano = @p1";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", txtDosyaNo.Text);

                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        txtAd.Text = oku["ad"].ToString();
                        txtSoyad.Text = oku["soyad"].ToString();
                        txtKurumAdi.Text = oku["kurumadi"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Bu dosya numarasına ait bir hasta bulunamadı!");
                    }
                }
                e.SuppressKeyPress = true;
            }
        }

       

        private void lblToplamTutar_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPoliklinik.Text) || string.IsNullOrEmpty(txtDosyaNo.Text))
            {
                MessageBox.Show("Lütfen Hasta Seçiniz ve Poliklinik/İşlem alanlarını doldurunuz!");
                return;
            }

            string saat = DateTime.Now.ToShortTimeString();
            dgvIslemler.Rows.Add(cbPoliklinik.Text, txtSiraNo.Text, saat, cbYapilanIslem.Text, cbDrKodu.Text, nmMiktar.Value, txtBirimFiyat.Text);
            ToplamTutarHesapla();

            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                    string sevkSorgu = @"INSERT INTO sevk (sevktarihi, dosyano, poliklinik, yapilanislem, drkod, miktar, birimfiyat, toplamtutar, taburcu) 
                                 VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";

                    SqlCommand komutSevk = new SqlCommand(sevkSorgu, baglanti);
                    komutSevk.Parameters.AddWithValue("@p1", dtSevkTarihi.Value.ToString("yyyy-MM-dd"));
                    komutSevk.Parameters.AddWithValue("@p2", txtDosyaNo.Text);
                    komutSevk.Parameters.AddWithValue("@p3", cbPoliklinik.Text);
                    komutSevk.Parameters.AddWithValue("@p4", cbYapilanIslem.Text);
                    komutSevk.Parameters.AddWithValue("@p5", cbDrKodu.Text);
                    komutSevk.Parameters.AddWithValue("@p6", Convert.ToDouble(nmMiktar.Value));
                    komutSevk.Parameters.AddWithValue("@p7", Convert.ToDouble(txtBirimFiyat.Text));
                    komutSevk.Parameters.AddWithValue("@p8", Convert.ToDouble(nmMiktar.Value) * Convert.ToDouble(txtBirimFiyat.Text));
                    komutSevk.Parameters.AddWithValue("@p9", "edilmedi");

                    komutSevk.ExecuteNonQuery();
                    MessageBox.Show("Hasta muayene kaydı açıldı (Taburcu Bekliyor).");
                }
                catch (Exception hata) { MessageBox.Show("Hata: " + hata.Message); }
            }
        }
        private void ToplamTutarHesapla()
        {
            double genelToplam = 0;

          
            foreach (DataGridViewRow satir in dgvIslemler.Rows)
            {
                if (satir.Cells["BirimFiyat"].Value != null && satir.Cells["Miktar"].Value != null)
                {
                    try
                    {
                        double miktar = Convert.ToDouble(satir.Cells["Miktar"].Value);
                        double birimFiyat = Convert.ToDouble(satir.Cells["BirimFiyat"].Value);

                        genelToplam += (miktar * birimFiyat);
                    }
                    catch
                    {

                    }
                }
            }

           
            lblToplamTutar.Text = genelToplam.ToString("N2") + " YTL";
           
        }

        private void HastaIslemleri_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();

                    SqlCommand komutPol = new SqlCommand("SELECT poliklinikadi FROM Poliklinik", baglanti);
                    SqlDataReader okuPol = komutPol.ExecuteReader();
                    cbPoliklinik.Items.Clear();
                    while (okuPol.Read()) { cbPoliklinik.Items.Add(okuPol["poliklinikadi"].ToString()); }
                    okuPol.Close();

                    
                    SqlCommand komutIslem = new SqlCommand("SELECT islemAdi FROM islem", baglanti);
                    SqlDataReader okuIslem = komutIslem.ExecuteReader();
                    cbYapilanIslem.Items.Clear();
                    while (okuIslem.Read()) { cbYapilanIslem.Items.Add(okuIslem["islemAdi"].ToString()); }
                    okuIslem.Close();

                    
                    SqlCommand komutDr = new SqlCommand("SELECT drkodu FROM Doktorlar", baglanti);
                    SqlDataReader okuDr = komutDr.ExecuteReader();
                    cbDrKodu.Items.Clear();
                    while (okuDr.Read())
                    {
                        cbDrKodu.Items.Add(okuDr["drkodu"].ToString());
                    }
                    okuDr.Close();

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Listeler yüklenirken bir hata oluştu: " + hata.Message);
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmArama aramaPenceresi = new frmArama();

            if (aramaPenceresi.ShowDialog() == DialogResult.OK)
            {
                string gelenNo = aramaPenceresi.aktarilacakDosyaNo;

                txtDosyaNo.Text = gelenNo;

                HastaBilgileriniGetir(gelenNo);
            }
        }
        private void HastaBilgileriniGetir(string dosyaNo)
        {
            if (string.IsNullOrEmpty(dosyaNo))
            {
                MessageBox.Show("Lütfen bir dosya numarası giriniz!");
                return;
            }

            

            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                   
                    string sorgu = "SELECT ad, soyad, kurumadi FROM Hasta WHERE dosyano = @p1";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", dosyaNo);

                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        txtAd.Text = oku["ad"].ToString();
                        txtSoyad.Text = oku["soyad"].ToString();
                        txtKurumAdi.Text = oku["kurumadi"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt bulunamadı! Lütfen SQL'de Dosya No: 1 olan bir hasta olduğundan emin olun.");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Veri çekme hatası: " + hata.Message);
                }
            }
        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {
            if (dgvIslemler.SelectedRows.Count > 0)
            {
                DialogResult cevap = MessageBox.Show("Seçili işlemi listeden silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    foreach (DataGridViewRow satir in dgvIslemler.SelectedRows)
                    {
                        if (!satir.IsNewRow) 
                        {
                            dgvIslemler.Rows.Remove(satir);
                        }
                    }

                    ToplamTutarHesapla();

                    MessageBox.Show("İşlem başarıyla silindi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı sol taraftaki boşluktan seçiniz!");
            }
    }

        private void btnYeni_Click(object sender, EventArgs e)
        {
          
            txtDosyaNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtKurumAdi.Clear();
            txtSiraNo.Clear();
            txtBirimFiyat.Clear();

            nmMiktar.Value = 1;

            dgvIslemler.Rows.Clear();

            lblToplamTutar.Text = "0 YTL";

            txtDosyaNo.Focus();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                    string tarih = dtSevkTarihi.Value.ToString("yyyy-MM-dd");

                   
                    string guncelleSorgu = "UPDATE sevk SET taburcu = 'edildi' WHERE dosyano = @d1 AND sevktarihi = @d2";
                    SqlCommand komutGuncelle = new SqlCommand(guncelleSorgu, baglanti);
                    komutGuncelle.Parameters.AddWithValue("@d1", txtDosyaNo.Text);
                    komutGuncelle.Parameters.AddWithValue("@d2", tarih);
                    komutGuncelle.ExecuteNonQuery();

                    
                    decimal genelToplam = decimal.Parse(lblToplamTutar.Text.Replace(" YTL", "").Trim());
                    string cikisSorgu = "INSERT INTO cikis (dosyano, sevktarihi, odeme, toplamtutar) VALUES (@c1, @c2, @c3, @c4)";
                    SqlCommand komutCikis = new SqlCommand(cikisSorgu, baglanti);
                    komutCikis.Parameters.AddWithValue("@c1", txtDosyaNo.Text);
                    komutCikis.Parameters.AddWithValue("@c2", tarih);
                    komutCikis.Parameters.AddWithValue("@c3", "Nakit");
                    komutCikis.Parameters.AddWithValue("@c4", genelToplam);
                    komutCikis.ExecuteNonQuery();

                    MessageBox.Show("Hasta başarıyla taburcu edildi ve faturası kesildi.");
                    dgvIslemler.Rows.Clear(); 
                }
                catch (Exception hata) { MessageBox.Show("Hata: " + hata.Message); }
            }
        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslikFont = new Font("Arial", 16, FontStyle.Bold);
            Font icerikFont = new Font("Arial", 12, FontStyle.Regular);
            Font tabloBaslikFont = new Font("Arial", 12, FontStyle.Bold);

           
            e.Graphics.DrawString("SAĞLIK OCAĞI HASTA TAKİP SİSTEMİ", baslikFont, Brushes.Black, 250, 50);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToShortDateString(), icerikFont, Brushes.Black, 650, 100);

            e.Graphics.DrawString("Dosya No: " + txtDosyaNo.Text, icerikFont, Brushes.Black, 100, 150);
            e.Graphics.DrawString("Hasta Adı: " + txtAd.Text + " " + txtSoyad.Text, icerikFont, Brushes.Black, 100, 180);
            e.Graphics.DrawString("Kurum Adı: " + txtKurumAdi.Text, icerikFont, Brushes.Black, 100, 210);

            e.Graphics.DrawLine(Pens.Black, 100, 250, 750, 250);

            e.Graphics.DrawString("Poliklinik", tabloBaslikFont, Brushes.Black, 100, 260);
            e.Graphics.DrawString("Yapılan İşlem", tabloBaslikFont, Brushes.Black, 300, 260);
            e.Graphics.DrawString("Fiyat", tabloBaslikFont, Brushes.Black, 600, 260);

            int y = 290;

            foreach (DataGridViewRow satir in dgvIslemler.Rows)
            {
                if (!satir.IsNewRow)
                {
                    e.Graphics.DrawString(satir.Cells["Poliklinik"].Value.ToString(), icerikFont, Brushes.Black, 100, y);
                    e.Graphics.DrawString(satir.Cells["YapilanIslem"].Value.ToString(), icerikFont, Brushes.Black, 300, y);
                    e.Graphics.DrawString(satir.Cells["BirimFiyat"].Value.ToString() + " YTL", icerikFont, Brushes.Black, 600, y);
                    y += 30; 
                }
            }

            e.Graphics.DrawLine(Pens.Black, 100, y + 10, 750, y + 10);
            e.Graphics.DrawString("GENEL TOPLAM: " + lblToplamTutar.Text, baslikFont, Brushes.Black, 450, y + 30);
        }

        private void cbYapilanIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbYapilanIslem.SelectedItem == null) return;

            string secilenIslem = cbYapilanIslem.SelectedItem.ToString();
            

            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT birimfiyat FROM islem WHERE islemAdi = @p1";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", secilenIslem);

                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        txtBirimFiyat.Text = oku["birimfiyat"].ToString();
                    }
                    oku.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Fiyat getirilirken hata oluştu: " + hata.Message);
                }
            }
        }

        private void cbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPoliklinik.SelectedItem == null) return;

            string secilenPol = cbPoliklinik.SelectedItem.ToString();
            cbDrKodu.Items.Clear();



            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();

                    string drSorgu = "SELECT drkodu FROM Doktorlar WHERE poliklinikadi = @p1";
                    SqlCommand drKomut = new SqlCommand(drSorgu, baglanti);
                    drKomut.Parameters.AddWithValue("@p1", secilenPol);
                    SqlDataReader oku = drKomut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbDrKodu.Items.Add(oku["drkodu"].ToString());
                    }
                    oku.Close();

                    string siraSorgu = "SELECT COUNT(*) + 1 FROM sevk WHERE poliklinik = @p1 AND sevktarihi = @p2";
                    SqlCommand siraKomut = new SqlCommand(siraSorgu, baglanti);
                    siraKomut.Parameters.AddWithValue("@p1", secilenPol);
                    siraKomut.Parameters.AddWithValue("@p2", DateTime.Now.ToString("yyyy-MM-dd"));

                    txtSiraNo.Text = siraKomut.ExecuteScalar().ToString();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Veriler yüklenirken hata oluştu: " + hata.Message);
                }
            }
        }


        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDosyaNo.Text))
            {
                MessageBox.Show("Lütfen önce bir hasta aratınız!");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                try
                {
                    baglanti.Open();
                   
                    string sorgu = "SELECT * FROM hasta WHERE dosyano = @p1";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", txtDosyaNo.Text);
                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        string bilgi = $"--- HASTA DETAYLI BİLGİLERİ ---\n\n" +
                                       $"TC Kimlik No: {oku["tckimlikno"]}\n" +
                                       $"Dosya No: {oku["dosyano"]}\n" +
                                       $"Ad Soyad: {oku["ad"]} {oku["soyad"]}\n" +
                                       $"Doğum Yeri: {oku["dogumyeri"]}\n" +
                                       $"Doğum Tarihi: {Convert.ToDateTime(oku["dogumtarihi"]).ToShortDateString()}\n" +
                                       $"Baba Adı: {oku["babaadi"]}\n" +
                                       $"Anne Adı: {oku["anneadi"]}\n" +
                                       $"Cinsiyet: {oku["cinsiyet"]}\n" +
                                       $"Kan Grubu: {oku["kangrubu"]}\n" +
                                       $"Medeni Hal: {oku["medenihal"]}\n" +
                                       $"Telefon: {oku["tel"]}\n" +
                                       $"Kurum Adı: {oku["kurumadi"]}\n" +
                                       $"Adres: {oku["adres"]}";

                        MessageBox.Show(bilgi, "Hasta Kartı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    oku.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bilgiler getirilirken hata oluştu: " + hata.Message);
                }
            }
        }

        private void txtDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
                {
                    try
                    {
                        baglanti.Open();

                        string sorguHasta = "SELECT ad, soyad, kurumadi FROM hasta WHERE dosyano = @p1";
                        SqlCommand komutHasta = new SqlCommand(sorguHasta, baglanti);
                        komutHasta.Parameters.AddWithValue("@p1", txtDosyaNo.Text);
                        SqlDataReader okuHasta = komutHasta.ExecuteReader();

                        if (okuHasta.Read())
                        {
                            txtAd.Text = okuHasta["ad"].ToString();
                            txtSoyad.Text = okuHasta["soyad"].ToString();
                            txtKurumAdi.Text = okuHasta["kurumadi"].ToString();

                            okuHasta.Close(); 

                            string sorguSevk = "SELECT DISTINCT sevktarihi FROM sevk WHERE dosyano = @p1 ORDER BY sevktarihi DESC";
                            SqlCommand komutSevk = new SqlCommand(sorguSevk, baglanti);
                            komutSevk.Parameters.AddWithValue("@p1", txtDosyaNo.Text);
                            SqlDataReader okuSevk = komutSevk.ExecuteReader();

                            cbOncekiIslemler.Items.Clear(); 
                            while (okuSevk.Read())
                            {
                                string tarih = Convert.ToDateTime(okuSevk["sevktarihi"]).ToString("yyyy-MM-dd");
                                cbOncekiIslemler.Items.Add(tarih);
                            }
                            okuSevk.Close();

                            if (cbOncekiIslemler.Items.Count > 0)
                            {
                                MessageBox.Show("Hastanın geçmiş işlemleri bulundu. 'Önceki İşlemler' menüsünden seçim yapabilirsiniz.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu dosya numarasına ait hasta bulunamadı!");
                           
                            txtAd.Clear(); txtSoyad.Clear(); txtKurumAdi.Clear(); cbOncekiIslemler.Items.Clear();
                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata oluştu: " + hata.Message);
                    }
                }
                e.Handled = true; 
            }
        }

        private void cbOncekiIslemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOncekiIslemler.SelectedItem == null) return;

            using (SqlConnection baglanti = new SqlConnection(Veritabanı.adres))
            {
                baglanti.Open();
               
                string sorgu = "SELECT poliklinik, sira, saat, yapilanislem, drkod, miktar, birimfiyat FROM sevk " +
                               "WHERE dosyano = @p1 AND sevktarihi = @p2";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtDosyaNo.Text);
                komut.Parameters.AddWithValue("@p2", DateTime.Parse(cbOncekiIslemler.SelectedItem.ToString()).ToString("yyyy-MM-dd"));

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvIslemler.Rows.Clear();
                foreach (DataRow satir in dt.Rows)
                {
                    dgvIslemler.Rows.Add(satir.ItemArray); 
                }
                ToplamTutarHesapla();
            }
        }
    }
    }
    
    
    

