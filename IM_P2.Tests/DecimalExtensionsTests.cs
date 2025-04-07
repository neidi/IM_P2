namespace IM_P2.Tests;

public class DecimalExtensionsTests
{
    [Theory]
    [InlineData(10, "CHF", "10.00 CHF")]
    [InlineData(14.45, "EUR", "14.45 EUR")]
    [InlineData(68, "USD", "68.00 USD")]
    public void ToCurrencyString_ShouldReturnFormattedString(decimal amount, string currency, string expected)
    {
        // Act
        var result = amount.FormatAsCurrency(currency);

        // Assert
        Assert.Equal(expected, result);
    }
}