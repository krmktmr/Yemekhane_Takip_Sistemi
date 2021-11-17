using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YemekHaneTakipOtomasyonu.Models
{
    public partial class silinen_personel_kartlari
    {
        [Key]

        public int id { get; set; }
        public int kartno { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }


        public int sirketid { get; set; }
        public int departmanid { get; set; }
        public int bolumid { get; set; }
        public string unvani { get; set; }
        public Nullable<System.DateTime> giristarihi { get; set; }
        public Nullable<System.DateTime> cikistarihi { get; set; }
        public int kalankontor { get; set; }
    }
}
