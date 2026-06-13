using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Events
{
    public interface IDomainEvent :IEvent
    {
        dynamic AggregateId { get; }

        long AggregateSequenceNumber { get; }

        public IDomainEvent WithAggregate(dynamic aggregateId, long version);
    }
}
