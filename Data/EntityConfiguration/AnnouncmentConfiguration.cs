using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Data.EntityConfiguration
{
    public class AnnouncmentConfiguration : IEntityTypeConfiguration<Announcment>
    {
        public void Configure(EntityTypeBuilder<Announcment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Price)
                .WithOne()
                .HasForeignKey<Price>(x => x.AnnouncmentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Images)
                .WithOne()
                .HasForeignKey(x => x.AnnouncmentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Address)
                .WithOne()
                .HasForeignKey<Address>(x => x.AnnouncmentId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
