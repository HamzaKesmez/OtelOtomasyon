using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;
using OtelOtomasyon.Class;

namespace OtelOtomasyon
{
    public partial class Oturum : Form
    {
        public Oturum()
        {
            InitializeComponent();
        }

        private void girisBut_Click(object sender, EventArgs e)
        {
            TextBox kulAdBox = this.Controls.Find("kulAdBox", true).FirstOrDefault() as TextBox;
            TextBox parolaBox = this.Controls.Find("parolaBox", true).FirstOrDefault() as TextBox;

            if (kulAdBox != null && parolaBox != null)
            {
                string kullaniciAdi = kulAdBox.Text;
                string parola = parolaBox.Text;

                if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(parola))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KullaniciDogrula(kullaniciAdi, parola);
            }
        }

        private void KullaniciDogrula(string kullaniciAdi, string parola)
        {
            string connectionString = @"Server=MSI;Database=OtelOtomasyonu;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Pozisyon bilgisini çekmek için sorguyu güncelledik
                string query = "SELECT Pozisyon FROM Personeller WHERE CONCAT(Ad, ' ', Soyad) = @KullaniciAdi AND Parola = @Parola";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Parola", parola);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null) // Kullanıcı bulunduysa
                    {
                        string pozisyon = result.ToString(); // Pozisyon bilgisini al
                        SessionManager.KullaniciPozisyonu = pozisyon; // Global değişkene kaydet

                        MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ana formu aç
                        this.Hide();
                        Giris giris = new Giris(); // Ana form
                        giris.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya parola hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

