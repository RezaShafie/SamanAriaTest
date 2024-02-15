
namespace Saman.Application.Commands.User;

public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, bool>
{
   
    public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
