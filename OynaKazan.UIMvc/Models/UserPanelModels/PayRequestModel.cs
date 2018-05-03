using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.UserPanelModels
{
    public class PayRequestModel
    {
        public int Id { get; set; }
        public decimal Tutar { get; set; }
        public string IlgiliBankaAdi { get; set; }
        public string IslemTarihi { get; set; }
        public int Statu { get; set; }
    }
}