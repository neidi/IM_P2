namespace IM_P2;

public class BankAccount
{
    public string _accountHolderName;
    public Address _accountHolderAddress;
    public decimal _balance;
    
    public void Withdraw(decimal amount)
    {
        _balance -= amount;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }
}