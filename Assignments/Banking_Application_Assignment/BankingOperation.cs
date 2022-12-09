using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banking_Application_Assignment
{
    public class BankingOperation
    {
        Banking newacc = new Banking();
        BankingTransaction transaction = new BankingTransaction();
        public void RandomCall()
        {
            Random random = new Random();
            int number = random.Next(1, 2);
            //int number = 1;
            if (number == 1)
            {
                //Task task = Task.Factory.StartNew(() => {
                //foreach (Account acc in Banking.AccountList)
                //{
                //    transaction.Withdrawal(acc);
                //}
                //});
                //Task.WaitAll(task);
                foreach (Account account in Banking.AccountList)
                {
                    Task task3 = Task.Factory.StartNew(() =>
                    {
                        transaction.Withdrawal(account);
                    });
                    Task.WaitAll(task3);
                }
                

            }
            else if (number == 2)
            {
                foreach (Account account in Banking.AccountList)
                {
                    Task task3 = Task.Factory.StartNew(() =>
                    {
                        transaction.Withdrawal(account);
                    });
                    Task task4 = Task.Factory.StartNew(() =>
                    {
                        transaction.Deposit(account);
                    });

                    Task.WaitAll(task3,task4);
                }
                //Task task = Task.Factory.StartNew(() =>
                //{
                //    foreach(Account acc in Banking.AccountList)
                //    {
                //        transaction.Withdrawal(acc);
                //    }
                //});

                ////foreach(Account account in Banking.AccountList)
                ////{
                ////    Task task3 = Task.Factory.StartNew(() =>
                ////    {
                ////        transaction.Withdrawal(account);
                ////    });

                ////}
                //Task task1 = Task.Factory.StartNew(() =>
                //{
                //    foreach (Account acc in Banking.AccountList)
                //    {
                //        transaction.Deposit(acc);
                //    }
                //});
                //Task.WaitAll(task, task1);
            }
            else
            {
                Task task1 = Task.Factory.StartNew(() =>
                {
                    foreach (Account acc in Banking.AccountList)
                    {
                        transaction.Deposit(acc);
                    }
                });
                Task.WaitAll(task1);
            }
        }

    }

}