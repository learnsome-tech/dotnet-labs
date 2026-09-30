public sealed class ProductApiTests
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient client;

    public ProductApiTests(WebApplicationFactory<Program> factory)
        => client = factory.CreateClient();

    [Fact]
    public async Task Missing_product_is_not_found()
    {
        var response = await client.GetAsync("/api/products/7");
        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}
