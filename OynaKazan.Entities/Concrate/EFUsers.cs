using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFUsers : IUsers
    {
        public void AddUser(Users u)
        {
            using (var db = new OynaKazanEntities())
            {
                if (u != null)
                {
                    db.Users.Add(u);
                    db.SaveChanges();
                }
            }
        }

        public Users GetUser(int userId)
        {
            using (var db = new OynaKazanEntities())
            {
                Users u = db.Users.FirstOrDefault(x => x.Id == userId);
                return u;
            }
        }

        public List<Users> GetUserList()
        {
            using (var db = new OynaKazanEntities())
            {
                List<Users> list = db.Users.Where(x=>x.ActivateStatu == 1).ToList();
                return list;
            }
        }

        public Users GetUserwEmail(string email)
        {
            using (var db = new OynaKazanEntities())
            {
                Users user = db.Users.FirstOrDefault(x => x.Email == email);
                return user;
            }
        }

        public Users GetUserwKadi(string kadi)
        {
            using (var db = new OynaKazanEntities())
            {
                Users user = db.Users.FirstOrDefault(x => x.Kadi == kadi);
                return user;
            }
        }

        public int Login(Users u)
        {
            using (var db = new OynaKazanEntities())
            {
                Users user = db.Users.FirstOrDefault(x => x.Kadi == u.Kadi && x.Sifre == u.Sifre);
                if (user != null)
                {
                    if (user.ActivateStatu == 0)
                    {
                        return 2;
                    }
                    else
                    {
                        user.LastLoginDate = DateTime.Now;
                        user.LastLoginIpAdress = u.LastLoginIpAdress;
                        db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return 1;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public void UpdateUser(Users u)
        {
            using (var db = new OynaKazanEntities())
            {
                if (u != null)
                {
                    db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public int UserVarlikControl(Users u)
        {
            using (var db = new OynaKazanEntities())
            {
                Users user = db.Users.FirstOrDefault(x => x.Kadi == u.Kadi || x.Email == u.Email);
                if (user == null)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
