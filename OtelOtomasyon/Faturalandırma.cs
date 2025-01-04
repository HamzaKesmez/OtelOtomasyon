using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class Faturalandırma : Form
    {
        private string connectionString = @"Server=MSI;Database=OtelOtomasyonu;Trusted_Connection=True;";

        public Faturalandırma()
        {
            InitializeComponent();
            FaturaListele();
        }

        private void FaturaListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
            SELECT 
                F.FaturaID, 
                M.MusteriID, 
                M.Ad, 
                M.Soyad, 
                M.Telefon, 
                M.Email, 
                F.ToplamTutar,              
                F.FaturaTarihi 
            FROM 
                Faturalar F
            JOIN 
                Musteriler M ON F.MusteriID = M.MusteriID";

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
       /* private void FaturaListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
            SELECT 
                F.FaturaID, 
                M.MusteriID, 
                M.Ad, 
                M.Soyad, 
                M.Telefon, 
                M.Email, 
                F.ToplamTutar,              
                F.FaturaTarihi,
                O.OdemeTur 
            FROM 
                Faturalar F
            JOIN 
                Musteriler M ON F.MusteriID = M.MusteriID
            JOIN 
                Odemeler O ON F.OdemeTurId = O.Id";

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
        }*/


        private void geriBut_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Close();
            giris.Show();
        }

       
    }
}
