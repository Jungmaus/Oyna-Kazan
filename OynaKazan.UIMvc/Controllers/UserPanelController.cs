using OynaKazan.Entities;
using OynaKazan.UIMvc.Models.OperationsLibrary;
using OynaKazan.UIMvc.Models.UserPanelModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OynaKazan.UIMvc.Controllers
{
    public class UserPanelController : Controller
    {
        UserPanelModelDoldurucu csModelDoldurucu = new UserPanelModelDoldurucu();

        // GET: UserPanel
        public ActionResult Genel()
        {
            if(Session["Kadi"] != null)
            {
                var user = csModelDoldurucu.GetUserwKadi(Session["Kadi"].ToString());
                Session["LastLoginIp"] = user.LastLoginIpAdress;
            }
            return View();
        }


        
        /* ---------- */

        public ActionResult PuanBozdur()
        {
            if (Session["Kadi"] != null)
            {
                var userD = csModelDoldurucu.GetUserDetailswKadi(Session["Kadi"].ToString());
                ViewBag.userPuan = userD.Puan;
            }
            var model = csModelDoldurucu.GetExchangePointList();
            return View(model);
        }

        public ActionResult OdemeTalebiOlustur()
        {
            if (Session["Kadi"] != null)
            {
                List<BankAccounts> bankAccountList = csModelDoldurucu.GetUserBankAccounts(Session["Kadi"].ToString());
                OdemeTalebiOlusturModel model = new OdemeTalebiOlusturModel();
                model.BankAccountList = bankAccountList;
                return View(model);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OdemeTalebiOlustur(OdemeTalebiOlusturModel ot)
        {
            if (ot != null)
            {
                ot.BankAccountList = csModelDoldurucu.GetUserBankAccounts(Session["Kadi"].ToString());
                if (ot.CekilecekTutar >= 20 && Session["Kadi"] != null)
                {
                        csModelDoldurucu.AddPayRequest(ot, Session["Kadi"].ToString());
                        return View(ot);
                }
                else
                {
                    return View(ot);
                }
            }
            return RedirectToAction("GirisYap", "Home");
        }

        public ActionResult BakiyeGecmisi()
        {
            return View();
        }

        public ActionResult PuanGecmisi()
        {
            return View();
        }


        /* --------- */

        public ActionResult YeniBankaHesabi()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult YeniBankaHesabi(BankaHesabiOlusturModel om)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        public ActionResult BankaHesaplari()
        {
            return View();
        }

        /* -------- */

        public ActionResult DestekTalebiOlustur()
        {
            return View();
        }

        public ActionResult DestekTalepleri()
        {
            return View();
        }

        /* -------- */
        public ActionResult HesapDetayAyari()
        {
            return View();
        }

        public ActionResult HesapAyarlari()
        {
            return View();
        }

    }
}