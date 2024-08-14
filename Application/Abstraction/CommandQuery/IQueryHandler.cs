using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using MediatR;

namespace Application.Abstraction.CommandQuery
{
    public interface IQueryHandler
    {
        public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
            where TQuery : IQuery<TResponse>
        {
            Task<Result<TResponse>> Handle(TQuery query, CancellationToken cancellationToken);
        }
    }
}
