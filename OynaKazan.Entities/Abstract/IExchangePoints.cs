using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IExchangePoints
    {
        List<ExchangePoints> GetExchangeList();
        ExchangePoints GetExchange(int exchangeId);
        void UpdateExchangePoints(ExchangePoints ep);
        void AddExchangePoints(ExchangePoints ep);
        void DeleteExchangePoints(int exchangeId);
    }
}
