using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.AddressServiceFolder
{
    public class AddressService : IAddressService
    {
        private readonly DataContext _context;
        public AddressService(DataContext context)
        {
            _context = context;
        }
        public async Task<Address> AddAddress(AddressDto address)
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
                AgencyId = address.AgencyId
            };

            _context.Addresses.Add(newAddress);
            await _context.SaveChangesAsync();

            return newAddress;
        }

        public async Task<ICollection<Address>> DeleteAddress(Guid id)
        {
            var address = await _context.Addresses.FindAsync(id);
            if (address == null)
                return null;

            address.IsDeleted = true;
            address.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.Addresses.ToListAsync();
        }

        public async Task<Address> GetAddress(Guid id)
        {
            var address = await _context.Addresses.FindAsync(id);
            if (address == null)
                return null;

            return address;
        }

        public async Task<ICollection<Address>> GetAddresses()
        {
            return await _context.Addresses.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<Address> UpdateAddress(Guid id, AddressDto address)
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
            newAddress.AnnouncmentId = address.AnnouncmentId;
            newAddress.AgencyId = address.AgencyId;

            await _context.SaveChangesAsync();
            return newAddress;
        }
    }
}
