using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations.Read
{
    internal class RoomReadModelConfiguration : IEntityTypeConfiguration<RoomReadModel>
    {
        public void Configure(EntityTypeBuilder<RoomReadModel> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
