using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseOwnerWebApi.Migrations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<InterierCompany>
    {
        public void Configure(EntityTypeBuilder<InterierCompany> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasMany(x => x.Portfolios)
                .WithOne()
                .HasForeignKey(x => x.InterierCompanyId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
