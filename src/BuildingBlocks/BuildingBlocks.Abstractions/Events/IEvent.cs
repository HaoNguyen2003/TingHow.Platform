using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Events
{
    public interface IEvent
    {
        Guid EventId { get;}
        long EventVersion { get;}
        DateTime OccurredOn { get; }
        DateTimeOffset TimeStamp { get; }
        public string EventType { get; }

    }
}
