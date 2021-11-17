using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using YemekHaneTakipOtomasyonu.Models;


namespace YemekHaneTakipOtomasyonu.Controllers
{
    
    public class AdminController : Controller
    {
        Context admin = new Context();
        [AllowAnonymous]
        [HttpGet]
        
        public IActionResult GirisYap()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> GirisYap(users p)
        {
            var bilgiler = admin.users.FirstOrDefault(x => x.kullanici == p.kullanici && x.sifre == p.sifre);
            if(bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.kullanici)
                };
                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Rapor", "Rapor");

            }

            return View();
        }
        [HttpGet]
        public async Task<ActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("GirisYap", "Admin");

        }
        public IActionResult Kullanicilar()
        {
            var degerler = admin.users.ToList();
            return View(degerler);
        }

        public IActionResult KullaniciSil(int id)
        {
            var usr = admin.users.Find(id);
            admin.users.Remove(usr);
            admin.SaveChanges();
            return RedirectToAction("Kullanicilar");
        }
        public IActionResult KullaniciEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KullaniciEkle(users s)
        {
            admin.users.Add(s);
           admin.SaveChanges();
            return RedirectToAction("Kullanicilar", "Admin");
        }

        public IActionResult KullaniciDuzenle(int id)
        {

            var usr = admin.users.Find(id);
            return View("KullaniciDuzenle", usr);
        }
        public IActionResult KullaniciGuncelle(users d)
        {
            var usr = admin.users.Find(d.id);
            usr.kullanici = d.kullanici;
            usr.sifre = d.sifre;
            admin.SaveChanges();
            return RedirectToAction("Kullanicilar", "Admin");
        }
    }
}
