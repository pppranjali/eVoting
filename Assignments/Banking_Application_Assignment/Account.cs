using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace Banking_Application_Assignment
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }=string.Empty;

        public decimal OpeningBalance { get; set; }

        public decimal NetBalance { get; set; }

        public string TransactionType { get; set; }=string.Empty;

        public decimal TransactionAmount { get; set; }  

    }
    
    
}
