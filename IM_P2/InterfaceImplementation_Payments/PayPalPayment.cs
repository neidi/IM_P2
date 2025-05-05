namespace IM_P2.InterfaceImplementation2;

class PayPalPayment : IPayment
{
    public string ProcessPayment(decimal amount)
        => $"PayPal-Zahlung: {amount} €";
}