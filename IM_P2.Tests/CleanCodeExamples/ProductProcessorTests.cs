using IM_P2.CleanCodeExamples;

namespace IM_P2.Tests.CleanCodeExamples;

public class ProductProcessorTests
{
    [Fact]
    public void Process_WhenValidData_ProductsSavedAndNotified()
    {
        // Arrange
        var rawData = new List<string>
        {
            "Product1,10.00",
            "Product2,20.00"
        };
        const string filename = "test_products.txt";
        var processor = new ProductProcessor(new ProductStorage(filename),
                                             new ProductNotifier("smtp.example.com"));
        
        // Act
        processor.Process(rawData);
        
        // Assert
        var fileContent = File.ReadAllLines(filename);
    }
}