using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFEarnPointHistory : IEarnPointHistory
    {
        public void AddPointHistory(EarnPointHistory eph)
        {
            using (var db = new OynaKazanEntities())
            {
                if(eph != null)
                {
                    db.EarnPointHistory.Add(eph);
                    db.SaveChanges();
                }
            }
        }

        public List<EarnPointHistory> GetPointHistory()
        {
            using (var db = new OynaKazanEntities())
            {
                List<EarnPointHistory> history = db.EarnPointHistory.ToList();
                return history;
            }
        }

        public List<EarnPointHistory> GetUserPointHistory(int userId)
        {
            using (var db = new OynaKazanEntities())
            {
                List<EarnPointHistory> userHistory = db.EarnPointHistory.Where(x => x.User_Id == userId).ToList();
                return userHistory;
            }
        }
    }
}
