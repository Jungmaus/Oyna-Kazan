using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFExchangePoints : IExchangePoints
    {
        public void AddExchangePoints(ExchangePoints ep)
        {
            using (var db = new OynaKazanEntities())
            {
                if(ep != null)
                {
                    db.ExchangePoints.Add(ep);
                    db.SaveChanges();
                }
            }
        }

        public void DeleteExchangePoints(int exchangeId)
        {
            using (var db = new OynaKazanEntities())
            {
                ExchangePoints ep = db.ExchangePoints.FirstOrDefault(x => x.Id == exchangeId);
                if(ep != null)
                {
                    db.ExchangePoints.Remove(ep);
                    db.SaveChanges();
                }
            }
        }

        public ExchangePoints GetExchange(int exchangeId)
        {
            using (var db = new OynaKazanEntities())
            {
                ExchangePoints ep = db.ExchangePoints.FirstOrDefault(x => x.Id == exchangeId);
                return ep;
            }
        }

        public List<ExchangePoints> GetExchangeList()
        {
            using (var db = new OynaKazanEntities())
            {
                List<ExchangePoints> list = db.ExchangePoints.ToList();
                return list;
            }
        }

        public void UpdateExchangePoints(ExchangePoints ep)
        {
            using (var db = new OynaKazanEntities())
            {
                if(ep != null)
                {
                    db.Entry(ep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
