// Modern .NET Core, C# & Enterprise Microservices — lesson m03l03 — Building Routes with Minimal APIs
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m03l03
// © LearnSome.tech
public static void MapProductEndpoints(this IEndpointRouteBuilder app)
{
    var products = app.MapGroup("/api/products");
    products.MapGet("/{id:int}", async (int id, IProductService service) =>
        await service.FindAsync(id) is { } product
            ? Results.Ok(product)
            : Results.NotFound());
}
