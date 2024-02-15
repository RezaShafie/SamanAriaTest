using Saman.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Saman.Domain.Models;

public record User : IEntity
{
    [MinLength(2)]
    [MaxLength(100)]
    public string FirstName { get; set; }
    [MinLength(2)]
    [MaxLength(150)]
    public string LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }
}
