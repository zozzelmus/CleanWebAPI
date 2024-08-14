using Domain.Models;
using MediatR;

namespace Application.Abstraction.CommandQuery
{
    public interface ICommand : IRequest<Result>, IBaseCommand;

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand;

    public interface IBaseCommand;
}
