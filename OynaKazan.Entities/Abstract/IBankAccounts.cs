using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Abstract
{
    interface IBankAccounts
    {
        void AddBankAccount(BankAccounts ba);
        void UpdateBankAccount(BankAccounts ba);
        void DeleteBankAccount(int accountId);
        BankAccounts GetUserBankAccount(int userId,int accountId);
        List<BankAccounts> GetUserBankAccounts(int userId);
    }
}
