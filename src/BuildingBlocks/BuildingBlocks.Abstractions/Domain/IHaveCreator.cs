using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Domain
{
    public interface IHaveCreator
    {
        DateTime Created { get; set; }
        Guid? CreatedBy { get; set; }
    }
}
