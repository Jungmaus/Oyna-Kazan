using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFAdmins : IAdmins
    {
        public Admins GetAdmin(int adminId)
        {
            using (var db = new OynaKazanEntities())
            {
                Admins a = db.Admins.FirstOrDefault(x => x.Id == adminId);
                return a;
            }
        }

        public List<Admins> GetAdminList()
        {
            using (var db = new OynaKazanEntities())
            {
                List<Admins> list = db.Admins.ToList();
                return list;
            }
        }

        public int Login(Admins a)
        {
            using (var db = new OynaKazanEntities())
            {
                Admins admin = db.Admins.FirstOrDefault(x => x.Kadi == a.Kadi && x.Sifre == a.Sifre);
                if(admin != null)
                {
                    admin.LastLoginDate = DateTime.Now;
                    admin.LastLoginIp = a.LastLoginIp;
                    db.Entry(admin).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
