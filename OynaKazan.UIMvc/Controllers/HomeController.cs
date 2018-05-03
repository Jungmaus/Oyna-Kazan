using OynaKazan.UIMvc.Models.AnaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OynaKazan.UIMvc.Controllers
{
    public class HomeController : Controller
    {
        Models.OperationsLibrary.HomeModelDoldurucu csModelDoldurucu = new Models.OperationsLibrary.HomeModelDoldurucu();

        // GET: Home
        public ActionResult AnaSayfa()
        {
            var model = csModelDoldurucu.GetIlkOnBes();
            return View(model);
        }

        public ActionResult Iletisim()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Iletisim(IletisimModel im)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    csModelDoldurucu.IletisimGonder(im);
                    ViewBag.Msg = "1";
                }
            }
            catch
            {
                ViewBag.Msg = "0";
            }
            return View();
        }

        public ActionResult Sozlesme()
        {
            return View();
        }

        public ActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KayitOl(KayitModel km)
        {
            if (ModelState.IsValid)
            {
                if (km.Sozlesme == true)
                {
                    int control = csModelDoldurucu.KadiKayit(km.KullaniciAdi);
                    int control1 = csModelDoldurucu.EmailKayit(km.Email);
                    if (control == 0 && control1 == 0)
                    {
                        csModelDoldurucu.KayitOl(km);
                        ViewBag.success = "1";
                    }
                    if (control == 1) ViewBag.msgKadi = "1";
                    if (control1 == 1) ViewBag.msgEmail = "1";
                }
                else ViewBag.msgSoz = "1";
            }
            return View();
        }

        public ActionResult GirisYap()
        {
            if (Session["Kadi"] != null && Session["Sifre"] != null) return RedirectToAction("Genel", "UserPanel");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GirisYap(GirisModel gm)
        {
            if (ModelState.IsValid)
            {
                int login = csModelDoldurucu.KullaniciKontrol(gm);
                if (login == 1)
                {
                    Session["Kadi"] = gm.KullaniciAdi;
                    Session["Sifre"] = gm.Sifre;
                    return RedirectToAction("Genel", "UserPanel");
                }
                else
                {
                    ViewBag.msg = login;
                }

            }
            return View();
        }


    }
}