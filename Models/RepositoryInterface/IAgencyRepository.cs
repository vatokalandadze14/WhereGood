using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IAgencyRepository
    {
        public Task<ICollection<Agency>> GetAllAsync();
        public Task<Agency> GetSingleAsync(Guid id);
        public Task<Agency> AddAsync(AgencyDto address);
        public Task<Agency> UpdateAsync(Guid id, AgencyDto address);
        public Task<ICollection<Agency>> DeleteAsync(Guid id);
    }
}
