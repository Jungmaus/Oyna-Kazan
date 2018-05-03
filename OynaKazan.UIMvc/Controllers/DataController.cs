using OynaKazan.UIMvc.Models.OperationsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OynaKazan.UIMvc.Controllers
{
    public class DataController : Controller
    {
        DataModelDoldurucu csModelDoldurucu = new DataModelDoldurucu();

        public JsonResult GetUserPayRequestList()
        {
            if (Session["Kadi"] != null)
            {
                var data = csModelDoldurucu.GetUserPayRequestList(Session["Kadi"].ToString());
                return Json(data, JsonRequestBehavior.AllowGet);
            }else return Json(null);
        }
    }
}