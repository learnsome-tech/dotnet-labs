// Controller: GET /api/products/{id}
[HttpGet("{id:int}")]
public Task<ActionResult<ProductResponse>> Get(int id)

// Minimal API: GET /api/products/{id}
products.MapGet("/{id:int}", (int id, IProductService service) =>
    service.FindAsync(id));
