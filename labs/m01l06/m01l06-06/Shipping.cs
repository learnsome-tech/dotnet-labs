// Modern .NET Core, C# & Enterprise Microservices — lesson m01l06 — Records, Pattern Matching, and Modern C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l06
// © LearnSome.tech
namespace Catalog.Fulfilment;

public enum Status { Pending, Shipped, Delivered }

public static class Shipping
{
    // warning CS8509: the switch expression does not handle
    // all possible values - Status.Delivered has no arm.
    public static string Label(Status status) => status switch
    {
        Status.Pending => "Waiting",
        Status.Shipped => "On its way",
    };
}
