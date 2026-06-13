using System;
using System.Collections.Generic;
using System.Text;
using Mediator;

namespace BuildingBlocks.Abstractions.Commands
{
    // dùng để xử lý các command có response, nếu command không có response thì dùng ICommandHandler<in TCommand>
    // ICommandHandler có chức năng xử lý các lệnh ghi dữ liệu, thường được sử dụng trong CQRS để tách biệt giữa các lệnh ghi và các truy vấn đọc dữ liệu
    public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Unit>
        where TCommand : ICommand<Unit>;
    // dùng để xử lý các command có response, TResponse là kiểu dữ liệu của kết quả trả về sau khi xử lý command
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
        where TResponse : notnull;
}
