using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Domain;

public interface IHaveIdentity<out TId> : IHaveIdentity
{
    new TId Id { get; }
    object IHaveIdentity.Id => Id;
}

public interface IHaveIdentity
{
    public object Id { get; }
}

