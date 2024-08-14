namespace Domain.Models
{
    public sealed class UserReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? CardNumber { get; set; }
        public string Password { get; set; } = null!;
    }
}
