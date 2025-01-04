﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtelOtomasyon;

namespace OtelOtomasyon.Migrations
{
    [DbContext(typeof(OtelContext))]
    [Migration("20241028095154_RemoveOdemeTuruID")]
    partial class RemoveOdemeTuruID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OtelOtomasyon.Class.Fatura", b =>
                {
                    b.Property<int>("FaturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FaturaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MusteriID")
                        .HasColumnType("int");

                    b.Property<int>("OdemeTuruID")
                        .HasColumnType("int");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FaturaID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Faturalar");
                });

            modelBuilder.Entity("OtelOtomasyon.Class.KayitTuru", b =>
                {
                    b.Property<int>("KayitTuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KayitTur")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KayitTuruId");

                    b.ToTable("KayitTurler");
                });

            modelBuilder.Entity("OtelOtomasyon.Class.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusteriID");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("OtelOtomasyon.Class.Oda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Durum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KatNo")
                        .HasColumnType("int");

                    b.Property<int>("OdaNo")
                        .HasColumnType("int");

                    b.Property<int>("YatakSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Odalar");
                });

            modelBuilder.Entity("OtelOtomasyon.Class.Odeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OdemeTur")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Odemeler");
                });

            modelBuilder.Entity("OtelOtomasyon.Class.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Maas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Pozisyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelID");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("OtelOtomasyon.Class.Rezervasyon", b =>
                {
                    b.Property<int>("RezervasyonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GirisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KayitTuruID")
                        .HasColumnType("int");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<int>("OdaNumarasi")
                        .HasColumnType("int");

                    b.HasKey("RezervasyonID");

                    b.ToTable("Rezervasyonlar");
                });

            modelBuilder.Entity("OtelOtomasyon.Class.Fatura", b =>
                {
                    b.HasOne("OtelOtomasyon.Class.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriID");
                });
#pragma warning restore 612, 618
        }
    }
}
