using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IPayRequests
    {
        void AddPayRequest(PayRequests pr);
        void UpdatePayRequest(PayRequests pr);
        void DeletePayRequest(int pyId);
        PayRequests GetPayRequest(int pyId);
        List<PayRequests> GetPayRequestList();
        List<PayRequests> GetUserPayRequestList(int userId);
    }
}
