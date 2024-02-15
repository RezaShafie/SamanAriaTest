namespace Saman.Application.Commands.User;

public sealed record DeleteUserCommand(Guid Id) : ICommand<bool>;
