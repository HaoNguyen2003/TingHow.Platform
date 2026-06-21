using System;
using System.Collections.Generic;
using System.Text;
using BuildingBlocks.Abstractions.Events;

namespace BuildingBlocks.Abstractions.Domain
{
    public interface IAggregateBase
    {
        void AddDomainEvents(IDomainEvent domainEvent);
        public bool HasUncommittedDomainEvents();
        IReadOnlyList<IDomainEvent> DequeueUncommittedDomainEvents();
        IReadOnlyList<IDomainEvent> GetUncommittedDomainEvents();
        void ClearDomainEvents();
        void CheckRule(IBusinessRule rule);
    }
}
