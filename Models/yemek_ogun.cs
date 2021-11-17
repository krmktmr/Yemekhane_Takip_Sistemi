using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YemekHaneTakipOtomasyonu.Models
{
    public partial class yemek_ogun
    {
        [Key]

        public int id { get; set; }
        public string ogun_ad { get; set; }
        public int basla { get; set; }
        public int bitis { get; set; }
        public int ucret { get; set; }
        public IList<hareketler> hareketlers { get; set; }
    }
}
