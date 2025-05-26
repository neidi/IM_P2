namespace IM_P2.CleanCodeExamples;

public class ProductStorage
{
    private readonly string _filePath;

    public ProductStorage(string filePath)
    {
        _filePath = filePath;
    }

    public void SaveProducts(IEnumerable<Product> products)
    {
        foreach (var product in products)
        {
            File.AppendAllText(_filePath, $"{product.Name},{product.Price}{Environment.NewLine}");
        }
    }
}