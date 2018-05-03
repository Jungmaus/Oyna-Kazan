using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IUsers
    {
        Users GetUser(int userId);
        Users GetUserwKadi(string kadi);
        Users GetUserwEmail(string email);
        List<Users> GetUserList();
        int UserVarlikControl(Users u);
        int Login(Users u);
        void UpdateUser(Users u);
        void AddUser(Users u);
    }
}
