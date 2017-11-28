using System;
using NUnit.Framework

public class BankAccount
{

    private double interestRate;
    private string owner;
    private double balance;

    public BankAccount(string owner) :
        this(owner, 0.0, 0.0)
    {
    }

    public BankAccount(string owner, double balance) :
        this(owner, balance, 0.0)
    {
    }

    public BankAccount(string owner, double balance, double interestRate)
    {
        this.interestRate = interestRate;
        this.owner = owner;
        this.balance = balance;
    }

    public double Balance => balance;

    public double InterestRate => interestRate

    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void AddInterests()
    {
        balance = balance + balance * interestRate;
    }

    public override string ToString()
    {
        return owner + "'s account holds " +
                +balance + " kroner";
    }
}


[TestFixture]
public class BankAccountTest
{

    BankAccount ba1, ba2, ba3;
    const double tol = 0.000001;

    [SetUp]
    public void Init()
    {
        ba1 = new BankAccount("Peter");
        ba2 = new BankAccount("Jens", 1000.0);
        ba3 = new BankAccount("Martin", 2000.0, 0.03);
    }

    [Test]
    public void InitTest()
    {
        Assert.AreEqual(0.0, ba1.Balance, tol, "ba1 init");
        Assert.AreEqual(1000.0, ba2.Balance, tol, "ba2 init balance");
        Assert.AreEqual(2000.0, ba3.Balance, tol, "ba3 init balance");

        Assert.AreEqual(0.0, ba1.InterestRate, tol, "ba1 interest rate");
        Assert.AreEqual(0.0, ba2.InterestRate, tol, "ba2 interest rate");
        Assert.AreEqual(0.03, ba3.InterestRate, tol, "ba3 interest rate");
    }

    [Test]
    public void DepositTest()
    {
        ba1.Deposit(100); ba2.Deposit(100); ba3.Deposit(100);
        Assert.AreEqual(100.0, ba1.Balance, tol, "ba1 deposit");
        Assert.AreEqual(1100.0, ba2.Balance, tol, "ba2 deposit");
        Assert.AreEqual(2100.0, ba3.Balance, tol, "ba3 deposit");
    }

    [Test]
    public void WithdrawTest()
    {
        ba1.Withdraw(100.0); ba2.Withdraw(100.0); ba3.Withdraw(100.0);
        Assert.AreEqual(-100.0, ba1.Balance, tol, "ba1 withdraw");
        Assert.AreEqual(900.0, ba2.Balance, tol, "ba2 withdraw");
        Assert.AreEqual(1900.0, ba3.Balance, tol, "ba3 withdraw");
    }

    [Test]
    public void AddInterestsTest()
    {
        ba1.AddInterests(); ba2.AddInterests(); ba3.AddInterests();
        Assert.AreEqual(0.0, ba1.Balance, tol, "ba1 add interest");
        Assert.AreEqual(1000.0, ba2.Balance, tol, "ba2 add interest");
        Assert.AreEqual(2060.0, ba3.Balance, tol, "ba3 add interest");
    }
}