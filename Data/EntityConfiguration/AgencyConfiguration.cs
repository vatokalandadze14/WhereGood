using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseOwnerWebApi.Data.EntityConfiguration
{
    public class AgencyConfiguration : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Address)
                .WithOne()
                .HasForeignKey<Address>(x => x.AgencyId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.SocialLinks)
                .WithOne()
                .HasForeignKey(x => x.AgencyId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
