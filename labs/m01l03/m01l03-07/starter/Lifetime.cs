Console.WriteLine("work starting");
using var work = new UnitOfWork("orders");
work.Save();
Console.WriteLine("work finished");

sealed class UnitOfWork(string name) : IDisposable
{
    public void Save() => Console.WriteLine($"saving {name}");

    public void Dispose() => Console.WriteLine($"disposing {name}");
}
