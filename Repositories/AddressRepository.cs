using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(DataContext context) : base(context)
        {
        }

        public async Task<ICollection<Address>> GetAllAsync()
        {
            return await _context.Addresses.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<Address> GetSingleAsync(Guid id)
        {
            return await _context.Addresses.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Address> AddAsync(AddressDto address)
        {
            var newAddress = new Address
            {
                City = address.city,
                Municipality = address.municipality,
                Longitude = address.longitude,
                Latitute = address.latitute,
                Region = address.region,
                District = address.district,
                Street = address.street,
                StreetNumber = address.streetNumber,
                AnnouncmentId = address.AnnouncmentId,
                AgencyId = address.AgencyId,
                CompanyId = address.CompanyId
            };

            if (newAddress == null)
                return null;

            return await AddAsync(newAddress);
        }

        public async Task<Address> UpdateAsync(Guid id, AddressDto address)
        {
            var newAddress = await _context.Addresses.FindAsync(id);
            if (newAddress == null)
                return null;

            newAddress.City = address.city;
            newAddress.Municipality = address.municipality;
            newAddress.Longitude = address.longitude;
            newAddress.Latitute = address.latitute;
            newAddress.Region = address.region;
            newAddress.District = address.district;
            newAddress.Street = address.street;
            newAddress.StreetNumber = address.streetNumber;

            await _context.SaveChangesAsync();
            return newAddress;
        }

        public async Task<ICollection<Address>> DeleteAsync(Guid id)
        {
            var address = await _context.Addresses.FindAsync(id);
            if (address == null)
                return null;

            address.IsDeleted = true;
            address.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.Addresses.ToListAsync();
        }
    }
}
