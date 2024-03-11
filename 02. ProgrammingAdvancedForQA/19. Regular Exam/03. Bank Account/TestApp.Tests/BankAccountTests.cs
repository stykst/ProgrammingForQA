using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {// Arrange
        var initialBalance = 100.00;

        // Act
        var account = new BankAccount(initialBalance);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(initialBalance));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        var initialBalance = 100.00;
        var depositAmount = 50.00;
        var account = new BankAccount(initialBalance);

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(initialBalance + depositAmount));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        var initialBalance = 100.00;
        var negativeDeposit = -50.00;
        var account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Deposit(negativeDeposit));
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        var initialBalance = 100.00;
        var withdrawAmount = 30.00;
        var account = new BankAccount(initialBalance);

        // Act
        account.Withdraw(withdrawAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(initialBalance - withdrawAmount));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        var initialBalance = 100;
        var negativeWithdraw = -30;
        var account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(negativeWithdraw));
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        var initialBalance = 100;
        var withdrawAmount = 150; // Greater than initial balance
        var account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawAmount));
    }
}
