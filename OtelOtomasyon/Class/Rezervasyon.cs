using Microsoft.EntityFrameworkCore.Migrations;
using OtelOtomasyon.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Class
{
    public class Rezervasyon
    {
        public int RezervasyonID { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int KayitTuruID { get; set; }
        public int OdaNumarasi { get; set; }
        public int MusteriID { get; set; }
    }

}
