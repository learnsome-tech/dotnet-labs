public static void MapProductEndpoints(this IEndpointRouteBuilder app)
{
    var products = app.MapGroup("/api/products");
    products.MapGet("/{id:int}", async (int id, IProductService service) =>
        await service.FindAsync(id) is { } product
            ? Results.Ok(product)
            : Results.NotFound());
}
