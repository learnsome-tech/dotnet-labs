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
