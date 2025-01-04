using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Class
{
    public class Fatura
    {
        public int FaturaID { get; set; }
        public Musteri Musteri { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int OdemeTuruID { get; set; } 
        public Odeme OdemeTur { get; set; }
    }

}
