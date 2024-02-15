namespace Saman.Domain.Entities;

public record Product : IEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }
}
