namespace Saman.Application.Commands.User;

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, bool>
{
    public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
