// Modern .NET Core, C# & Enterprise Microservices — lesson m01l02 — The C# Language: Types, Variables, and Flow Control
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l02
// © LearnSome.tech
static class Bands
{
    public static string Statement(int qty)
    {
        switch (qty)
        {
            case 0: return "none";
            case 1: return "one";
            default: return "many";
        }
    }

    public static string Expression(int qty) => qty switch
    {
        0 => "none",
        1 => "one",
        _ => "many",
    };
}
