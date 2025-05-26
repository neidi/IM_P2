namespace IM_P2.CleanCodeExamples;

public static class ProductParser
{
    public static IEnumerable<Product> ParseRawData(IEnumerable<string> lines) => lines
        .Select(line => line.Split(','))
        .Select(parts => new Product(Name: parts[0], Price: decimal.Parse(parts[1])));
}