using IM_P2.CleanCodeExamples;
using Shouldly;

namespace IM_P2.Tests.CleanCodeExamples;

public class ProductProcessorTests
{
    [Fact]
    public void Process_WhenValidData_ProductsSavedAndNotified()
    {
        var fakeFile = new FakeFile();
        // Arrange
        var rawData = new List<string>
        {
            "Product1,10.00",
            "Product2,20.00"
        };
        const string filename = "test_products.txt";
        var smtpClientFake = new SmtpClientFake();
        var processor = new ProductProcessor(new ProductStorage(filename, fakeFile),
            new ProductNotifier(smtpClientFake));

        // Act
        processor.Process(rawData);

        // Assert
        fakeFile.FileContent.ToString().ShouldBe("Product1,10.00\nProduct2,20.00\n");
        var firstProductMessage = smtpClientFake.Messages.First();
        firstProductMessage.Subject.ShouldBe("New Product");
        firstProductMessage.Body.ShouldBe("Product: Product1, Price: 10.00");
        var secondProduct = smtpClientFake.Messages.Last();
        secondProduct.Subject.ShouldBe("New Product");
        secondProduct.Body.ShouldBe("Product: Product2, Price: 20.00");
    }
}