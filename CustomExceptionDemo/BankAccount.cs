using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class BankAccount
    {
        string accountNumber;
        public string AccountNumber   // property
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        double balance;
        public double Balance   // property
        {
            get { return balance; }
            set { balance = value; }
        }
        string name;
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }

        char transactionType;
        public char TransactionType  // property
        {
            get { return transactionType; }
            set { transactionType = value; }
        }
        int transactionAmount;
        public int TransactionAmount  // property
        {
            get { return transactionAmount; }
            set { transactionAmount = value; }
        }



    }
}
