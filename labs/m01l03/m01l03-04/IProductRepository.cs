// Modern .NET Core, C# & Enterprise Microservices — lesson m01l03 — Classes, Interfaces, and Object-Oriented C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l03
// © LearnSome.tech
public interface IProductRepository
{
    Product? Get(Guid id);
    void Save(Product product);
    IReadOnlyList<Product> All();

    bool Exists(Guid id) => Get(id) is not null;
}

// Module two registers the contract, not the class:
// builder.Services.AddScoped<IProductRepository, SqlProductRepository>();
