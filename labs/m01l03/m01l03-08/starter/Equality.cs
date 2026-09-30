var a = new Sku("CAT-1");
var b = new Sku("CAT-1");
Console.WriteLine(ReferenceEquals(a, b));
Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));
Console.WriteLine(a.GetHashCode() == b.GetHashCode());

sealed class Sku(string code)
{
    public string Code { get; } = code;

    public override bool Equals(object? o) => o is Sku s && s.Code == Code;
    public override int GetHashCode() => Code.GetHashCode();
}
