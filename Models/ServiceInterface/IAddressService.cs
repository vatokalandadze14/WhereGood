using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Models.ServiceInterface
{
    public interface IAddressService
    {
        public Task<ICollection<Address>> GetAddresses();
        public Task<Address?> GetAddress(Guid id);
        public Task<Address> AddAddress(AddressDto address);
        public Task<Address?> UpdateAddress(Guid id, AddressDto address);
        public Task<ICollection<Address>?> DeleteAddress(Guid id);
    }
}
