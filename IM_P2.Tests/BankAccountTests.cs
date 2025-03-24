using System.Reflection;
using Shouldly;

namespace IM_P2.Tests;

public class BankAccountTests
{
    [Fact]
    public void BankAccount_WhenCorrectlyImplemented_ShouldNotExposePublicFields()
    {
        var publicFields = typeof(BankAccount).GetFields(BindingFlags.Public | BindingFlags.Instance);

        publicFields.ShouldNotContain(info => info.Name == "accountHolderName");
        publicFields.ShouldNotContain(info => info.Name == "balance");
        publicFields.ShouldBeEmpty();
    }

    [Fact]
    public void
        Creation_WhenCorrectlyImplemented_ShouldExposeConstructorWhichTakesArgumentsForAccountHolderNameAndAddress()
    {
        var constructorInfo = typeof(BankAccount).GetConstructor(BindingFlags.Public | BindingFlags.Instance,
            [typeof(string), typeof(Address)]);

        constructorInfo.ShouldNotBeNull();
    }

    [Fact]
    public void Creation_WhenAccountIsCreated_HasBalanceZeroAndPropertiesAreAsExpected()
    {
        const string accountHolderName = "Max Muster";
        var accountHolderAddress = new Address("Musterstrasse", "17a", "4800", "Zofingen");
        var bankAccount = new BankAccount(accountHolderName, accountHolderAddress);

        bankAccount.AccountHolderName.ShouldBe(accountHolderName);
        bankAccount.AccountHolderAddress.ShouldBe(accountHolderAddress);
        bankAccount.Balance.ShouldBe(0M);
    }

    [Fact]
    public void Withdraw_WhenAccountHasBalanceZero_ShouldThrowException()
    {
        var bankAccount = new BankAccount("Max Muster", new Address("Musterstrasse", "17a", "4800", "Zofingen"));

        Action act = () => bankAccount.Withdraw(10);

        act.ShouldThrow<WithdrawalImpossibleException>();
    }


    [Fact]
    public void Withdraw_WhenAmountIsZero_ShouldThrowException()
    {
        var bankAccount = new BankAccount("Max Muster", new Address("Musterstrasse", "17a", "4800", "Zofingen"));

        Action act = () => bankAccount.Withdraw(0);

        act.ShouldThrow<WithdrawalImpossibleException>();
    }

    [Fact]
    public void Withdraw_WhenAccountHasBalanceGreaterOrEqualToWithdrawalAmount_ShouldBePossible()
    {
        var bankAccount = new BankAccount("Max Muster", new Address("Musterstrasse", "17a", "4800", "Zofingen"));
        bankAccount.Deposit(150);

        bankAccount.Withdraw(70);

        bankAccount.Balance.ShouldBe(80);
    }

    [Fact]
    public void Deposit_WhenAccountIsOpen_BalanceIsAdjusted()
    {
        var bankAccount = new BankAccount("Max Muster", new Address("Musterstrasse", "17a", "4800", "Zofingen"));

        bankAccount.Deposit(10);

        bankAccount.Balance.ShouldBe(10);
    }

    [Fact]
    public void Deposit_WhenAmountIsZero_ThrowsException()
    {
        var bankAccount = new BankAccount("Max Muster", new Address("Musterstrasse", "17a", "4800", "Zofingen"));

        const decimal amountZero = 0;
        Action act = () => bankAccount.Deposit(amountZero);

        act.ShouldThrow<DepositImpossibleException>();
    }
}