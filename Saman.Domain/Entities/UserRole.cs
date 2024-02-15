using Saman.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saman.Domain.Models;

public record UserRole : IEntity
{
    [ForeignKey(nameof(UserId))]
    public Guid UserId { get; set; }
    public User User { get; set; }

    [ForeignKey(nameof(RoleId))]
    public Guid RoleId { get; set; }
    public Role Role { get; set; }
}
