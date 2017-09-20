using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryExamples
{
    public class BankAccount
    {

        protected double interestRate;
        protected decimal balance;

        public BankAccount(decimal b, double ir)
        {
            this.interestRate = ir;
            this.balance = b;
        }

        public BankAccount(double ir) :
          this(0.0M, ir)
        {
        }

        public virtual decimal Balance
        {
            get { return balance; }
        }

        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        public virtual void AddInterests()
        {
            balance += balance * (Decimal)interestRate;
        }

        public override string ToString()
        {
            return "account holds " +
                  +balance + " kroner";
        }
    }
}
