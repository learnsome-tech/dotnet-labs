object boxed = 42;
if (boxed is int n)
    Console.WriteLine($"the type pattern unboxed: {n}");

var kettle = new Product(1, "Kettle", 24.99m);
Console.WriteLine(kettle is { Price: > 20m and < 50m });
Console.WriteLine(kettle is not { Name: "Teapot" });

int[] ids = [1, 2, 3];
Console.WriteLine(ids is [1, .., 3]);
Console.WriteLine(ids is [var first, ..] ? first : 0);

public record Product(int Id, string Name, decimal Price);
