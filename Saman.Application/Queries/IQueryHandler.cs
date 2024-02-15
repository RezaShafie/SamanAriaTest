using MediatR;

namespace Saman.Application.Queries
{
    internal interface IQueryHandler<TQeury, TResponse> : IRequestHandler<TQeury, TResponse>
        where TQeury : IQuery<TResponse>
    {
    }
}
