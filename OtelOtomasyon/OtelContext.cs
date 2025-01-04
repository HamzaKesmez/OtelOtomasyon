using Microsoft.EntityFrameworkCore;
using OtelOtomasyon.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon
{     
        public class OtelContext : DbContext
        {
            public DbSet<Oda> Odalar { get; set; }
            public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
            public DbSet<Fatura> Faturalar { get; set; }
            public DbSet<Musteri> Musteriler { get; set; }
            public DbSet<Personel> Personeller { get; set; }
            public DbSet<Odeme> Odemeler { get; set; }
             public DbSet<KayitTuru> KayitTurler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {               
                optionsBuilder.UseSqlServer(@"Server=MSI;Database=OtelOtomasyonu;Trusted_Connection=True;");
            }
        }
    
}
