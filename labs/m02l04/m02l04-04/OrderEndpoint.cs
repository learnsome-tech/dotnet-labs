// Modern .NET Core, C# & Enterprise Microservices — lesson m02l04 — The Dependency Injection Container: Scopes and Lifetimes
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m02l04
// © LearnSome.tech
public sealed class OrderEndpoint(IOrderReader orders, IClock clock)
{
    public async Task<IResult> Get(int id)
    {
        var order = await orders.FindAsync(id);
        return order is null ? Results.NotFound() : Results.Ok(order);
    }
}
