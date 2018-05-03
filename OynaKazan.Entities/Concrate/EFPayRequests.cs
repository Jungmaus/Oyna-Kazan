using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFPayRequests : IPayRequests
    {
        public void AddPayRequest(PayRequests pr)
        {
            using (var db = new OynaKazanEntities())
            {
                if (pr != null)
                {
                    UserDetails ud = db.UserDetails.FirstOrDefault(x => x.Id == pr.User_Id);
                    if (ud != null)
                    {
                        pr.Tutar = Math.Round(pr.Tutar);
                        if (pr.Tutar >= 20 && ud.Bakiye >= pr.Tutar)
                        {
                            ud.Bakiye = (ud.Bakiye - pr.Tutar);
                            db.Entry(ud).State = System.Data.Entity.EntityState.Modified;
                            db.PayRequests.Add(pr);
                            db.SaveChanges();
                        }
                        else
                        {
                            string a = "!!!*";
                            int b = Convert.ToInt32(a);
                        }
                    }
                }
            }
        }

        public void DeletePayRequest(int pyId)
        {
            using (var db = new OynaKazanEntities())
            {
                PayRequests pr = db.PayRequests.FirstOrDefault(x => x.Id == pyId);
                if (pr != null)
                {
                    db.PayRequests.Remove(pr);
                    db.SaveChanges();
                }
            }
        }

        public PayRequests GetPayRequest(int pyId)
        {
            using (var db = new OynaKazanEntities())
            {
                PayRequests pr = db.PayRequests.FirstOrDefault(x => x.Id == pyId);
                return pr;
            }
        }

        public List<PayRequests> GetPayRequestList()
        {
            using (var db = new OynaKazanEntities())
            {
                List<PayRequests> list = db.PayRequests.ToList();
                return list;
            }
        }

        public List<PayRequests> GetUserPayRequestList(int userId)
        {
            using (var db = new OynaKazanEntities())
            {
                List<PayRequests> list = db.PayRequests.Where(x => x.User_Id == userId).ToList();
                return list;
            }
        }

        public void UpdatePayRequest(PayRequests pr)
        {
            using (var db = new OynaKazanEntities())
            {
                if (pr != null)
                {
                    db.Entry(pr).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
