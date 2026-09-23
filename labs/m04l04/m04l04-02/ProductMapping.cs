// Modern .NET Core, C# & Enterprise Microservices — lesson m04l04 — Manual Object Mapping
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l04
// © LearnSome.tech
public static ProductResponse ToResponse(this Product product)
    => new(
        product.Id,
        product.Name,
        product.Price);

public static Product ToEntity(this CreateProductRequest request)
    => new()
    {
        Name = request.Name,
        Price = request.Price
    };
