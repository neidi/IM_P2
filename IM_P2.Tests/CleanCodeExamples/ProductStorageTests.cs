using IM_P2.CleanCodeExamples;

namespace IM_P2.Tests.CleanCodeExamples;

public class ProductStorageTests
{
    [Fact]
    public void SaveProducts_WhenHasTwoProducts_ShouldContainBothProductsInFile()
    {
        // Arrange
        var fakeFile = new FakeFile();
        var sut = new ProductStorage("testfile.txt", fakeFile);
        var products = new List<Product>
        {
            new(Name: "Product1", Price: 10.0m),
            new(Name: "Product2", Price: 20.0m)
        };

        // Act
        sut.SaveProducts(products);

        // Assert
        var fileContent = fakeFile.FileContent.ToString();
        Assert.Contains("Product1,10", fileContent);
        Assert.Contains("Product2,20", fileContent);
    }
}