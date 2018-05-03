using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OynaKazan.UIMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
  name: "GetUserPayRequestList",
  url: "Data/GetUserPayRequestList",
  defaults: new { controller = "Data", action = "GetUserPayRequestList" }
);

            routes.MapRoute(
       name: "PuanGecmisi",
       url: "UserPanel/PuanGecmisi",
       defaults: new { controller = "UserPanel", action = "PuanGecmisi" }
   );

            routes.MapRoute(
  name: "DeletePayRequest",
  url: "Operation/DeletePayRequest",
  defaults: new { controller = "Operation", action = "DeletePayRequest" }
);

            routes.MapRoute(
       name: "YeniBankaHesabi",
       url: "UserPanel/YeniBankaHesabi",
       defaults: new { controller = "UserPanel", action = "YeniBankaHesabi" }
   );

            routes.MapRoute(
             name: "PuanPaketiAl",
             url: "Operation/PuanPaketiAl",
             defaults: new { controller = "Operation", action = "PuanPaketiAl" }
         );

            routes.MapRoute(
           name: "BakiyeGecmisi",
           url: "Panel/BakiyeGecmisi",
           defaults: new { controller = "UserPanel", action = "BakiyeGecmisi" }
       );

            routes.MapRoute(
            name: "OdemeTalebiOlustur",
            url: "Panel/OdemeTalebiOlustur",
            defaults: new { controller = "UserPanel", action = "OdemeTalebiOlustur" }
        );

            routes.MapRoute(
               name: "PuanBozdur",
               url: "Panel/PuanBozdur",
               defaults: new { controller = "UserPanel", action = "PuanBozdur" }
           );

            routes.MapRoute(
              name: "PuanBakiyeJumbotron",
              url: "Part/PuanBakiyeJumbotron",
              defaults: new { controller = "Part", action = "PuanBakiyeJumbotron" }
          );

            routes.MapRoute(
             name: "PuanBakiyeTablosu",
             url: "Part/PuanBakiyeTablosu",
             defaults: new { controller = "Part", action = "PuanBakiyeTablosu" }
         );

            routes.MapRoute(
                name: "EarnPointTable",
                url: "Part/EarnPointTable",
                 defaults: new { controller = "Part", action = "EarnPointTable" }
            );

            routes.MapRoute(
               name: "PayRequests",
               url: "PayRequests",
               defaults: new { controller = "Part", action = "PayRequests" }
           );

            routes.MapRoute(
                name: "CikisYap",
                url: "Operation/CikisYap",
                defaults: new { controller = "Operation", action = "CikisYap" }
                );

            routes.MapRoute(
                name: "Default",
                url: "Anasayfa",
                defaults: new { controller = "Home", action = "Anasayfa" }
            );

            routes.MapRoute(
                name: "Iletisim",
                url: "Iletisim",
                 defaults: new { controller = "Home", action = "Iletisim" }
                );

            routes.MapRoute(
                name: "Sozlesme",
                url: "Sozlesme",
                 defaults: new { controller = "Home", action = "Sozlesme" }
                );

            routes.MapRoute(
                name: "KayitOl",
                url: "KayitOl",
                 defaults: new { controller = "Home", action = "KayitOl" }
                );

            routes.MapRoute(
                name: "GirisYap",
                url: "GirisYap",
                 defaults: new { controller = "Home", action = "GirisYap" }
                );

            routes.MapRoute(
                name: "Genel",
                url: "Panel/GostergePaneli",
                defaults: new { controller = "UserPanel", action = "Genel" }
                );

        }
    }
}
