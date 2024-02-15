namespace Saman.Domain.Entities;

public record Role : IEntity
{
    public string Name { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }
}
