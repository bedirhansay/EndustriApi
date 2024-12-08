namespace EndustriApi.Entity;

public class Order:BaseEntity
{
    
    public Decimal TotalPrice => UnitPrice * Quantity;
    public int OrderId { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; } = null!;
    public virtual Product Product { get; set; } = null!;
}
    
