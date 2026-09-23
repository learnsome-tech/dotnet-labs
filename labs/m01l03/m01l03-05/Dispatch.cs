// Modern .NET Core, C# & Enterprise Microservices — lesson m01l03 — Classes, Interfaces, and Object-Oriented C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l03
// © LearnSome.tech
Carrier c = new Overnight();
Console.WriteLine(c.Name);
Console.WriteLine(c.Quote(3m));
Console.WriteLine(new Ground().Quote(3m));

abstract class Carrier
{
    public abstract string Name { get; }
    public virtual decimal Quote(decimal kg) => 4.50m + kg;
}

sealed class Overnight : Carrier
{
    public override string Name => "Overnight";
    public override decimal Quote(decimal kg) => 12.00m + kg * 2;
}

sealed class Ground : Carrier
{
    public override string Name => "Ground";
}
