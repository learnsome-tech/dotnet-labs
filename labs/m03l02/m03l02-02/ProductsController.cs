// Modern .NET Core, C# & Enterprise Microservices — lesson m03l02 — Building Routes with Controllers
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m03l02
// © LearnSome.tech
[ApiController]
[Route("api/products")]
public sealed class ProductsController : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductResponse>> Get(int id)
        => await products.FindAsync(id) is { } product
            ? Ok(product)
            : NotFound();
}
