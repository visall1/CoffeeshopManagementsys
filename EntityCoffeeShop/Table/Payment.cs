public class Payment
{
    public int PaymentId { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }

    public decimal Amount { get; set; }
    public string Method { get; set; }  // e.g., Cash, Card
    public DateTime PaidAt { get; set; }
}
