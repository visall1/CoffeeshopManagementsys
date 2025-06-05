public class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; }
    public decimal Price { get; set; }

    public byte[]? Image { get; set; }  // Stores image as binary data (nullable)

    public int CategoryId { get; set; }
    public Category Categories { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
}
