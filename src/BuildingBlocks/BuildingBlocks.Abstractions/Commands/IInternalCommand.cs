using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Commands
{
    // IInternalCommand là một loại lệnh đặc biệt được sử dụng để lên lịch thực thi vào một thời điểm nào đó trong tương lai, có thể là ngay lập tức hoặc sau một khoảng thời gian nhất định
    public interface IInternalCommand : ICommand
    {
        Guid InternalCommandId { get; }
        DateTime OccurredOn { get; }
        string Type { get; }
    }
}
