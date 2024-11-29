using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.Models
{
    [Serializable]
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string accountName, string password)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            Password = password;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}