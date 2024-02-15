namespace Saman.Application.Commands.User;

public sealed record CreateUserCommand(
    string FirstName,
    string LastName,
    string Email
    ) : ICommand<bool>;
