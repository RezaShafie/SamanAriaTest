namespace Saman.Domain.Models;

public class OrderDetail
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public uint Quantity { get; set; }
    public decimal TotalPrice { get; set; }
}