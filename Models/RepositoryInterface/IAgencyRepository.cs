using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IAgencyRepository
    {
        public Task<ICollection<Agency>> GetAsync();
        public Task<Agency?> GetOneAsync(Guid id);
        public Task<Agency> AddAsync(AgencyDto address);
        public Task<Agency?> UpdateAsync(Guid id, AgencyDto address);
        public Task<ICollection<Agency>?> DeleteSingleAsync(Guid id);
    }
}
