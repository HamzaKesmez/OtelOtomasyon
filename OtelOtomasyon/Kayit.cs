using OtelOtomasyon.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class Kayit : Form
    {
        private string connectionString = @"Server=MSI;Database=OtelOtomasyonu;Trusted_Connection=True;";
        public Kayit()
        {
            InitializeComponent();
        }

        public void Odacbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Oda bilgilerini al
            var oda = (Oda)odacbox.Items[e.Index];

            // Oda durumuna göre renk seçimi
            Color renk;
            bool isSelectable;

            if (oda.Durum == "Boş")
            {
                renk = Color.Green; // Yeşil
                isSelectable = true; // Seçilebilir
            }
            else
            {
                renk = Color.Red; // Kırmızı
                isSelectable = false; // Seçilemez
            }

            // Arka plan rengini ayarla
            e.DrawBackground();
            e.Graphics.FillRectangle(new SolidBrush(renk), e.Bounds);
            e.Graphics.DrawString(oda.OdaNo.ToString(), e.Font, Brushes.White, e.Bounds);

            e.DrawFocusRectangle();

            // Eğer oda seçilemezse, bu durumu belirtmek için metni sil
            if (!isSelectable)
            {
                e.Graphics.DrawString("Seçilemez", e.Font, Brushes.Gray, e.Bounds);
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email; // E-posta formatını kontrol et
            }
            catch
            {
                return false; // Hata varsa geçersiz
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Telefon numarası 10 haneli ve sadece rakamlardan oluşmalı
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
        private void notxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamların (0-9) girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Geçersiz karakteri engelle
            }
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            notxt.KeyPress += new KeyPressEventHandler(notxt_KeyPress);

            using (var context = new OtelContext())
            {
                var odalar = context.Odalar
                                    .Where(o => o.Durum == "Boş") // Sadece boş odaları getir
                                    .Select(o => new Oda
                                    {
                                        Id = o.Id,
                                        OdaNo = o.OdaNo,
                                        KatNo = o.KatNo,
                                        YatakSayisi = o.YatakSayisi,
                                        Fiyat = o.Fiyat,
                                        Durum = o.Durum
                                    })
                                    .ToList();

                odacbox.DataSource = odalar;
                odacbox.DisplayMember = "OdaNo";
                odacbox.ValueMember = "Id";
                odacbox.DrawMode = DrawMode.OwnerDrawFixed; // Özel çizim modunu ayarlıyoruz
            }

            odacbox.DrawItem += Odacbox_DrawItem; // Çizim olayını ekliyoruz

            using (var context = new OtelContext())
            {
                var odemeTurleri = context.Odemeler
                                          .Select(o => new { o.Id, o.OdemeTur })
                                          .ToList();

                odemecbox.DataSource = odemeTurleri;
                odemecbox.DisplayMember = "OdemeTur";
                odemecbox.ValueMember = "Id";
            }

            using (var context = new OtelContext())
            {
                var KayitTurleri = context.KayitTurler
                                          .Select(o => new { o.KayitTuruId, o.KayitTur })
                                          .ToList();

                kayitcbox.DataSource = KayitTurleri;
                kayitcbox.DisplayMember = "KayitTur";
                kayitcbox.ValueMember = "KayitTuruId";
            }
        }

        private void GeriBut_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Close();
            giris.Show();
        }

        public void FaturaEkle(int musteriID, decimal toplamTutar, int odemeTuruID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Faturalar (MusteriID, ToplamTutar, FaturaTarihi, OdemeTuruID) VALUES (@MusteriID, @ToplamTutar, @FaturaTarihi, @OdemeTuruID)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MusteriID", musteriID);
                command.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                command.Parameters.AddWithValue("@FaturaTarihi", DateTime.Now);
                command.Parameters.AddWithValue("@OdemeTuruID", odemeTuruID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Fatura başarıyla eklendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatura eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }


        private void KayitBut_Click(object sender, EventArgs e)
        {
            // Tüm alanların doldurulup doldurulmadığını kontrol et
            if (string.IsNullOrWhiteSpace(adtxt.Text) ||
                string.IsNullOrWhiteSpace(soyadtxt.Text) ||
                string.IsNullOrWhiteSpace(mailtxt.Text) ||
                string.IsNullOrWhiteSpace(notxt.Text) ||
                odacbox.SelectedItem == null) // Oda seçimi kontrolü
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }

            // E-posta formatını kontrol et
            if (!IsValidEmail(mailtxt.Text))
            {
                MessageBox.Show("Lütfen uygun mail formatı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Hata varsa işlemden çık
            }

            // Telefon numarasını kontrol et
            if (!IsValidPhoneNumber(notxt.Text))
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Hata varsa işlemden çık
            }

            int odaId = Convert.ToInt32(odacbox.SelectedValue); // Seçilen oda ID'sini al
            decimal toplamTutar;

            // yeniMusteri değişkenini burada tanımlıyoruz
            Musteri yeniMusteri = null;

            using (var context = new OtelContext())
            {
                // Oda durumu kontrolü
                var oda = context.Odalar.Find(odaId); // Odayı bul
                if (oda == null)
                {
                    MessageBox.Show("Oda bulunamadı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // İşlemi durdur
                }

                if (oda.Durum == "Dolu") // Oda doluysa işlemi durdur
                {
                    MessageBox.Show("Seçtiğiniz oda dolu. Lütfen başka bir oda seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // İşlemi durdur
                }

                // Yeni müşteri oluşturma
                yeniMusteri = new Musteri(0, adtxt.Text, soyadtxt.Text, mailtxt.Text, notxt.Text);
                context.Musteriler.Add(yeniMusteri);
                context.SaveChanges(); // Müşteri kaydediliyor

                // Yeni rezervasyon oluşturma
                int kayitTuruId = Convert.ToInt32(kayitcbox.SelectedValue);
                var yeniRezervasyon = new Rezervasyon
                {
                    GirisTarihi = dateTimePickerGiris.Value,
                    CikisTarihi = dateTimePickerCikis.Value,
                    MusteriID = yeniMusteri.MusteriID,
                    OdaNumarasi = oda.OdaNo,
                    KayitTuruID = kayitTuruId
                };
                context.Rezervasyonlar.Add(yeniRezervasyon);

                // Oda durumunu güncelleme
                oda.Durum = "Dolu";
                context.SaveChanges();

                // Toplam tutarı hesaplama
                var fiyat = oda.Fiyat;
                var toplamGunSayisi = (yeniRezervasyon.CikisTarihi - yeniRezervasyon.GirisTarihi).Days;
                toplamTutar = fiyat * toplamGunSayisi;
            }

            // Ödeme türü alınıyor
            int odemeTuruID = Convert.ToInt32(odemecbox.SelectedValue);

            // Fatura ekleme
            if (yeniMusteri != null)
            {
                FaturaEkle(yeniMusteri.MusteriID, toplamTutar, odemeTuruID);
            }

            // Başarılı mesajı ve form işlemleri
            MessageBox.Show("Kayıt başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Giris giris = new Giris();
            this.Close();
            giris.Show();
        }






        private void kayitcbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
