// Modern .NET Core, C# & Enterprise Microservices — lesson m01l03 — Classes, Interfaces, and Object-Oriented C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l03
// © LearnSome.tech
public static class CatalogExtensions
{
    public static IServiceCollection AddCatalogPlatform(
        this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, SqlProductRepository>();
        services.AddScoped<ProductService>();
        return services;
    }

    public static decimal WithVat(this decimal amount, decimal rate) =>
        decimal.Round(amount * (1 + rate), 2);
}

// Both read as though they were instance methods:
// builder.Services.AddCatalogPlatform();
// var gross = 24.99m.WithVat(0.20m);   // 29.99
