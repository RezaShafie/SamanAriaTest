using Saman.Domain.Entities;

namespace Saman.Domain.Models;

public record Role : IEntity
{
    public string Name { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }
}
