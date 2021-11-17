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
    public class DepartmanController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Departmanlar()
        {
            var degerler = c.kod_Departmen.ToList();
            return View(degerler);
        }
        public IActionResult DepartmanSil(int id)
        {
            var dprt = c.kod_Departmen.Find(id);
            c.kod_Departmen.Remove(dprt);
            c.SaveChanges();
            return RedirectToAction("Departmanlar");
        }
        public IActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DepartmanEkle(kod_departman s)
        {
            c.kod_Departmen.Add(s);
            c.SaveChanges();
            return RedirectToAction("Departmanlar", "Departman");
        }

        public IActionResult DepartmanDuzenle(int id)
        {

            var dprt = c.kod_Departmen.Find(id);
            return View("DepartmanDuzenle", dprt);
        }
        public IActionResult DepartmanGuncelle(kod_departman d)
        {
            var dprt = c.kod_Departmen.Find(d.id);
            dprt.aciklama = d.aciklama;
            c.SaveChanges();
            return RedirectToAction("Departmanlar", "Departman");
        }
    }
}
