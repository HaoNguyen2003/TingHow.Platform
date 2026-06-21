using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Domain
{
    public interface IHaveAudit : IHaveCreator
    {
        DateTime? LastModified { get; }
        Guid? LastModifiedBy { get; }
    }
}
