using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IAddressRepository
    {
        public Task<ICollection<Address>> GetAllAsync();
        public Task<Address> GetSingleAsync(Guid id);
        public Task<Address> AddAsync(AddressDto address);
        public Task<Address> UpdateAsync(Guid id, AddressDto address);
        public Task<bool> DeleteAsync(Guid id);
    }
}
