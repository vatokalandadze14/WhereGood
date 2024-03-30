using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseOwnerWebApi.Data.EntityConfiguration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.Address)
                .WithOne()
                .HasForeignKey<Address>(x => x.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.SocialLinks)
                .WithOne()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
