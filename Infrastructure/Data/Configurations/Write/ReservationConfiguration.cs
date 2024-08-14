using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations.Write
{
    internal sealed class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoomId });
            builder.HasIndex(x => new { x.UserId, x.RoomId });

            builder.HasOne(r => r.Room)
                .WithOne()
                .HasForeignKey<Reservation>(r => r.RoomId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
