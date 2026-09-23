// Modern .NET Core, C# & Enterprise Microservices — lesson m01l02 — The C# Language: Types, Variables, and Flow Control
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l02
// © LearnSome.tech
var a = new Size { Width = 10 };
var b = a;
b.Width = 99;
Console.WriteLine($"struct Size:  a is {a.Width}, b is {b.Width}");

var x = new Box { Width = 10 };
var y = x;
y.Width = 99;
Console.WriteLine($"class Box:    x is {x.Width}, y is {y.Width}");

struct Size { public int Width; }
class Box { public int Width; }
