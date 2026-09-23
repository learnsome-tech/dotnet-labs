// Modern .NET Core, C# & Enterprise Microservices — lesson m01l05 — Async and Await: Managing Concurrency
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l05
// © LearnSome.tech
using System.Diagnostics;

static async Task<int> DelayAsync(int id)
{
    await Task.Delay(1000);
    return id;
}

var clock = Stopwatch.StartNew();
foreach (var id in new[] { 1, 2, 3 })
    await DelayAsync(id);
Console.WriteLine($"sequential: {clock.Elapsed.TotalSeconds:F0}s");

clock.Restart();
await Task.WhenAll(DelayAsync(1), DelayAsync(2), DelayAsync(3));
Console.WriteLine($"parallel:   {clock.Elapsed.TotalSeconds:F0}s");
