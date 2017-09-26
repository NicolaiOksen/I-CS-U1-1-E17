using System;

public class BankAccount {

   private double interestRate;
   private string owner;
   private decimal balance;

   public BankAccount(string owner):
     this(owner, 0.0, 0.0M) {
   }

   public BankAccount(string owner, double interestRate):
     this(owner, interestRate, 0.0M) {
   }

   public BankAccount(string owner, double interestRate, 
                      decimal balance) {
      this.interestRate = interestRate;
      this.owner = owner; 
      this.balance = balance;
   }   

   public decimal Balance () {
      return balance;
   }

   public void Withdraw (decimal amount) {
      balance -= amount;
   }

   public void Deposit (decimal amount) {
      balance += amount;
   }

   public void AddInterests() {
      balance = balance + balance * (decimal)interestRate;
   }    

   public override string ToString() {
      return owner + "'s account holds " +
            + balance + " kroner";
   }
} 