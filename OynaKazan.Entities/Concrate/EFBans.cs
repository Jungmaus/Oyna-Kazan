using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFBans : IBans
    {
        public void AddBan(Bans b)
        {
            using (var db = new OynaKazanEntities())
            {
                if (b != null)
                {
                    db.Bans.Add(b);
                    db.SaveChanges();

                }
            }
        }

        public void DeleteBan(int banId)
        {
            using (var db = new OynaKazanEntities())
            {
                Bans ban = db.Bans.FirstOrDefault(x => x.Id == banId);
                if (ban != null)
                {
                    db.Bans.Remove(ban);
                    db.SaveChanges();
                }
            }
        }

        public Bans GetBan(int banId)
        {
            using (var db = new OynaKazanEntities())
            {
                Bans ban = db.Bans.FirstOrDefault(x => x.Id == banId);
                return ban;
            }
        }

        public List<Bans> GetBanList()
        {
            using (var db = new OynaKazanEntities())
            {
                List<Bans> banList = db.Bans.ToList();
                return banList;
            }
        }

        public Bans GetUserBan(int userId)
        {
            using (var db = new OynaKazanEntities())
            {
                Bans ban = db.Bans.FirstOrDefault(x => x.User_Id == userId);
                return ban;
            }
        }

        public void UpdateBan(Bans b)
        {
            using (var db = new OynaKazanEntities())
            {
                if (b != null)
                {
                    db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}