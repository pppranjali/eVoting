using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Banking_Application_Assignment
{
    public class Banking
    {
        Random random = new Random();
        public static ConcurrentBag<Account> AccountList = new ConcurrentBag<Account>();
        public void CreateAccount(string AccName,Decimal OpeningBal)
        {
            Account account = new Account();
            account.AccountName = AccName;
            account.OpeningBalance = OpeningBal;
            account.NetBalance = OpeningBal;
            account.AccountNumber = random.Next(1000,9000);
            AccountList.Add(account);
        }
    }
}
