// Modern .NET Core, C# & Enterprise Microservices — lesson m01l05 — Async and Await: Managing Concurrency
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l05
// © LearnSome.tech
public sealed class Wrong(CatalogService catalog)
{
    // 1. Blocking on a task: a pool thread waits on a pool thread.
    public Product? Get(int id)
        => catalog.GetProductAsync(id, default).Result;

    // 2. async void: no task, so nothing can ever catch this throw.
    public async void Refresh(int id)
        => await catalog.GetProductAsync(id, default);

    // 3. Serial awaits over independent work: the latencies add up.
    public async Task<Product?[]> GetAllAsync(int[] ids,
        CancellationToken ct)
    {
        var found = new List<Product?>();
        foreach (var id in ids)
            found.Add(await catalog.GetProductAsync(id, ct));
        return found.ToArray();
    }
}
