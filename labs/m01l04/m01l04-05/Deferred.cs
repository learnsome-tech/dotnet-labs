// Modern .NET Core, C# & Enterprise Microservices — lesson m01l04 — Collections, Generics, and LINQ
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l04
// © LearnSome.tech
int[] prices = [12, 40, 7, 95];

IEnumerable<int> big = prices.Where(p =>
{
    Console.WriteLine($"testing {p}");
    return p > 10;
});

Console.WriteLine("query built");

foreach (int p in big)
{
    Console.WriteLine($"kept {p}");
}
