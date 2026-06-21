using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Domain
{
    public interface IIdentity<out TId>
    {
        public TId Id { get; }
    }
}
