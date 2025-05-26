using IM_P2.CleanCodeExamples;
using Shouldly;

namespace IM_P2.Tests.CleanCodeExamples;

public class ProductParserTests
{
    [Fact]
    public void ParseRawData_WhenValidInput_ReturnsProducts()
    {
        // Arrange
        var rawData = new List<string>
        {
            "Product1,10.99",
            "Product2,20.50"
        };

        // Act
        var products = ProductParser.ParseRawData(rawData).ToList();

        // Assert
        Assert.Equal(2, products.Count);
        Assert.Equal("Product1", products[0].Name);
        Assert.Equal(10.99m, products[0].Price);
        Assert.Equal("Product2", products[1].Name);
        Assert.Equal(20.50m, products[1].Price);
    }
}