using Domain.Models;
using MediatR;

namespace Application.Abstraction.CommandQuery
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
