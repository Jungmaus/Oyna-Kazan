using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IExPointHistory
    {
        List<ExPointHistory> GetPointHistory();
        List<ExPointHistory> GetUserPointHistory(int userId);
        void AddPointEx(ExPointHistory eph);
        void DeletePointEx(int ephId);
    }
}
