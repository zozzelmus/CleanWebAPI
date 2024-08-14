using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations.Read
{
    internal class ReservationReadModelConfiguration : IEntityTypeConfiguration<ReservationReadModel>
    {
        public void Configure(EntityTypeBuilder<ReservationReadModel> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoomId });

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Room)
                .WithOne()
                .HasForeignKey<ReservationReadModel>(x => x.RoomId);
        }
    }
}
