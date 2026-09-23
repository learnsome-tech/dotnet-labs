// Modern .NET Core, C# & Enterprise Microservices — lesson m04l01 — Entity Framework Core: Code First and Migrations
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l01
// © LearnSome.tech
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
