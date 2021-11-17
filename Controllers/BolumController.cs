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
    public class BolumController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Bolumler()
        {
            var degerler = c.kod_Bolums.ToList();
            return View(degerler);
        }
        public IActionResult BolumSil(int id)
        {
            var blm = c.kod_Bolums.Find(id);
            c.kod_Bolums.Remove(blm);
            c.SaveChanges();
            return RedirectToAction("Bolumler");
        }
        public IActionResult BolumEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BolumEkle(kod_bolum s)
        {
            c.kod_Bolums.Add(s);
            c.SaveChanges();
            return RedirectToAction("Bolumler", "Bolum");
        }

        public IActionResult BolumDuzenle(int id)
        {

            var blm = c.kod_Bolums.Find(id);
            return View("BolumDuzenle", blm);
        }
        public IActionResult BolumGuncelle(kod_bolum d)
        {
            var blm = c.kod_Bolums.Find(d.id);
            blm.aciklama = d.aciklama;
            c.SaveChanges();
            return RedirectToAction("Bolumler", "Bolum");
        }
    }
}
