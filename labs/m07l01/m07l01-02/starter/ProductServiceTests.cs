[Fact]
public async Task Missing_product_returns_not_found()
{
    var repository = Substitute.For<IProductRepository>();
    repository.FindAsync(7, Arg.Any<CancellationToken>())
        .Returns((Product?)null);

    var result = await new ProductService(repository).FindAsync(7);

    Assert.Null(result);
}
