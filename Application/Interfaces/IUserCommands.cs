using Domain.Models;

namespace Application.Interfaces
{
    public interface IUserCommands
    {
        Task Add(User user, CancellationToken token);
    }
}
