using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IHouseOwnerInterface
    {
        public Task<ICollection<HouseOwner>> GetAsync();
        public Task<HouseOwner?> GetOneAsync(Guid id);
        public Task<HouseOwner> AddAsync(HouseOwnerDto houseOwner);
        public Task<HouseOwner?> UpdateAsync(Guid id, HouseOwnerDto houseOwner);
        public Task<ICollection<HouseOwner>?> DeleteSingleAsync(Guid id);
    }
}
