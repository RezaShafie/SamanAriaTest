using MediatR;

namespace Saman.Application.Queries;

internal interface IQuery<out TResponse> : IRequest<TResponse>
{
}
