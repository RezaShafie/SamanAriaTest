using Saman.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Saman.Domain.Models;

public record Product : IEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }
}
