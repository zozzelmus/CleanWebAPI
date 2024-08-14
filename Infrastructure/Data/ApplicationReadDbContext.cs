using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    internal sealed class ApplicationReadDbContext : DbContext
    {
        public ApplicationReadDbContext(DbContextOptions<ApplicationReadDbContext> options)
            : base(options) 
        {
        }

        public DbSet<UserReadModel> Users { get; set; }
        public DbSet<RoomReadModel> Rooms { get; set; }
        public DbSet<ReservationReadModel> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ApplicationReadDbContext).Assembly,
                WriteConfigurationsFilter);
        }

        private static bool WriteConfigurationsFilter(Type type) =>
            type.FullName?.Contains("Configurations.Read") ?? false;
    }
}
