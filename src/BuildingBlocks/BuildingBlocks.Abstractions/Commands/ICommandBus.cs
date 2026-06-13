using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Commands
{
    public interface ICommandBus : IAsyncCommandBus
    {
        // dùng để gửi command đến handler xử lý, có thể là trong cùng một process hoặc qua mạng
        Task<TResult> SendAsync<TResult>(ICommand<TResult> command, CancellationToken cancellationToken = default)
            where TResult : notnull; 
        Task SendAsync(ICommand command, CancellationToken cancellationToken = default);
        // dùng để lên lịch thực thi command vào một thời điểm nào đó trong tương lai, có thể là ngay lập tức hoặc sau một khoảng thời gian nhất định   
        Task ScheduleAsync(IInternalCommand internalCommand, CancellationToken cancellationToken = default);
        // dùng để lên lịch thực thi nhiều command vào một thời điểm nào đó trong tương lai, có thể là ngay lập tức hoặc sau một khoảng thời gian nhất định
        Task ScheduleAsync(IInternalCommand[] internalCommands, CancellationToken cancellationToken = default);
    }
}
