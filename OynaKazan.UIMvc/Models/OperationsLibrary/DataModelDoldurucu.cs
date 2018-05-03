using OynaKazan.Entities;
using OynaKazan.Entities.Concrate;
using OynaKazan.UIMvc.Models.UserPanelModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.OperationsLibrary
{
    public class DataModelDoldurucu
    {
        EFUsers csUsers = new EFUsers();
        EFPayRequests csPayRequests = new EFPayRequests();
        EFBankAccounts csBankAccounts = new EFBankAccounts();

        public List<PayRequestModel> GetUserPayRequestList(string kadi)
        {
            List<PayRequestModel> List = new List<PayRequestModel>();
            Users user = csUsers.GetUserwKadi(kadi);
            List<PayRequests> userPayRequest = csPayRequests.GetPayRequestList().Where(x => x.User_Id == user.Id).OrderByDescending(x=>x.SendTime).ToList();
            foreach(var item in userPayRequest)
            {
                BankAccounts ba = csBankAccounts.GetUserBankAccount(user.Id, item.BankAccount_Id);
                PayRequestModel im = new PayRequestModel();
                im.Id = item.Id;
                im.IlgiliBankaAdi = ba.BankaAdi;
                im.IslemTarihi = item.SendTime.ToString();
                im.Tutar = item.Tutar;
                im.Statu = item.Statu;
                List.Add(im);
            }
            return List;
        }


    }
}