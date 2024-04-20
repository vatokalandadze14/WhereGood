using HouseOwnerWebApi.Data.EntityConfiguration;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }

        public DbSet<HouseOwner> HouseOwners { get; set; }
        public DbSet<Announcment> Announcments { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<InterierCompany> InterierCompanies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new AgencyConfiguration());
            modelBuilder.ApplyConfiguration(new AnnouncmentConfiguration());
            modelBuilder.ApplyConfiguration(new HouseOwnerConfiguration());
            modelBuilder.ApplyConfiguration(new PriceConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
