using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IContact
    {
        void AddContact(Iletisim il);
        void DeleteContact(int contactId);
        Iletisim GetContact(int contactId);
        List<Iletisim> GetContactList();
    }
}
