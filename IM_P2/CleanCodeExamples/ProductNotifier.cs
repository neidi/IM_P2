using System.Net.Mail;

namespace IM_P2.CleanCodeExamples;

public class ProductNotifier
{
    private readonly string _smtpHost;

    public ProductNotifier(string smtpHost)
    {
        _smtpHost = smtpHost;
    }

    public void Notify(Product product)
    {
        var message = new MailMessage("system@example.com", "admin@example.com")
        {
            Subject = "New Product",
            Body = $"Product: {product.Name}, Price: {product.Price}"
        };

        using var smtp = new SmtpClient(_smtpHost);
        smtp.Send(message);
    }
}