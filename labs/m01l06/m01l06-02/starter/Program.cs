var kettle = new Product(1, "Kettle");
var same = new Product(1, "Kettle");
var renamed = kettle with { Name = "Teapot" };

Console.WriteLine(kettle);
Console.WriteLine(kettle == same);
Console.WriteLine(object.ReferenceEquals(kettle, same));
Console.WriteLine(renamed);

public record Product(int Id, string Name);
