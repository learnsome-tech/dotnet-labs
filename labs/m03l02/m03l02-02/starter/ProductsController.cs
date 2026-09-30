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
