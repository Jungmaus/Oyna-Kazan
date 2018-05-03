using OynaKazan.Entities;
using OynaKazan.Entities.Concrate;
using OynaKazan.UIMvc.Models.UserPanelModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.OperationsLibrary
{
    public class PartModelDoldurucu
    {
        EFExPointHistory csExHistory = new EFExPointHistory();
        EFUsers csUsers = new EFUsers();
        EFUserDetails csUserDetails = new EFUserDetails();
        EFExchangePoints csExchangePoints = new EFExchangePoints();
        EFEarnPointHistory csEarnPointHistory = new EFEarnPointHistory();
        EFPayRequests csPayRequests = new EFPayRequests();
        EFBankAccounts csBankAccounts = new EFBankAccounts();

        public List<PuanBakiyeTabloModel> GetPuanBakiyeTabloModel(string kadi)
        {
            Users u = csUsers.GetUserwKadi(kadi);
            List<PuanBakiyeTabloModel> model = new List<PuanBakiyeTabloModel>();

            List<ExPointHistory> dataList = csExHistory.GetUserPointHistory(u.Id).OrderBy(x => x.Time).ToList();
            foreach(var item in dataList)
            {
                ExchangePoints paket = csExchangePoints.GetExchange(item.ExchangePoint_Id);
                PuanBakiyeTabloModel gm = new PuanBakiyeTabloModel();
                gm.HarcananPuanAdeti = paket.Adet;
                gm.IslemTarihi = item.Time;
                gm.KazanilanBakiye = paket.Tutar;
                gm.PuanPaketID = paket.Id;
                model.Add(gm);
            }
            return model;
        }

        public List<KazanilanPuanGecmisiModeli> GetEarnPointModel(string kadi)
        {
            List<KazanilanPuanGecmisiModeli> model = new List<KazanilanPuanGecmisiModeli>();
            List<EarnPointHistory> dataList = csEarnPointHistory.GetUserPointHistory(csUsers.GetUserwKadi(kadi).Id);
            foreach(var item in dataList)
            {
                KazanilanPuanGecmisiModeli kpgm = new KazanilanPuanGecmisiModeli();
                kpgm.PuanAdedi = item.Puan;
                kpgm.IslemTarihi = item.Tarih;
                model.Add(kpgm);
            }
            return model;
        }

        public List<PayRequestModel> GetPayRequestModel(string kadi)
        {
            List<PayRequestModel> model = new List<PayRequestModel>();
            List<PayRequests> dataList = csPayRequests.GetUserPayRequestList(csUsers.GetUserwKadi(kadi).Id).OrderByDescending(x=>x.SendTime).ToList();
            foreach(var item in dataList)
            {
                PayRequestModel prm = new PayRequestModel();
                BankAccounts bank = csBankAccounts.GetUserBankAccount(item.User_Id, item.BankAccount_Id);
                prm.IlgiliBankaAdi = bank.BankaAdi;
                prm.IslemTarihi = item.SendTime.ToString();
                prm.Statu = item.Statu;
                prm.Tutar = item.Tutar;
                model.Add(prm);
            }
            return model;
        }

        public PuanBakiyeJumbotronModel GetPuanBakiyeJumbotronModel(string kadi)
        {
            Users u = csUsers.GetUserwKadi(kadi);
            UserDetails ud = csUserDetails.GetUserDetail(u.Id);
            PuanBakiyeJumbotronModel model = new PuanBakiyeJumbotronModel();
            model.Bakiye = ud.Bakiye;
            model.Puan = ud.Puan;
            return model;
        }


    }
}