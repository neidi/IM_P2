using System.Net.Mail;

namespace IM_P2.CleanCodeExamples;

public class ProductProcessor
{
    public void Notify()
    {
        var products = PrepareProductList();

        foreach (var product in products)
        {
            var (productName, productPrice) = CreateProducts(product);
            AppendToFile(productName, productPrice);
            NotifyAboutNewProduct(productName, productPrice);
        }
    }

    private static List<string> PrepareProductList()
    {
        return ["Apfel,1.2", "Banane,0.8", "Keks,1.5"];
    }

    private static (string ProductName, double ProductPrice) CreateProducts(string product)
    {
        var splitProduct = product.Split(',');
        return (productName: splitProduct[0], productPrice: double.Parse(splitProduct[1]));
    }

    private static void AppendToFile(string productName, double productPrice)
    {
        File.AppendAllText("products.csv", productName + "," + productPrice + Environment.NewLine);
    }

    private static void NotifyAboutNewProduct(string productName, double productPrice)
    {
        var message = new MailMessage("system@example.com", "admin@example.com")
        {
            Subject = "New Product",
            Body = $"Product: {productName}, Price: {productPrice}"
        };
        new SmtpClient("smtp.example.com").Send(message);
    }
}