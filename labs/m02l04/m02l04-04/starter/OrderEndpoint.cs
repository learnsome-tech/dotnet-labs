public sealed class OrderEndpoint(IOrderReader orders, IClock clock)
{
    public async Task<IResult> Get(int id)
    {
        var order = await orders.FindAsync(id);
        return order is null ? Results.NotFound() : Results.Ok(order);
    }
}
