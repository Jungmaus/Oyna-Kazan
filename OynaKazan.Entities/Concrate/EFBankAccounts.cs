using OynaKazan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OynaKazan.Entities.Concrate
{
    public class EFBankAccounts : IBankAccounts
    {
        public void AddBankAccount(BankAccounts ba)
        {
            using (var db = new OynaKazanEntities())
            {
                if(ba != null)
                {
                    db.BankAccounts.Add(ba);
                    db.SaveChanges();
                }
            }
        }

        public void DeleteBankAccount(int accountId)
        {
            using (var db = new OynaKazanEntities())
            {
                BankAccounts ba = db.BankAccounts.FirstOrDefault(x => x.Id == accountId);
                if(ba != null)
                {
                    db.BankAccounts.Remove(ba);
                    db.SaveChanges();
                }
            }
        }

        public BankAccounts GetUserBankAccount(int userId, int accountId)
        {
            using (var db = new OynaKazanEntities())
            {
                BankAccounts account = db.BankAccounts.FirstOrDefault(x => x.Id == accountId && x.User_Id == userId);
                return account;
            }
        }

        public List<BankAccounts> GetUserBankAccounts(int userId)
        {
            using (var db = new OynaKazanEntities())
            {
                List<BankAccounts> accountList = db.BankAccounts.Where(x => x.User_Id == userId).ToList();
                return accountList;
            }
        }

        public void UpdateBankAccount(BankAccounts ba)
        {
            using (var db = new OynaKazanEntities())
            {
                if(ba != null)
                {
                    db.Entry(ba).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
