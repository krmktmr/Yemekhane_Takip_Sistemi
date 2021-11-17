
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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace YemekHaneTakipOtomasyonu.Controllers
{
    public class OgunController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Ogunler()
        {
            var degerler = c.yemek_Oguns.ToList();
            return View(degerler);
        }
        
        public IActionResult OgunSil(int id)
        {
            var ogn = c.yemek_Oguns.Find(id);
            c.yemek_Oguns.Remove(ogn);
            c.SaveChanges();
            return RedirectToAction("Ogunler");
        }
        public IActionResult OgunEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OgunEkle(yemek_ogun s)
        {
            c.yemek_Oguns.Add(s);
            c.SaveChanges();
            return RedirectToAction("Ogunler", "Ogun");
        }

        public IActionResult OgunDuzenle(int id)
        {
            
            var ogn = c.yemek_Oguns.Find(id);
            return View("OgunDuzenle", ogn);
        }
        public IActionResult OgunGuncelle(yemek_ogun d)
        {
            var ogn = c.yemek_Oguns.Find(d.id);
            ogn.ogun_ad = d.ogun_ad;
            ogn.basla = d.basla;
            ogn.bitis = d.bitis;
            ogn.ucret = d.ucret;
            c.SaveChanges();
            return RedirectToAction("Ogunler", "Ogun");
        }
    }
}

