using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IAddressRepository
    {
        public Task<ICollection<Address>> GetAsync();
        public Task<Address?> GetOneAsync(Guid id);
        public Task<Address> AddAsync(AddressDto address);
        public Task<Address?> UpdateAsync(Guid id, AddressDto address);
        public Task<ICollection<Address>?> DeleteSingleAsync(Guid id);
    }
}
