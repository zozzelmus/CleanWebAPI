using Application.Abstraction.CommandQuery;
using Application.Interfaces;
using Domain.Models;

namespace Application.Booking.Commands
{
    public sealed record ReserveRoomCommand(Guid UserId, int RoomId) : ICommand;
    public sealed record ReserveRoomCommandHandler : ICommandHandler<ReserveRoomCommand>
    {
        private readonly IUserQueries _userRepository;
        public ReserveRoomCommandHandler(IUserQueries userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Result> Handle(ReserveRoomCommand command, CancellationToken token)
        {
            var user = await _userRepository.GetByIdAsync(command.UserId, token);
            if (user is null)
            {
                return UserErrors.NotFound(command.UserId);
            }

            return Result.Success();
        }
    }
}

public static class UserErrors
{
    public static Error NotFound(Guid userId) => new Error("Users.NotFound", $"The user with the Id = '{userId}' was not found");
}