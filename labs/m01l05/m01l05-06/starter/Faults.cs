static async Task FailAsync(string name)
{
    await Task.Yield();
    throw new InvalidOperationException($"{name} failed");
}

var all = Task.WhenAll(FailAsync("first"), FailAsync("second"));

try
{
    await all;
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"await threw: {ex.Message}");
}

Console.WriteLine($"faults held: {all.Exception!.InnerExceptions.Count}");
