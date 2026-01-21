using System;
using System.Collections.Generic;

namespace QABank
{
    public enum AccountType
    {
        Deposit, Current
    }
    public class Account
    {
        // We would have getters/setters for these but left out to minimise the code
        private string firstname, lastname, address;
        private int accountNumber;
        private double interest;
        private double overdraftLimit;
        private double balance;
        private AccountType accountType;
        private List<Payee> directDebits = new List<Payee>();
        private List<Payee> standingOrders = new List<Payee>();


        public void WithDraw(double amount)
        {
            if (amount > balance && accountType == AccountType.Deposit)
                throw new Exception("Insufficient Funds");
            balance -= amount;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void AddInterestToAccount()
        { // used where account is a deposit acct
            balance += balance * 0.0001;
        }
        // used where account is current account
        public bool IsOverDrawn()
        {
            return false;
        }
        // used where account is current account
        public void SetOverdraftLimit(double overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }
        // used where account is current account
        public void ProcessDirectDebits()
        {
            foreach (Payee payee in directDebits)
            {
            }
        }
        // used where account is current account
        public void ProcessStandingOrders()
        {
            foreach (Payee payee in standingOrders)
            {
            }
        }
    }
}
