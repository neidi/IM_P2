namespace IM_P2;

public class BankAccount
{
    public string _accountHolderName;
    public Address _accountHolderAddress;
    public decimal _balance;

    public BankAccount(string accountHolderName, Address address)
    {
        AccountHolderName = accountHolderName;
        AccountHolderAddress = address;
        _balance = 0M;
    }

    public decimal Balance
    {
        get { return _balance; }
    }
    public string AccountHolderName { get; }
    public Address AccountHolderAddress { get; }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
    }

    public void Deposit(decimal amount)
    {
        if (amount == 0M)
        {
            throw new DepositImpossibleException();
        }

        _balance += amount;
    }
}