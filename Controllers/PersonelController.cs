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
    public class PersonelController : Controller
    {
        Context c = new Context();
        
        [HttpGet]
        public IActionResult Personeller()
        {
            var degerler = c.personel_Kartlaris.Include(x => x.bolum).Include(x => x.departman).Include(x => x.sirket).ToList();

            return View(degerler);
        }
        
        public IActionResult PersonelSil(int id)
        {
            silinen_personel_kartlari sp = new silinen_personel_kartlari();
            var pers = c.personel_Kartlaris.Find(id);
            sp.kartno = pers.kartno;
            sp.adi = pers.adi;
            sp.soyadi = pers.soyadi;
            sp.sirketid = pers.sirketid;
            sp.departmanid = pers.departmanid;
            sp.bolumid = pers.bolumid;
            sp.unvani = pers.unvani;
            sp.giristarihi = pers.giristarihi;
            sp.cikistarihi = DateTime.Now;
            sp.kalankontor = pers.kalankontor;
            c.silinen_Personel_Kartlaris.Add(sp);
            c.personel_Kartlaris.Remove(pers);
            c.SaveChanges();
            return RedirectToAction("Personeller");
        }
        public IActionResult PersonelEkle()
        {
            List<SelectListItem> sirket = (from x in c.kod_Sirkets.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.aciklama,
                                               Value = x.id.ToString()
                                           }).ToList();
            List<SelectListItem> departman = (from x in c.kod_Departmen.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.aciklama,
                                                  Value = x.id.ToString()
                                              }).ToList();
            List<SelectListItem> bolum = (from x in c.kod_Bolums.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.aciklama,
                                              Value = x.id.ToString()
                                          }).ToList();

            ViewBag.blmdgr = bolum;
            ViewBag.srktdgr = sirket;
            ViewBag.dprtdgr = departman;

            return View();

        }
        [HttpPost]
        public IActionResult PersonelEkle(personel_kartlari s)
        {
            var blm = c.kod_Bolums.Where(x => x.id == s.bolum.id).FirstOrDefault();
            var srkt = c.kod_Sirkets.Where(x => x.id == s.sirket.id).FirstOrDefault();
            var dprt = c.kod_Departmen.Where(x => x.id == s.departman.id).FirstOrDefault();
            s.bolum = blm;
            s.sirket = srkt;
            s.departman = dprt;
            s.giristarihi = DateTime.Now;
            c.personel_Kartlaris.Add(s);
            c.SaveChanges();
            return RedirectToAction("Personeller", "Personel");
        }
       
        public IActionResult PersonelDuzenle(int id)
        {
            List<SelectListItem> sirket = (from x in c.kod_Sirkets.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.aciklama,
                                               Value = x.id.ToString()
                                           }).ToList();
            List<SelectListItem> departman = (from x in c.kod_Departmen.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.aciklama,
                                                  Value = x.id.ToString()
                                              }).ToList();
            List<SelectListItem> bolum = (from x in c.kod_Bolums.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.aciklama,
                                              Value = x.id.ToString()
                                          }).ToList();

            ViewBag.blmdgr = bolum;
            ViewBag.srktdgr = sirket;
            ViewBag.dprtdgr = departman;
            var pers = c.personel_Kartlaris.Find(id);
            return View("PersonelDuzenle",pers);
        }
        public IActionResult PersonelGuncelle(personel_kartlari d)
        {
            var blm = c.kod_Bolums.Where(x => x.id == d.bolum.id).FirstOrDefault();
            var srkt = c.kod_Sirkets.Where(x => x.id == d.sirket.id).FirstOrDefault();
            var dprt = c.kod_Departmen.Where(x => x.id == d.departman.id).FirstOrDefault();
            var pers = c.personel_Kartlaris.Find(d.kartno);
            pers.adi= d.adi;
            pers.soyadi= d.soyadi;
            pers.sirket = srkt;
            pers.departman = dprt;
            pers.bolum = blm;
            pers.unvani = d.unvani;
            pers.kalankontor = d.kalankontor;
            c.SaveChanges();
            return RedirectToAction("Personeller", "Personel");
        }
    }
    }
