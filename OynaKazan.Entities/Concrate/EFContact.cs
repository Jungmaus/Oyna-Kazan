using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFContact : IContact
    {
        public void AddContact(Iletisim il)
        {
            using (var db = new OynaKazanEntities())
            {
                if(il != null)
                {
                    db.Iletisim.Add(il);
                    db.SaveChanges();
                }
            }
        }

        public void DeleteContact(int contactId)
        {
            using (var db = new OynaKazanEntities())
            {
                Iletisim contact = db.Iletisim.FirstOrDefault(x => x.Id == contactId);
                if(contact != null)
                {
                    db.Iletisim.Remove(contact);
                    db.SaveChanges();
                }
            }
        }

        public Iletisim GetContact(int contactId)
        {
            using (var db = new OynaKazanEntities())
            {
                Iletisim contact = db.Iletisim.FirstOrDefault(x => x.Id == contactId);
                return contact;
            }
        }

        public List<Iletisim> GetContactList()
        {
            using (var db = new OynaKazanEntities())
            {
                List<Iletisim> list = db.Iletisim.ToList();
                return list;
            }
        }
    }
}
