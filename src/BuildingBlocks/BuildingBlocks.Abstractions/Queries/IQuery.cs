using System;
using System.Collections.Generic;
using System.Text;
using Mediator;

namespace BuildingBlocks.Abstractions.Queries
{
    public interface IQueryBase;
    public interface IQuery<out TResponse> : IQueryBase, IRequest<TResponse>
        where TResponse : notnull;
    public interface IStreamQueryBase;

    public interface IStreamQuery<out TResponse> : IStreamQueryBase, IStreamRequest<TResponse>
        where TResponse : notnull;

}
