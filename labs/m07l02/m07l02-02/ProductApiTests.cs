// Modern .NET Core, C# & Enterprise Microservices — lesson m07l02 — Integration Testing with WebApplicationFactory
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m07l02
// © LearnSome.tech
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
