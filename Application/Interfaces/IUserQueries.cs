using Domain.Models;

namespace Application.Interfaces
{
    public interface IUserQueries
    {
        Task<UserReadModel?> GetByIdAsync(Guid id, CancellationToken token);
    }
}