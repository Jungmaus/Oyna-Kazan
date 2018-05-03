using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IEarnPointHistory
    {
        void AddPointHistory(EarnPointHistory eph);
        List<EarnPointHistory> GetUserPointHistory(int userId);
        List<EarnPointHistory> GetPointHistory();
    }
}
