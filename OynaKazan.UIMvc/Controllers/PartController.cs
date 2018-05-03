using OynaKazan.UIMvc.Models.OperationsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OynaKazan.UIMvc.Controllers
{
    public class PartController : Controller
    {
        PartModelDoldurucu csModelDoldurucu = new PartModelDoldurucu();

        [ChildActionOnly]
        public ActionResult PuanBakiyeTablosu()
        {
            if (Session["Kadi"] != null)
            {
                var model = csModelDoldurucu.GetPuanBakiyeTabloModel(Session["Kadi"].ToString());
                return View(model);
            }
            else return RedirectToAction("GirisYap", "Home");
        }

        [ChildActionOnly]
        public ActionResult EarnPointTable()
        {
            if (Session["Kadi"] != null)
            {
                var model = csModelDoldurucu.GetEarnPointModel(Session["Kadi"].ToString());
                return View(model);
            }
            else return RedirectToAction("GirisYap", "Home");
        }

        [ChildActionOnly]
        public ActionResult PayRequests()
        {
                return View();
        }

        [ChildActionOnly]
        public ActionResult PuanBakiyeJumbotron()
        {
            if (Session["Kadi"] != null)
            {
                var model = csModelDoldurucu.GetPuanBakiyeJumbotronModel(Session["Kadi"].ToString());
                return View(model);
            }
            return RedirectToAction("GirisYap", "Home");
        }

    }
}