// Modern .NET Core, C# & Enterprise Microservices — lesson m01l04 — Collections, Generics, and LINQ
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l04
// © LearnSome.tech
Console.WriteLine("before");

foreach (int n in Countdown(3))
{
    Console.WriteLine(n);
    if (n == 2) break;
}

Console.WriteLine("after");

IEnumerable<int> Countdown(int from)
{
    Console.WriteLine("entered");
    for (int i = from; i > 0; i--)
        yield return i;
}
