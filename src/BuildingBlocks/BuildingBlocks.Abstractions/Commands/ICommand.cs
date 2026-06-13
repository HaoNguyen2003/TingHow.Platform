using Mediator;

namespace BuildingBlocks.Abstractions.Commands
{
    // dùng để đánh dấu interface này là một command, không phải là một request thông thường
    public interface ICommandBase;
    // Lệnh Ghi dữ liệu không trả về kết quả, tương đương với Unit trong Mediator
    public interface ICommand : ICommand<Unit>;
    // Lệnh Ghi dữ liệu có trả về kết quả, TResponse là kiểu dữ liệu của kết quả trả về
    public interface ICommand<out TResponse> : IRequest<TResponse>, ICommandBase where TResponse : notnull;
}
