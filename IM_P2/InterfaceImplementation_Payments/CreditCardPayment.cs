namespace IM_P2.InterfaceImplementation2;

class CreditCardPayment : IPayment
{
    public string ProcessPayment(decimal amount)
        => $"Kreditkartenzahlung: {amount} €";
}