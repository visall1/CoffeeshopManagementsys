public class Customer
{
    public int CustomerId { get; set; }
    public string? Name { get; set; } // Optional for walk-ins
    public ICollection<Order> Orders { get; set; }
}
