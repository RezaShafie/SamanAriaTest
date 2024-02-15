using System.ComponentModel.DataAnnotations;

namespace Saman.Domain.Entities;

public record IEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
