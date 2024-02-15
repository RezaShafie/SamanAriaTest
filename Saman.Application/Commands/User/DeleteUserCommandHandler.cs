namespace Saman.Application.Commands.User;

public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand, bool>
{
    public Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
