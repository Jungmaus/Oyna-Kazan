using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IAdmins
    {
        int Login(Admins a);
        Admins GetAdmin(int adminId);
        List<Admins> GetAdminList();
    }
}
