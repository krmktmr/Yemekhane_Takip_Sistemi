using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekHaneTakipOtomasyonu.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=176.53.69.151\\MSSQLSERVER2019;Initial Catalog=katmerte_kktechno;Persist Security Info=True;User ID=katmerte_kkadmin;Password=kkadmin145353+-/*");
        }
        public DbSet<hareketler> hareketlers { get; set; }
        public DbSet<kod_bolum> kod_Bolums { get; set; }
        public DbSet<kod_departman> kod_Departmen { get; set; }
        public DbSet<kod_sirket> kod_Sirkets { get; set; }
        public DbSet<personel_kartlari> personel_Kartlaris { get; set; }
        public DbSet<silinen_personel_kartlari> silinen_Personel_Kartlaris { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<yemek_ogun> yemek_Oguns { get; set; }
    }
}
