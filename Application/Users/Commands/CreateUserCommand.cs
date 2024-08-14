using Application.Abstraction.CommandQuery;
using Application.Interfaces;
using Domain.Models;

namespace Application.Users.Commands
{
    public sealed record CreateUserCommand (
        string Name,
        string Email,
        string PhoneNumber,
        string? CardNumber,
        string Password) : ICommand;
    public sealed record CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserCommands _userCommands;
        public CreateUserCommandHandler(IUserCommands userCommands)
        {
            _userCommands = userCommands;
        }
        public async Task<Result> Handle(CreateUserCommand command, CancellationToken token)
        {
            User user = new()
            {
                Name = command.Name,
                Email = command.Email,
                PhoneNumber = command.PhoneNumber,
                CardNumber = command.CardNumber,
                Password = command.Password
            };

            try
            {
                await _userCommands.Add(user, token);
            }
            catch
            {
                return Result.Failure(CreateUserErrors.Failure());
            }

            return Result.Success();
        }
    }

    public static class CreateUserErrors 
    {
        public static Error Failure() => new Error("Test", "test");
    }
}

