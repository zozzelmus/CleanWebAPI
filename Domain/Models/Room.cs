namespace Domain.Models
{
    public class Room
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public bool IsHandicapAccessable { get; set; }
        public bool IsBlindAccessable { get; set; }
        public bool IsDeafAccessable { get; set; }
    }
}
