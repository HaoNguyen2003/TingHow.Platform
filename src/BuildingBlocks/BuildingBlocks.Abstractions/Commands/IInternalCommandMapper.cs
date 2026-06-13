using System;
using System.Collections.Generic;
using System.Text;
using BuildingBlocks.Abstractions.Events;

namespace BuildingBlocks.Abstractions.Commands
{
    public interface IInternalCommandMapper
    {
        // dùng để chuyển đổi một hoặc nhiều domain event thành một hoặc nhiều internal command, có thể sử dụng thông tin từ domain event để tạo ra các internal command phù hợp với ngữ cảnh và yêu cầu của hệ thống   
        IReadOnlyList<IInternalCommand?>? MapToInternalCommands(IReadOnlyList<IDomainEvent> domainEvents);
        IInternalCommand? MapToInternalCommand(IDomainEvent domainEvent);
    }
}
