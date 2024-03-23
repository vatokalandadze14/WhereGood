using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Services.HouseOwnerServiceFolder
{
    public interface IHouseOwnerService
    {
        public Task<ICollection<HouseOwner>> GetHouseOwners();
        public Task<HouseOwner> GetSingleHouseOwner(Guid id);
        public Task<HouseOwner> AddHouseOwner(HouseOwnerDto houseOwner);
        public Task<HouseOwner> UpdateHouseOwner(Guid id, HouseOwnerDto houseOwner);
        public Task<ICollection<HouseOwner>> DeleteHouseOwner(Guid id);
    }
}
