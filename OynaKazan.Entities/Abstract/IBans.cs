using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IBans
    {
        List<Bans> GetBanList();
        Bans GetUserBan(int userId);
        Bans GetBan(int banId);
        void AddBan(Bans b);
        void UpdateBan(Bans b);
        void DeleteBan(int banId);
    }
}
