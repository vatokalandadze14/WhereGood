using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;
using HouseOwnerWebApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace HouseOwnerWebApi.Services
{
    public class AddressService : IAddressService
    {
        private readonly DataContext _context;
        private readonly IAddressRepository addressRepository;
        public AddressService(DataContext context, IAddressRepository addressRepository)
        {
            _context = context;
            this.addressRepository = addressRepository;
        }
        public async Task<Address>? AddAddress(AddressDto address)
        {
            return await addressRepository.AddAsync(address);
        }

        public async Task<ICollection<Address>> DeleteAddress(Guid id)
        {
            await addressRepository.DeleteAsync(id);
            return await _context.Addresses.ToListAsync();
        }

        public async Task<Address> GetAddress(Guid id)
        {
            return await addressRepository.GetSingleAsync(id);
        }

        public async Task<ICollection<Address>> GetAddresses()
        {
            return await addressRepository.GetAllAsync();
        }

        public async Task<Address> UpdateAddress(Guid id, AddressDto address)
        {
            return await addressRepository.UpdateAsync(id, address);
        }
    }
}
