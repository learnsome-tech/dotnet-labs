// Modern .NET Core, C# & Enterprise Microservices — lesson m01l02 — The C# Language: Types, Variables, and Flow Control
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l02
// © LearnSome.tech
double bad = 0.1 + 0.2;
decimal good = 0.1m + 0.2m;

Console.WriteLine(bad);
Console.WriteLine(good);
Console.WriteLine(bad == 0.3);
Console.WriteLine(good == 0.3m);

decimal price = 19.90m;
Console.WriteLine(price * 3);
