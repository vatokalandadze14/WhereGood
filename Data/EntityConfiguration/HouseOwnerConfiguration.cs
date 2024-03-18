using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Data.EntityConfiguration
{
    public class HouseOwnerConfiguration : IEntityTypeConfiguration<HouseOwner>
    {
        public void Configure(EntityTypeBuilder<HouseOwner> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasMany(x => x.Announcments)
                    .WithOne()
                    .HasForeignKey(x => x.HouseOwnerId)
                    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
