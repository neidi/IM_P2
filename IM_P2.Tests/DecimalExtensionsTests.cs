namespace IM_P2.Tests;

public class DecimalExtensionsTests
{
    [Theory]
    [InlineData(10M, "CHF", "10.00 CHF")]
    [InlineData(14M, "EUR", "14.00 EUR")]
    [InlineData(68M, "USD", "68.00 USD")]
    public void ToCurrencyString_ShouldReturnFormattedString(decimal amount, string currency, string expected)
    {
        // Act
        var result = amount.FormatAsCurrency(currency);

        // Assert
        Assert.Equal(expected, result);
    }
}