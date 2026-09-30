public sealed class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Price { get; set; }
}

public sealed class CatalogContext(DbContextOptions<CatalogContext> options)
    : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
}
