using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application_Assignment
{
    public class BankingTransaction
    {
        public void Withdrawal(Account account)
        {
            account.TransactionAmount = 200;
            if(account.NetBalance > account.TransactionAmount)
            {
                account.NetBalance = account.NetBalance-account.TransactionAmount;
                Console.WriteLine($"New Balance of {account.AccountName}:: {account.NetBalance}");
            }
            else
            {
                Console.WriteLine("Cannot withdraw amount more than the balance");
            }
        }
        public void Deposit(Account account)
        {
            account.TransactionAmount = 200;
            account.NetBalance = account.NetBalance + account.TransactionAmount;
            Console.WriteLine($"New Balance of {account.AccountName}:: {account.NetBalance}");
        }
    }
}
