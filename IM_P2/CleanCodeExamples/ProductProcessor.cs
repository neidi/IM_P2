namespace IM_P2.CleanCodeExamples;

public class ProductProcessor
{
    private readonly ProductStorage _storage;
    private readonly ProductNotifier _notifier;

    public ProductProcessor(ProductStorage storage, ProductNotifier notifier)
    {
        _storage = storage;
        _notifier = notifier;
    }

    public void Process(IEnumerable<string> rawData)
    {
        var products = ProductParser.ParseRawData(rawData).ToArray();
        _storage.SaveProducts(products);

        foreach (var product in products)
        {
            _notifier.Notify(product);
        }
    }
}