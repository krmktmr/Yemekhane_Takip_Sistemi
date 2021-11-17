using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YemekHaneTakipOtomasyonu.Models;
using Microsoft.EntityFrameworkCore;

namespace YemekHaneTakipOtomasyonu.Controllers
{
    public class RaporController : Controller
    {
        Context hrkt = new Context();
        public IActionResult Rapor()
        {
            var degerler = hrkt.hareketlers.Include(x =>x.ogun).ToList();
            degerler.Reverse();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult RaporTemizle()
        {
            var degerlers = hrkt.hareketlers.ToList();
            foreach (var v in degerlers)
            {
                hrkt.hareketlers.Remove(v);
            }
            hrkt.SaveChanges();
            return RedirectToAction("Rapor", "Rapor");

        }
       
        public IActionResult RaporEkle()
        {
            var degerlers = hrkt.personel_Kartlaris.ToList();
            var ogunler= hrkt.yemek_Oguns.ToList();
            hareketler rap = new hareketler();
            yemek_ogun ogn = new yemek_ogun();
            

            int i = 0;
            foreach (var x in degerlers)
            {
                i++;
            }
            int[] personel = new int[i];
            i = 0;
            foreach (var x in degerlers)
            {
                personel[i] = x.kartno;
                i++;

            }
            Random rastgelesayi = new Random();
            int no = rastgelesayi.Next(0, personel.Length);
            int c = personel[no];
            var pers = hrkt.personel_Kartlaris.Find(c);
            int ognid =0;
            int kntr = 0;
            int tarih = Convert.ToInt32(DateTime.Now.ToString("HHmm"));
            int kontor = 0;
            int ogunbaslangıc=0;
            int ogunbitis = 0;

            foreach (var v in ogunler)
            {
                if (v.ogun_ad == "Sabah")
                {
                    ogunbaslangıc = v.basla;
                }
                if (v.ogun_ad == "Akşam")
                { 
                    ogunbitis = v.bitis; 
                }
            }

             foreach (var v in ogunler)
            {
                if (v.basla < tarih && v.bitis >= tarih)
                {
                    ognid = v.id;
                    kntr = v.ucret;
                    break;
                }
                else if (v.basla == 0)
                {
                    ognid = v.id;
                    kntr = v.ucret;
                    break;
                }
                   
                }
                    foreach (var x in degerlers)
            {
                if (x.kartno == c)
                {
                    rap.kartno = c.ToString();
                        rap.isim = x.adi + " " + x.soyadi;
                        rap.tarih_saat = DateTime.Now;
                        rap.ogunid = ognid;
                        kontor = x.kalankontor - kntr;
                    if (kontor >= 0)
                    {
                        if (ogunbaslangıc < tarih && ogunbitis > tarih)
                        {
                            rap.Kontor = kontor;
                            pers.kalankontor = kontor;
                            rap.gecisdurum = "Geçiş Başarılı";

                        }
                        else 
                        {
                            rap.Kontor = x.kalankontor;
                            rap.gecisdurum = "Geçiş Başarısız Yemekhane Kapalı";

                        }
                    }
                    else 
                    {
                        rap.Kontor = x.kalankontor;
                        rap.gecisdurum = "Geçiş Başarısız Yetersiz Kontör";
                     }
                    break;
                }

            }
            hrkt.hareketlers.Add(rap);
            hrkt.SaveChanges();


            return RedirectToAction("Rapor", "Rapor");
        }
    }
}
