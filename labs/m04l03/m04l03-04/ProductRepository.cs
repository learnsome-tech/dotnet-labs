// Modern .NET Core, C# & Enterprise Microservices — lesson m04l03 — The Repository Pattern
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l03
// © LearnSome.tech
public async Task AddAsync(Product product, CancellationToken token)
{
    await db.Products.AddAsync(product, token);
    await db.SaveChangesAsync(token);
    Console.WriteLine("saved");
}
