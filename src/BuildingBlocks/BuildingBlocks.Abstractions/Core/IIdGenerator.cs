using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Core
{
    public interface IIdGenerator<out TId>
    {
        TId New();
    }
}
