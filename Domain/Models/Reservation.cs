namespace Domain.Models
{
    public class Reservation
    {
        public Guid UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDay { get; set; }
        public int NightCount { get; set; }

        public User User { get; set; } = null!;
        public Room Room { get; set; } = null!;
    }
}
