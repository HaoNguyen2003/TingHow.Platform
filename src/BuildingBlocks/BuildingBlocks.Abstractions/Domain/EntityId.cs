using System;
using System.Collections.Generic;
using System.Text;
using BuildingBlocks.Abstractions.Domain;

namespace BuildingBlocks.Abstractions.Domain;

public record EntityId<T> : Identity<T>
{
    protected EntityId(T value)
    {
        Value = value;
    }
    public static implicit operator T(EntityId<T> Id)
    {
        ArgumentNullException.ThrowIfNull(Id.Value);
        return Id.Value;
    }

    public static EntityId<T> Of(T id)
    {
        return new EntityId<T>(id);
    }
}
public record EntityId : EntityId<long>
{
    protected EntityId(long original) : base(original)
    {

    }

    public static implicit operator long(EntityId id)
    {
        return id.Value;
    }

    public static new EntityId Of(long id)
    {
        return new EntityId(id);
    }
}