using OynaKazan.UIMvc.Models.UserPanelModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OynaKazan.UIMvc.Controllers
{
    public class OperationController : Controller
    {
        OperationsModelDoldurucu csOperations = new OperationsModelDoldurucu();

        public ActionResult CikisYap()
        {
            Session.Abandon();
            return RedirectToAction("GirisYap","Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void PuanPaketiAl(int paketId)
        {
            if (Session["Kadi"] != null)
                csOperations.PuanPaketiAl(paketId, Session["Kadi"].ToString());
        }

        public void DeletePayRequest(int Id)
        {
            if (Session["Kadi"] != null)
            {
                csOperations.DeletePayRequest(Id, Session["Kadi"].ToString());
            }
            else Response.Redirect(Url.Action("GirisYap","Home"));
        }

    }
}