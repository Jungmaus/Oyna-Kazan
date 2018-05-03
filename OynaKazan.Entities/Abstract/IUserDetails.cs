using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IUserDetails
    {
        List<UserDetails> GetUserDetailList();
        UserDetails GetUserDetail(int userId);
        void AddUserDetail(UserDetails ud);
        void UpdateUserDetail(UserDetails ud);
    }
}
