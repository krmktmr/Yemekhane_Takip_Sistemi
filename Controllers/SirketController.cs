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
    public class SirketController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Sirketler()
        {
            var degerler = c.kod_Sirkets.ToList();
            return View(degerler);
        }
        public IActionResult SirketSil(int id)
        {
            var srkt = c.kod_Sirkets.Find(id);
            c.kod_Sirkets.Remove(srkt);
            c.SaveChanges();
            return RedirectToAction("Sirketler");
        }
        public IActionResult SirketEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SirketEkle(kod_sirket s)
        {
            c.kod_Sirkets.Add(s);
            c.SaveChanges();
            return RedirectToAction("Sirketler", "Sirket");
        }

        public IActionResult SirketDuzenle(int id)
        {
            var srkt = c.kod_Sirkets.Find(id);
            return View("SirketDuzenle", srkt);
        }
        public IActionResult SirketGuncelle(kod_sirket d)
        {
            var srkt = c.kod_Sirkets.Find(d.id);
            srkt.aciklama = d.aciklama;
            c.SaveChanges();
            return RedirectToAction("Sirketler", "Sirket");
        }
    }
}
