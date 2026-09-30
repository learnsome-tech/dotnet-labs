public class Product
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public Guid Id { get; init; } = Guid.NewGuid();
    public int Units { get; private set; }

    public bool InStock => Units > 0;

    public void Receive(int units) => Units += units;
}
