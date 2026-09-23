// Modern .NET Core, C# & Enterprise Microservices — lesson m04l03 — The Repository Pattern
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l03
// © LearnSome.tech
public interface IProductRepository
{
    Task<Product?> FindAsync(int id, CancellationToken cancellationToken);
    Task<IReadOnlyList<Product>> SearchAsync
        string term, CancellationToken cancellationToken);
    Task AddAsync(Product product, CancellationToken cancellationToken);
}
