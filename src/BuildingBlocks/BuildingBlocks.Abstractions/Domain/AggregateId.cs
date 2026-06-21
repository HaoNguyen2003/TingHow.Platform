namespace BuildingBlocks.Abstractions.Domain;

public record AggregateId<T> : Identity<T>
{
    protected AggregateId(T value)
    {
        Value = value;
    }

    public static implicit operator T(AggregateId<T> id)
    {
        return id.Value;
    }

    public static AggregateId<T> CreateAggregateId(T id)
    {
        return new AggregateId<T>(id);
    }
}

public record AggregateId : AggregateId<long>
{
    protected AggregateId(long value)
        : base(value) { }

    public new static AggregateId CreateAggregateId(long value)
    {
        return new AggregateId(value);
    }

    public static implicit operator long(AggregateId? id) => id?.Value ?? default;
}
