using System.ComponentModel.DataAnnotations.Schema;

namespace Saman.Domain.Entities;

public record OrderDetail : IEntity
{
    [ForeignKey(nameof(OrderId))]
    public Guid OrderId { get; set; }
    public Order Order { get; set; }

    [ForeignKey(nameof(ProductId))]
    public Guid ProductId { get; set; }
    public Product Product { get; set; }

    public uint Quantity { get; set; }
    public decimal TotalPrice { get; set; }
}