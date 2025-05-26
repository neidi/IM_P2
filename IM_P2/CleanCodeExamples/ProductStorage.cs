namespace IM_P2.CleanCodeExamples;

public class ProductStorage
{
    private readonly string _filePath;
    private readonly IFile _file;

    public ProductStorage(string filePath, IFile file)
    {
        _filePath = filePath;
        _file = file;
    }

    public void SaveProducts(IEnumerable<Product> products)
    {
        foreach (var product in products)
        {
            _file.AppendAllText(_filePath, $"{product.Name},{product.Price}{Environment.NewLine}");
        }
    }
}