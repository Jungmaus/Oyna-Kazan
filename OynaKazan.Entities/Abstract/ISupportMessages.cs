using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface ISupportMessages
    {
        void AddSupportMessage(SupportMessages sm);
        void DeleteSupportMessage(int msgId);
        void UpdateSupportMessage(SupportMessages sm);
        SupportMessages GetSupportMessage(int msgId);
        List<SupportMessages> GetUserSupportMessages(int userId);
        List<SupportMessages> GetAllSupportMessages();
    }
}
