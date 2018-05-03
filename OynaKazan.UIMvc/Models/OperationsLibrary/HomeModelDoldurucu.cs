using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OynaKazan.Entities.Concrate;
using OynaKazan.Entities;
using OynaKazan.UIMvc.Models.AnaModels;

namespace OynaKazan.UIMvc.Models.OperationsLibrary
{
    public class HomeModelDoldurucu
    {
        EFUserDetails csUserDetails = new EFUserDetails();
        EFUsers csUsers = new EFUsers();
        EFContact csContact = new EFContact();
        KullaniciVerileri csKullanici = new KullaniciVerileri();

        public List<IlkOnBesList> GetIlkOnBes()
        {
            List<IlkOnBesList> list = new List<IlkOnBesList>();
            List<UserDetails> data = csUserDetails.GetUserDetailList().OrderByDescending(UserDetails => UserDetails.Bakiye).ToList();
            int x = 0;
            foreach (var item in data)
            {
                if(x == 15 ||x > 15)
                {
                    break;
                }

                IlkOnBesList model = new IlkOnBesList();
                model.Kadi = csUsers.GetUser(item.UserId).Kadi;
                model.Bakiye = item.Bakiye;
                list.Add(model);
                x++;
            }
                return list;
        }

        public void IletisimGonder(IletisimModel im)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.AdSoyad = im.AdSoyad;
            iletisim.Email = im.Email;
            iletisim.Konu = im.Konu;
            iletisim.Mesaj = im.Mesaj;
            iletisim.SendTime = DateTime.Now;
            iletisim.IpAdress = csKullanici.GetIp();
            csContact.AddContact(iletisim);
        }

        public void KayitOl(KayitModel km)
        {
            Users u = new Users();
            UserDetails ud = new UserDetails();
            u.Kadi = km.KullaniciAdi;
            u.Sifre = km.Sifre;
            u.Email = km.Email;

            ud.Ad = km.Ad;
            ud.Soyad = km.Soyad;

            csUsers.AddUser(u);
            ud.UserId = csUsers.GetUserwKadi(u.Kadi).Id;
            csUserDetails.AddUserDetail(ud);
        }

        public int KadiKayit(string kadi)
        {
            Users user = csUsers.GetUserwKadi(kadi);
            if (user == null) return 0; else return 1;
        }

        public int EmailKayit(string email)
        {
            Users user = csUsers.GetUserwEmail(email);
            if (user == null) return 0; else return 1;
        }

        public int KullaniciKontrol(GirisModel gm)
        {
            Users u = new Users();
            u.Kadi = gm.KullaniciAdi;
            u.Sifre = gm.Sifre;
            u.LastLoginIpAdress = csKullanici.GetIp();
            int deger = csUsers.Login(u);
            return deger;
        }

    }
}