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
