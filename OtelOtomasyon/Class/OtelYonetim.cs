using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Class
{
   
        public class OtelYonetim
        {
            public List<Oda> Odalar { get; set; }
            public List<Rezervasyon> Rezervasyonlar { get; set; }
            public List<Fatura> Faturalar { get; set; }
            public List<Musteri> Musteriler { get; set; }
            public List<Personel> Personeller { get; set; }

            public OtelYonetim()
            {
                Odalar = new List<Oda>();
                Rezervasyonlar = new List<Rezervasyon>();
                Faturalar = new List<Fatura>();
                Musteriler = new List<Musteri>();
                Personeller = new List<Personel>();
            }
        }


}
