using IM_P2.CleanCodeExamples;
using Shouldly;

namespace IM_P2.Tests.CleanCodeExamples;

public class ProductNotifierTests
{
    [Fact]
    public void Notify_WhenNotified_MailIsSent()
    {
        // Arrange
        var product = new Product("TestProduct", 19.99m);
        var smtpClientFake = new SmtpClientFake();
        var notifier = new ProductNotifier(smtpClientFake);
        
        // Act
        notifier.Notify(product);
        
        // Assert
        var lastSent = smtpClientFake.Messages.Last();
        lastSent.Body.ShouldBe("Product: TestProduct, Price: 19.99");
        lastSent.Subject.ShouldBe("New Product");
    }
}