using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.UserPanelModels
{
    public class PuanBakiyeTabloModel
    {
        public int PuanPaketID { get; set; }
        public int HarcananPuanAdeti { get; set; }
        public decimal KazanilanBakiye { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}