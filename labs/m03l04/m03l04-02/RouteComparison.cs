// Modern .NET Core, C# & Enterprise Microservices — lesson m03l04 — Comparing Controllers and Minimal APIs
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m03l04
// © LearnSome.tech
// Controller: GET /api/products/{id}
[HttpGet("{id:int}")]
public Task<ActionResult<ProductResponse>> Get(int id)

// Minimal API: GET /api/products/{id}
products.MapGet("/{id:int}", (int id, IProductService service) =>
    service.FindAsync(id));
