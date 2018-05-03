using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFUserDetails : IUserDetails
    {
        public void AddUserDetail(UserDetails ud)
        {
            using (var db = new OynaKazanEntities())
            {
                if(ud != null)
                {
                    db.UserDetails.Add(ud);
                    db.SaveChanges();
                }
            }
        }

        public UserDetails GetUserDetail(int userId)
        {
            using (var db = new OynaKazanEntities())
            {
                UserDetails ud = db.UserDetails.FirstOrDefault(x => x.UserId == userId);
                return ud;
            }
        }

        public List<UserDetails> GetUserDetailList()
        {
            using (var db = new OynaKazanEntities())
            {
                List<UserDetails> list = db.UserDetails.ToList();
                return list;
            }
        }

        public void UpdateUserDetail(UserDetails ud)
        {
            using (var db = new OynaKazanEntities())
            {
                if(ud != null)
                {
                    db.Entry(ud).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
