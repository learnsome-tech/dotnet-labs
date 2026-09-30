public static class Queries
{
    public static IReadOnlyList<string> Cheap(IEnumerable<Product> all) =>
        all.Where(p => p.Price < 20m)
           .OrderBy(p => p.Name)
           .Select(p => p.Name)
           .ToList();

    public static Product Require(IEnumerable<Product> all, string name) =>
        all.First(p => p.Name == name);

    public static Product? Find(IEnumerable<Product> all, string name) =>
        all.FirstOrDefault(p => p.Name == name);
}
