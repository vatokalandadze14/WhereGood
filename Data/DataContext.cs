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
        public DbSet<Image> Images { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<InterierCompany> InterierCompanies { get; set; }
    }
}
