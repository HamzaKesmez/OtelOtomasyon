using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelOtomasyon
{
    public partial class Musteriler : Form
    {
        private string connectionString = @"Server=MSI;Database=OtelOtomasyonu;Trusted_Connection=True;";
        public Musteriler()
        {
            InitializeComponent();
            MusteriListele();
        }
        private void MusteriListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
            SELECT  
                M.MusteriID, 
                M.Ad, 
                M.Soyad, 
                M.Telefon, 
                M.Email, 
                R.OdaNumarasi,
                R.GirisTarihi,
                R.CikisTarihi                            
            FROM 
                Rezervasyonlar R
            JOIN 
                Musteriler M ON R.MusteriID = M.MusteriID
            WHERE
                R.KayitTuruID = 2";        ///////////////////////            Sadece Online Olan İşlemler

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt; // DataGridView'e veriyi bağlama
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Kolonları ekranı dolduracak şekilde ayarla
                    dgv.AllowUserToResizeColumns = false; // Kullanıcının kolon boyutunu değiştirmesini engelle
                    dgv.AllowUserToAddRows = false; // Kullanıcının yeni satır eklemesini engelle
                    dgv.AllowUserToDeleteRows = false; // Kullanıcının satır silmesini engelle
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tam satır seçimi
                    dgv.RowHeadersVisible = false; // Satır başlıklarını gizle
                    dgv.DefaultCellStyle.BackColor = Color.White; // Arka plan rengi
                    dgv.DefaultCellStyle.ForeColor = Color.Black; // Metin rengi
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // Sütun başlıklarının arka plan rengi
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Sütun başlıklarının metin rengi
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Sütun başlıkları için yazı tipi

                    // Alternatif satır renkleri
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                    // Düzenlemeleri engelle
                    dgv.ReadOnly = true; // Tüm hücreler için düzenleme engelle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Faturalar yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void geriBut_Click(object sender, EventArgs e)
        {

        }

        private void bulButon_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // DataGridView'i sıfırla
                    dgv.DataSource = null;

                    // TextBox içindeki değeri al
                    string searchText = bulTextBox.Text.Trim();

                    // CheckedListBox seçeneklerini kontrol et
                    bool isOnlineSelected = checkedListBox.CheckedItems.Contains("Online");
                    bool isResepsiyonSelected = checkedListBox.CheckedItems.Contains("Resepsiyon");

                    // Dinamik sorgu oluştur
                    string query = @"
            SELECT  
                M.MusteriID, 
                M.Ad, 
                M.Soyad, 
                M.Telefon, 
                M.Email, 
                R.OdaNumarasi,
                R.GirisTarihi,
                R.CikisTarihi                            
            FROM 
                Rezervasyonlar R
            JOIN 
                Musteriler M ON R.MusteriID = M.MusteriID
            WHERE 
                1=1";

                    // Koşulları sorguya ekle
                    if (isOnlineSelected && !isResepsiyonSelected)
                    {
                        query += " AND R.KayitTuruID = 2";
                    }
                    else if (isResepsiyonSelected && !isOnlineSelected)
                    {
                        query += " AND R.KayitTuruID = 1";
                    }
                    // Arama metnini sorguya ekle
                    query += @"
                AND (M.Ad LIKE @searchText OR 
                     M.Soyad LIKE @searchText OR 
                     M.Telefon LIKE @searchText OR 
                     M.Email LIKE @searchText OR
                     R.OdaNumarasi LIKE @searchText)";

                    // Sorguyu çalıştır ve sonuçları doldur
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt; // DataGridView'e yeni veriyi bağla
                    int resultCount = dt.Rows.Count;
                    MessageBox.Show($"{resultCount} sonuç bulundu.", "Arama Sonuçları", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama yapılırken bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
