namespace Saman.Application.Commands.User;

public sealed record UpdateUserCommand(
    Guid Id,
    string FirstName,
    string LastName,
    string Email
    ) : ICommand<bool>;
