using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Queries
{
    internal class UserQueries : IUserQueries
    {
        private readonly ApplicationReadDbContext _context;
        public UserQueries(ApplicationReadDbContext context)
        {
            _context = context;
        }
        public Task<UserReadModel?> GetByIdAsync(Guid id, CancellationToken token)
        {
            return _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
