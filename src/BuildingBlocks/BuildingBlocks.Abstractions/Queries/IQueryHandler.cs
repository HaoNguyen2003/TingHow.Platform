using System;
using System.Collections.Generic;
using System.Text;
using Mediator;

namespace BuildingBlocks.Abstractions.Queries
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery,TResponse>
        where TQuery : IQuery<TResponse>
        where TResponse : notnull;

    public interface IStreamQueryHandler<in TQuery, TResponse> : IStreamRequestHandler<TQuery, TResponse>
        where TQuery : IStreamQuery<TResponse>
        where TResponse : notnull;
}
