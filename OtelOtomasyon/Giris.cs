using OtelOtomasyon.Class;
using System;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            YetkiKontrol();
        }
        private void YetkiKontrol()
        {
            string pozisyon = SessionManager.KullaniciPozisyonu;

            if (pozisyon == "Patron")
                return; 

            if (pozisyon == "temizlikçi")
            {
                button9.Visible = false; 
                button7.Visible = false; 
                button2.Visible = false; 
                KayitBut.Visible = false; 
            }
            if (pozisyon == "tekniker")
            {
                button9.Visible = false; 
                button7.Visible = false; 
                button2.Visible = false; 
                KayitBut.Visible = false; 

            }

        }
        private void KayitBut_Click_1(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            this.Hide();
            kayit.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Faturalandırma faturalandırma = new Faturalandırma();
            this.Hide();
            faturalandırma.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormOdalar odalarGorunum = new FormOdalar();
            odalarGorunum.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelYonetim yonetim = new PersonelYonetim();
            yonetim.Show();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
