using MediatR;
using System.Data;
using System.Windows.Input;

namespace BuildingBlocks.CQRS
{
    public interface Icommand : ICommand<Unit>
    {
    }

    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
