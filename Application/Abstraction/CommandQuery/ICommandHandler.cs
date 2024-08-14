using Domain.Models;
using MediatR;

namespace Application.Abstraction.CommandQuery
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
        where TCommand : ICommand
    {
        Task<Result> Handle(TCommand command, CancellationToken cancellationToken);
    }
    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
        where TCommand : ICommand<TResponse>
    { 
        Task<Result<TResponse>> Handle(TCommand command, CancellationToken cancellationToken);
    }
}