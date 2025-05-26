using IM_P2.CleanCodeExamples;

namespace IM_P2.Tests.CleanCodeExamples;

public class ProductStorageTests
{
    [Fact]
    public void SaveProducts_WhenAreTwoProducts_FileContainsBothProducts()
    {
        // Arrange
        var filePath = "test_products.txt";
        var storage = new ProductStorage(filePath);
        var products = new List<Product>
        {
            new Product("Product1", 10.99m),
            new Product("Product2", 20.49m)
        };

        // Act
        storage.SaveProducts(products);

        // Assert
        var fileContent = File.ReadAllLines(filePath);
        Assert.Equal(2, fileContent.Length);
        Assert.Contains("Product1,10.99", fileContent);
        Assert.Contains("Product2,20.49", fileContent);

        // Clean up
        File.Delete(filePath);
    }
}