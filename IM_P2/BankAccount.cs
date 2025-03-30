namespace IM_P2;

public class BankAccount
{
    public string _accountHolderName;
    public Address _accountHolderAddress;
    public decimal _balance;

    public BankAccount(string accountHolderName, Address address)
    {
        throw new NotImplementedException();
    }

    public object Balance { get; set; }
    public object AccountHolderName { get; set; }
    public object AccountHolderAddress { get; set; }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }
}