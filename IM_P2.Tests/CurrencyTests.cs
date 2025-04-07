using BM_P2_Lib;

namespace IM_P2.Tests;

public class CurrencyTests
{
    [Theory]
    [InlineData(12, "CHF", "12.00 CHF")]
    [InlineData(16.93, "EUR", "16.93 EUR")]
    [InlineData(7125.2, "GBP", "7125.20 GBP")]
    [InlineData(89.70, "USD", "89.70 USD")]
    public void CurrencyShouldHaveExtensionMethod(decimal currencyAmount, string currencyCode, string expected)
    {
        // Arrange
        var currency = new Currency(currencyAmount, currencyCode);

        // Act
        var formatAsString = currency.FormatAsString();

        // Assert
        Assert.Equal(expected, formatAsString);
    }
}