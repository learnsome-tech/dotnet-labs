// Modern .NET Core, C# & Enterprise Microservices — lesson m01l05 — Async and Await: Managing Concurrency
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l05
// © LearnSome.tech
static async IAsyncEnumerable<string> ReadPagesAsync()
{
    string[] pages = ["alpha", "beta", "gamma"];
    foreach (var page in pages)
    {
        await Task.Delay(50);
        yield return page;
    }
}

await foreach (var page in ReadPagesAsync())
{
    Console.WriteLine($"received {page}");
}
