namespace IM_P2.Tests;

public class AddressTest
{
    [Fact]
    public void AddressRecord_ShouldActLikeARecord()
    {
        // Arrange
        var gibzAddress = new Address(Street: "Baarerstrasse", Number: 100, Zip: 6301, City: "Zug");

        // Act
        var anotherAddress = gibzAddress with { Street = "Untermüli", Number = 5, Zip = 6302 };

        // Assert
        Assert.Equal("Baarerstrasse", gibzAddress.Street);
        Assert.Equal(100, gibzAddress.Number);
        Assert.Equal(6301, gibzAddress.Zip);
        Assert.Equal("Zug", gibzAddress.City);
        Assert.Equal("Untermüli", anotherAddress.Street);
        Assert.Equal(5, anotherAddress.Number);
        Assert.Equal(6302, anotherAddress.Zip);
        Assert.Equal("Zug", anotherAddress.City);
    }
}