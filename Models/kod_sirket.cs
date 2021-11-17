using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YemekHaneTakipOtomasyonu.Models
{
    public partial class kod_sirket
    {
        [Key]

        public int id { get; set; }
        public string aciklama { get; set; }
        public IList<personel_kartlari> personel_Kartlaris { get; set; }
    }
}
