using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Class
{
    public class Oda
    {
        public int Id { get; set; }
        public int OdaNo { get; set; }
        public int KatNo { get; set; }
        public int YatakSayisi { get; set; }
        public decimal Fiyat { get; set; }
        public string Durum { get; set; } // "Dolu" veya "Boş"

       
    }

}
