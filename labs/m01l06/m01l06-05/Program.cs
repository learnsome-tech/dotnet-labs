// Modern .NET Core, C# & Enterprise Microservices — lesson m01l06 — Records, Pattern Matching, and Modern C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l06
// © LearnSome.tech
foreach (var status in new[] { "pending", "shipped", "lost", "" })
    Console.WriteLine(Label(status));

static string Label(string status) => status switch
{
    "pending" => "Waiting for payment",
    "shipped" or "in transit" => "On its way",
    "" => "No status recorded",
    _ => $"Unknown status: {status}",
};
