// Modern .NET Core, C# & Enterprise Microservices — lesson m01l03 — Classes, Interfaces, and Object-Oriented C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l03
// © LearnSome.tech
public class ProductService(IProductRepository repository)
{
    public Product? Find(Guid id) => repository.Get(id);

    public Product Add(string name, decimal price)
    {
        var product = new Product { Name = name, Price = price };
        repository.Save(product);
        return product;
    }
}

// The same dependency, written the way it was before C# 12:
public class LegacyProductService
{
    private readonly IProductRepository _repository;

    public LegacyProductService(IProductRepository repository) =>
        _repository = repository;
}
