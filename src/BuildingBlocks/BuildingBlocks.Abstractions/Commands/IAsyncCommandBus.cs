using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Commands
{
    public interface IAsyncCommandBus
    {
        // dùng để gửi command đến handler xử lý, có thể là trong cùng một process hoặc qua mạng
        public Task SendExternalAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
            where TCommand : class, IAsyncCommand;
    }
}
