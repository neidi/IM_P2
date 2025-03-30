namespace IM_P2;

public class BankAccount
{
    public BankAccount(string accountHolderName, Address address)
    {
        AccountHolderName = accountHolderName;
        AccountHolderAddress = address;
        Balance = 0M;
    }

    public decimal Balance { get; private set; }

    public string AccountHolderName { get; }
    public Address AccountHolderAddress { get; }

    public void Withdraw(decimal amount)
    {
        if (Balance == 0M)
        {
            throw new WithdrawalImpossibleException();
        }

        Balance -= amount;
    }

    public void Deposit(decimal amount)
    {
        if (amount == 0M)
        {
            throw new DepositImpossibleException();
        }

        Balance += amount;
    }
}