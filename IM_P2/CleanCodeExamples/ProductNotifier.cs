using System.Net.Mail;

namespace IM_P2.CleanCodeExamples;

public class ProductNotifier
{
    private readonly ISmtpClient _smtpClient;

    public ProductNotifier(ISmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public void Notify(Product product)
    {
        var message = new MailMessage("system@example.com", "admin@example.com")
        {
            Subject = "New Product",
            Body = $"Product: {product.Name}, Price: {product.Price}"
        };
        
        _smtpClient.Send(message);
    }
}