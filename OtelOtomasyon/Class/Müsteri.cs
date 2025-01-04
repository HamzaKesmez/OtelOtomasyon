using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Class
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public Musteri(int musteriID, string ad, string soyad, string telefon, string email)
        {
            MusteriID = musteriID;
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Email = email;
        }

        public void MusteriBilgileri()
        {
            Console.WriteLine($"Müşteri: {Ad} {Soyad}, Telefon: {Telefon}, Email: {Email}");
        }
    }

}
