using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace YemekHaneTakipOtomasyonu.Models
{
    public partial class hareketler
    {
        [Key]
        public int id { get; set; }
        public string kartno { get; set; }
        public string isim { get; set; }
        public Nullable<System.DateTime> tarih_saat { get; set; }
        
        public int ogunid { get; set; }
        public yemek_ogun ogun { get; set; }
        public string gecisdurum { get; set; }
        public int Kontor { get; set; }
       
    }
}
