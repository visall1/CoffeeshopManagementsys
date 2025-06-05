public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }  // e.g., Beverage, Dessert, Sandwich
    public ICollection<Product> Products { get; set; }
}
