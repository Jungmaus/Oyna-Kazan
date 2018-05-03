using OynaKazan.Entities;
using OynaKazan.Entities.Concrate;
using OynaKazan.UIMvc.Models.UserPanelModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.OperationsLibrary
{
    public class UserPanelModelDoldurucu
    {
        EFUsers csUsers = new EFUsers();
        EFUserDetails csUserDetails = new EFUserDetails();
        EFExchangePoints csExchangePoints = new EFExchangePoints();
        EFBankAccounts csBankAccounts = new EFBankAccounts();
        EFPayRequests csPayRequest = new EFPayRequests();

        public UserDetails GetUserDetailswKadi(string kadi)
        {
            Users u = csUsers.GetUserwKadi(kadi);
            UserDetails ud = csUserDetails.GetUserDetail(u.Id);
            return ud;
        }

        public Users GetUserwKadi(string kadi)
        {
            Users u = csUsers.GetUserwKadi(kadi);
            return u;
        }

        public List<ExchangePoints> GetExchangePointList()
        {
            List<ExchangePoints> list = csExchangePoints.GetExchangeList();
            return list;
        }

        public List<BankAccounts> GetUserBankAccounts(string kadi)
        {
            Users user = csUsers.GetUserwKadi(kadi);
            List<BankAccounts> list = csBankAccounts.GetUserBankAccounts(user.Id);
            return list;
        }

        public void AddPayRequest(OdemeTalebiOlusturModel ot, string kadi)
        {      
            Users u = csUsers.GetUserwKadi(kadi);
            PayRequests odemeTalebi = new PayRequests();
            odemeTalebi.SendTime = DateTime.Now;
            odemeTalebi.Statu = 0;
            odemeTalebi.Tutar = ot.CekilecekTutar;
            odemeTalebi.User_Id = u.Id;
            odemeTalebi.BankAccount_Id = ot.BankAccountID;
            csPayRequest.AddPayRequest(odemeTalebi);
        }

    }
}