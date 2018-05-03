using OynaKazan.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OynaKazan.UIMvc.Models.UserPanelModels
{
    public class OdemeTalebiOlusturModel
    {
        [Required(ErrorMessage = "Lütfen çekilecek tutarı belirtiniz.")]
        public decimal CekilecekTutar { get; set; }

        [Required(ErrorMessage = "Bir banka hesabı seçmek zorundasınız.")]
        public int BankAccountID { get; set; }

        public List<BankAccounts> BankAccountList { get; set; }

        public int UserId { get; set; }

        public OdemeTalebiOlusturModel()
        {
            this.BankAccountList = new List<BankAccounts>();
            this.CekilecekTutar = 20;
        }
    }
}