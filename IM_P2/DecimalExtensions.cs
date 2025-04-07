namespace IM_P2;

public static class DecimalExtensions
{
    public static string FormatAsCurrency(this decimal amount, string currency)
    {
        return $"{amount:0.00} {currency}";
    }
}