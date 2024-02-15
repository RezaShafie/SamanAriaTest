using Saman.Domain.Entities;

namespace Saman.Domain.Models;

public record Order : IEntity
{
    public int OrderNumber { get; set; }

    public Guid OrderDetailId { get; set; }
    public OrderDetail OrderDetail { get; set; }
}
