namespace Domain.Models
{
    public sealed class ReservationReadModel
    {
        public Guid UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDay { get; set; }
        public int NightCount { get; set; }

        public UserReadModel User { get; set; } = null!;
        public RoomReadModel Room { get; set; } = null!;
    }
}
