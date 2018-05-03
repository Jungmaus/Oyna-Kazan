using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFExPointHistory : IExPointHistory
    {
        public void AddPointEx(ExPointHistory eph)
        {
            using (var db = new OynaKazanEntities())
            {
                if(eph != null)
                {
                    db.ExPointHistory.Add(eph);
                    db.SaveChanges();
                }
            }
        }

        public void DeletePointEx(int ephId)
        {
            using (var db = new OynaKazanEntities())
            {
                ExPointHistory eph = db.ExPointHistory.FirstOrDefault(x => x.Id == ephId);
                if(eph != null)
                {
                    db.ExPointHistory.Remove(eph);
                    db.SaveChanges();
                }
            }
        }

        public List<ExPointHistory> GetPointHistory()
        {
            using (var db = new OynaKazanEntities())
            {
                List<ExPointHistory> ephList = db.ExPointHistory.ToList();
                return ephList;
            }
        }

        public List<ExPointHistory> GetUserPointHistory(int userId)
        {
            using (var db = new OynaKazanEntities())
            {
                List<ExPointHistory> ephList = db.ExPointHistory.Where(x => x.User_Id == userId).ToList();
                return ephList;
            }
        }
    }
}
