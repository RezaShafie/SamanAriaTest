namespace Saman.Domain.Entities;

public record Order : IEntity
{
    public int OrderNumber { get; set; }

    public OrderDetail OrderDetail { get; set; }
}
