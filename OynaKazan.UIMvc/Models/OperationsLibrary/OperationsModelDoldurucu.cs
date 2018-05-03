using OynaKazan.Entities;
using OynaKazan.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.UserPanelModels
{
    public class OperationsModelDoldurucu
    {
        EFExPointHistory csExPointHistory = new EFExPointHistory();
        EFExchangePoints csExchangePoints = new EFExchangePoints();
        EFUsers csUsers = new EFUsers();
        EFUserDetails csUserDetails = new EFUserDetails();
        EFPayRequests csPayRequests = new EFPayRequests();
        EFBankAccounts csBankAccounts = new EFBankAccounts();

        public void PuanPaketiAl(int paketId,string kadi)
        {
            Users user = csUsers.GetUserwKadi(kadi);
            UserDetails userDetails = csUserDetails.GetUserDetail(user.Id);
            ExchangePoints paket = csExchangePoints.GetExchange(paketId);
            if(userDetails.Puan >= paket.Adet)
            {
                ExPointHistory newHistory = new ExPointHistory();
                newHistory.User_Id = user.Id;
                newHistory.ExchangePoint_Id = paket.Id;
                newHistory.Time = DateTime.Now;
                csExPointHistory.AddPointEx(newHistory);
            }
            else
            {
                string a = "*!!!'";
                int b = Convert.ToInt32(a);
            }

        }

        public void DeletePayRequest(int id,string kadi)
        {
            Users u = csUsers.GetUserwKadi(kadi);
            PayRequests pr = csPayRequests.GetPayRequest(id);
            if (pr != null && pr.Statu == 0)
            {
                csPayRequests.DeletePayRequest(pr.Id);
            }
        }

    }
}