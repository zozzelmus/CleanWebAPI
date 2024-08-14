using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Commands
{
    internal class UserCommands : IUserCommands
    {
        private readonly ApplicationWriteDbContext _context;
        public UserCommands(ApplicationWriteDbContext context) 
        {
            _context = context;
        }

        public async Task Add(User user, CancellationToken token)
        {
            await _context.AddAsync(user, token);
            await _context.SaveChangesAsync(token);
        }
    }
}
