using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseOwnerWebApi.Data.EntityConfiguration
{
    public class PriceConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Announcment)
                   .WithOne()
                   .HasForeignKey<Announcment>(x => x.PriceId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
