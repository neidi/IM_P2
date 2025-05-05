namespace IM_P2.InterfaceImplementation2;

public class Bank
{
    void ExecutePayment(IPayment method)
    {
        Console.WriteLine(method.ProcessPayment(100));
    }
}