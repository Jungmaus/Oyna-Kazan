using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFSupportMessages : ISupportMessages
    {
        public void AddSupportMessage(SupportMessages sm)
        {
            using (var db = new OynaKazanEntities())
            {
                if(sm != null)
                {
                    db.SupportMessages.Add(sm);
                    db.SaveChanges();
                }
            }
        }

        public void DeleteSupportMessage(int msgId)
        {
            using (var db = new OynaKazanEntities())
            {
                SupportMessages msg = db.SupportMessages.FirstOrDefault(x => x.Id == msgId);
                if(msg != null)
                {
                    db.SupportMessages.Remove(msg);
                    db.SaveChanges();
                }
            }
        }

        public List<SupportMessages> GetAllSupportMessages()
        {
            using (var db = new OynaKazanEntities())
            {
                List<SupportMessages> list = db.SupportMessages.ToList();
                return list;
            }
        }

        public SupportMessages GetSupportMessage(int msgId)
        {
            using (var db = new OynaKazanEntities())
            {
                SupportMessages msg = db.SupportMessages.FirstOrDefault(x => x.Id == msgId);
                return msg;
            }
        }

        public List<SupportMessages> GetUserSupportMessages(int userId)
        {
            using (var db = new OynaKazanEntities())
            {
                List<SupportMessages> list = db.SupportMessages.Where(x => x.User_Id == userId).ToList();
                return list;
            }
        }

        public void UpdateSupportMessage(SupportMessages sm)
        {
            using (var db = new OynaKazanEntities())
            {
                if(sm != null)
                {
                    db.Entry(sm).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
