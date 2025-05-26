using IM_P2.CleanCodeExamples;

namespace IM_P2.Tests.CleanCodeExamples;

public class ProductNotifierTests
{
    [Fact]
    public void Notify_WhenNotified_MailIsSent()
    {
        // Arrange
        var product = new Product("TestProduct", 19.99m);
        var notifier = new ProductNotifier("smtp.example.com");
        
        // Act
        notifier.Notify(product);
        
        // Assert
        // TODO: check if the notification was sent correctly
    }
}